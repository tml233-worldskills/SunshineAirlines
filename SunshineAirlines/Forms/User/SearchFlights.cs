using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines.Forms.User {
	public partial class SearchFlights : Form {
		int uid;
		public SearchFlights(int uid) {
			this.uid = uid;
			InitializeComponent();
		}

		bool roundWays = false;
		List<string> cityCodes = new List<string>();
		List<int> cabinTypes = new List<int>();
		private void SearchFlights_Load(object sender, EventArgs e) {
			inputOneWay.Checked = true;

			foreach (var r in Utils.ExecuteReader("SELECT CityCode, CityName FROM City ORDER BY CityName")) {
				var code = r["CityCode"] as string;
				var name = r["CityName"] as string;
				cityCodes.Add(code);
				inputCityFrom.Items.Add(name);
				inputCityTo.Items.Add(name);
			}
			inputCityFrom.SelectedIndex = 0;
			inputCityTo.SelectedIndex = 0;

			foreach(var r in Utils.ExecuteReader("SELECT CabinTypeId,CabinTypeName FROM CabinType")) {
				var id = (int)r["CabinTypeId"];
				var name = r["CabinTypeName"] as string;
				cabinTypes.Add(id);
				inputCabinType.Items.Add(name);
			}
			inputCabinType.SelectedIndex = 0;

			inputFlightType.SelectedIndex = 0;

			//inputDateDeparture.MinDate = DateTime.Now;
			UpdateReturnDate();
		}
		void UpdateRoundWays() {
			panelReturnDate.Visible = roundWays;
		}
		void UpdateReturnDate() {
			inputDateReturn.MinDate = inputDateDeparture.Value;
		}

		int? GetFlightRatio(object flightNumber,DateTime date) {
			object r = Utils.ExecuteScalar("SELECT CASE COUNT(ActualArrivalTime) WHEN 0 THEN NULL ELSE SUM(CASE SIGN(DATEDIFF(MINUTE,DATEADD(MINUTE,FlightTime,CAST(Date AS DATETIME)+CAST(Time AS DATETIME)),ActualArrivalTime)-15) WHEN 1 THEN 0 ELSE 1 END)/CAST(COUNT(ActualArrivalTime) AS DECIMAL)*100 END FROM Schedule INNER JOIN Route ON Schedule.RouteId=Route.RouteId RIGHT JOIN FlightStatus ON Schedule.ScheduleId=FlightStatus.ScheduleId WHERE FlightNumber=@0 AND Date>=DATEADD(DAY,-30,@1) AND Date<@1", flightNumber, date);
			if (r == DBNull.Value) {
				return null;
			}
			return (int)Math.Round((decimal)r);
		}

		const string ScheduleInfoSql = "SELECT (SELECT CabinTypeName FROM CabinType WHERE CabinTypeId=@1) AS CabinTypeName, CASE @1 WHEN 1 THEN EconomyPrice WHEN 2 THEN EconomyPrice*1.25 WHEN 3 THEN EconomyPrice*1.5 END AS Price, CityFrom.CityName+'/'+AirportFrom.IATACode AS [From], CityTo.CityName+'/'+AirportTo.IATACode AS [To], CAST(Date AS DATETIME)+CAST(Time AS DATETIME) as FromTime, DATEADD(MINUTE,FlightTime,TIMEFROMPARTS(0,0,0,0,0)) as FlightTime, FlightNumber FROM Schedule INNER JOIN Route ON Schedule.RouteId=Route.RouteId INNER JOIN Airport AS AirportFrom ON Route.DepartureAirportIATA=AirportFrom.IATACode INNER JOIN City AS CityFrom ON AirportFrom.CityCode=CityFrom.CityCode INNER JOIN Airport AS AirportTo ON Route.ArrivalAirportIATA=AirportTo.IATACode INNER JOIN City AS CityTo ON AirportTo.CityCode=CityTo.CityCode WHERE ScheduleId=@0";
		void FillDataNonStop(FlowLayoutPanel panel, string cityFrom,string cityTo, DateTime date, int cabinType) {
			foreach(var r in Utils.ExecuteReader("SELECT Amount.ScheduleId, Amount.Amount-Reserved AS Remains FROM (SELECT ScheduleId,CASE @3 WHEN 1 THEN EconomySeatsAmount WHEN 2 THEN BusinessSeatsAmount WHEN 3 THEN FirstSeatsAmount END AS Amount FROM Schedule, Aircraft WHERE Schedule.AircraftId=Aircraft.AircraftId) AS Amount INNER JOIN (SELECT Schedule.ScheduleId, COUNT(ReservationId) AS Reserved FROM Schedule INNER JOIN Route ON Schedule.RouteId=Route.RouteId INNER JOIN Airport AS AirportFrom ON Route.DepartureAirportIATA=AirportFrom.IATACode INNER JOIN City AS CityFrom ON AirportFrom.CityCode=CityFrom.CityCode INNER JOIN Airport AS AirportTo ON Route.ArrivalAirportIATA=AirportTo.IATACode INNER JOIN City AS CityTo ON AirportTo.CityCode=CityTo.CityCode LEFT JOIN FlightReservation ON Schedule.ScheduleId=FlightReservation.ScheduleId WHERE CityFrom.CityCode=@0 AND CityTo.CityCode=@1 AND Date=@2 AND (CabinTypeId IS NULL OR CabinTypeId=@3) GROUP BY Schedule.ScheduleId) AS Reserves ON Amount.ScheduleId=Reserves.ScheduleId", cityFrom, cityTo, date, cabinType)) {
				var form = new FlightItem(panel);
				int scheduleId = (int)r["ScheduleId"];
				int remains = (int)r["Remains"];

				foreach(var r2 in Utils.ExecuteReader(ScheduleInfoSql, scheduleId, cabinType)) {
					form.lblCabinType.Text = r2["CabinTypeName"].ToString();
					form.lblFromPlace.Text = r2["From"].ToString();
					form.lblToPlace.Text = r2["To"].ToString();
					var timeFrom = (DateTime)r2["FromTime"];
					form.lblFromTime.Text = (timeFrom).ToString("yyyy-MM-dd HH:mm");
					var flightTime = (TimeSpan)r2["FlightTime"];
					form.lblToTime.Text = (timeFrom + flightTime).ToString("yyyy-MM-dd HH:mm");
					form.lblTotalTime.Text = "Total Time: " + flightTime.ToString("hh'h 'mm'm'");
					form.lblPrice.Text = string.Format("${0:F2}", (float)(decimal)r2["Price"]);
					var flightNumber = r2["FlightNumber"];
					var ratio = GetFlightRatio(flightNumber, date);
					if (ratio == null) {
						form.lblFlights.Text = string.Format("Flight {0}", flightNumber);
					} else {
						form.lblFlights.Text = string.Format("Flight {0}({1}%)", flightNumber, ratio.Value);
					}
					form.lblStop.Text = "Non-Stop";
					form.lblTickets.Text = remains + " available ticket(s)";
					if (remains <= 3) {
						form.lblTickets.ForeColor = Color.Red;
					}
				}
				form.Size = new Size(form.Size.Width, 150);
				panel.Controls.Add(form);
			}
		}

		void FillDataStop(FlowLayoutPanel panel, string cityFrom, string cityTo, DateTime date, int cabinType) {
			foreach(var r in Utils.ExecuteReader(@"SELECT A.ScheduleId as ScheduleA, B.ScheduleId as ScheduleB, DATEDIFF(MINUTE,A.ArrivalTime,B.DepartureTime) / 60.0 AS IntermediateTime FROM ( SELECT AirportTo.IATACode AS AirportTo, ScheduleId, DATEADD(MINUTE,Route.FlightTime,CAST(Date AS DATETIME)+CAST(Time AS DATETIME)) as ArrivalTime FROM Schedule INNER JOIN Route ON Schedule.RouteId=Route.RouteId INNER JOIN Airport AS AirportFrom ON Route.DepartureAirportIATA=AirportFrom.IATACode INNER JOIN City AS CityFrom ON AirportFrom.CityCode=CityFrom.CityCode INNER JOIN Airport AS AirportTo ON Route.ArrivalAirportIATA=AirportTo.IATACode WHERE CityFrom.CityCode=@0 AND Date=@2 ) AS A INNER JOIN ( SELECT AirportFrom.IATACode AS AirportFrom, ScheduleId, CAST(Date AS DATETIME)+CAST(Time AS DATETIME) as DepartureTime FROM Schedule INNER JOIN Route ON Schedule.RouteId=Route.RouteId INNER JOIN Airport AS AirportFrom ON Route.DepartureAirportIATA=AirportFrom.IATACode INNER JOIN Airport AS AirportTo ON Route.ArrivalAirportIATA=AirportTo.IATACode INNER JOIN City AS CityTo ON AirportTo.CityCode=CityTo.CityCode WHERE CityTo.CityCode=@1 AND Date>=@2 ) AS B ON A.AirportTo=B.AirportFrom WHERE B.DepartureTime>A.ArrivalTime AND DATEDIFF(MINUTE,A.ArrivalTime,B.DepartureTime)>=2*60 AND DATEDIFF(MINUTE,A.ArrivalTime,B.DepartureTime)<=9*60", cityFrom, cityTo, date)) {
				const string RemainsSql = @"SELECT Amount.Amount-Reserved FROM (SELECT ScheduleId, CASE @1 WHEN 1 THEN EconomySeatsAmount WHEN 2 THEN BusinessSeatsAmount WHEN 3 THEN FirstSeatsAmount END AS Amount  FROM Schedule, Aircraft WHERE Schedule.AircraftId=Aircraft.AircraftId) AS Amount INNER JOIN (SELECT Schedule.ScheduleId, COUNT(ReservationId) AS Reserved FROM Schedule LEFT JOIN FlightReservation ON Schedule.ScheduleId=FlightReservation.ScheduleId WHERE (CabinTypeId IS NULL OR CabinTypeId=@1) GROUP BY Schedule.ScheduleId) AS Reserves ON Amount.ScheduleId=Reserves.ScheduleId WHERE Amount.ScheduleId=@0";
				object scheduleA = r["ScheduleA"];
				object scheduleB = r["ScheduleB"];
				int remainsA = (int)Utils.ExecuteScalar(RemainsSql, scheduleA, cabinType);
				int remainsB = (int)Utils.ExecuteScalar(RemainsSql, scheduleB, cabinType);
				int remains = Math.Min(remainsA, remainsB);
				if (remains <= 0) {
					continue;
				}
				var form = new FlightItem(panel);

				DateTime totalTimeFrom = new DateTime(0);
				DateTime totalTimeTo = new DateTime(0);

				DateTime transferTimeFrom = new DateTime(0);
				DateTime transferTimeTo = new DateTime(0);
				string transferPlace = "";
				float totalPrice = 0;
				string flights = "";

				foreach (var r2 in Utils.ExecuteReader(ScheduleInfoSql, scheduleA, cabinType)) {
					form.lblCabinType.Text = r2["CabinTypeName"].ToString();
					form.lblFromPlace.Text = r2["From"].ToString() + "\n" + r2["To"].ToString();
					transferPlace = r2["To"].ToString();

					var timeFrom = (DateTime)r2["FromTime"];
					totalTimeFrom = timeFrom;
					var flightTime = (TimeSpan)r2["FlightTime"];
					var timeTo = timeFrom + flightTime;
					transferTimeFrom = timeTo;
					form.lblFromTime.Text = timeFrom.ToString("yyyy-MM-dd HH:mm") + "\n" + timeTo.ToString("yyyy-MM-dd HH:mm");
					totalPrice += (float)(decimal)r2["Price"];
					var flightNumber = r2["FlightNumber"];
					var ratio = GetFlightRatio(flightNumber, date);
					if (ratio == null) {
						flights += string.Format("Flight {0}", flightNumber);
					} else {
						flights += string.Format("Flight {0}({1}%)", flightNumber, ratio.Value);
					}
				}

				foreach (var r2 in Utils.ExecuteReader(ScheduleInfoSql, scheduleB, cabinType)) {
					form.lblToPlace.Text = r2["From"].ToString() + "\n" + r2["To"].ToString();

					var timeFrom = (DateTime)r2["FromTime"];
					transferTimeTo = timeFrom;
					var flightTime = (TimeSpan)r2["FlightTime"];
					var timeTo = timeFrom + flightTime;
					totalTimeTo = timeTo;
					form.lblToTime.Text = timeFrom.ToString("yyyy-MM-dd HH:mm") + "\n" + timeTo.ToString("yyyy-MM-dd HH:mm");
					totalPrice += (float)(decimal)r2["Price"];
					var flightNumber = r2["FlightNumber"];
					var ratio = GetFlightRatio(flightNumber, date);
					if (ratio == null) {
						flights += string.Format("\nFlight {0}", flightNumber);
					} else {
						flights += string.Format("\nFlight {0}({1}%)", flightNumber, ratio.Value);
					}
				}

				form.lblPrice.Text = string.Format("${0:F2}", totalPrice);
				form.lblTotalTime.Text = "Total Time: " + (totalTimeTo - totalTimeFrom).ToString("hh'h 'mm'm'");
				form.lblTransfer.Text = (transferTimeTo - transferTimeFrom).ToString("hh'h 'mm'm'") + " Transfer in " + transferPlace;
				form.lblFlights.Text = flights;
				form.lblStop.Text = "1-Stop";
				form.lblTickets.Text = remains + " available ticket(s)";
				if (remains <= 3) {
					form.lblTickets.ForeColor = Color.Red;
				}
				form.Size = new Size(form.Size.Width, 195);

				panel.Controls.Add(form);

			}
		}


			private void inputDateDeparture_ValueChanged(object sender, EventArgs e) {
			UpdateReturnDate();
		}

		private void inputOneWay_CheckedChanged(object sender, EventArgs e) {
			roundWays = false;
			UpdateRoundWays();
		}

		private void inputRoundWays_CheckedChanged(object sender, EventArgs e) {
			roundWays = true;
			UpdateRoundWays();
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			int flightType = inputFlightType.SelectedIndex;
			string cityFrom = cityCodes[inputCityFrom.SelectedIndex];
			string cityTo = cityCodes[inputCityTo.SelectedIndex];
			int cabinType = cabinTypes[inputCabinType.SelectedIndex];
			DateTime dateDeparture = inputDateDeparture.Value.Date;

			panelDeparture.Controls.Clear();
			panelReturn.Controls.Clear();


			if (flightType == 0 || flightType == 1) {
				FillDataNonStop(panelDeparture, cityFrom, cityTo, dateDeparture, cabinType);
				if (roundWays) {
					DateTime dateReturn = inputDateReturn.Value.Date;
					FillDataNonStop(panelReturn, cityTo, cityFrom, dateReturn, cabinType);
				}
			}
			if (flightType == 0 || flightType == 2) {
				FillDataStop(panelDeparture, cityFrom, cityTo, dateDeparture, cabinType);
				if (roundWays) {
					DateTime dateReturn = inputDateReturn.Value.Date;
					FillDataStop(panelReturn, cityTo, cityFrom, dateReturn, cabinType);
				}
			}

		}
	}
}
