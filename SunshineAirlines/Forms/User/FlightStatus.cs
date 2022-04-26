using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SunshineAirlines.Forms.User {
	public partial class FlightStatus : Form {
		public FlightStatus() {
			InitializeComponent();
		}

		const string sql = "SELECT FlightNumber, CityFrom.CityName+'/'+AirportFrom.IATACode AS [From], CityTo.CityName+'/'+AirportTo.IATACode AS [To], FORMAT([Time],'hh\\:mm') AS ScheduleStart, FORMAT(Times.ScheduleArrival,'HH:mm') AS ScheduleArrival, FORMAT(Times.ActualArrival,'HH:mm') AS ActualArrival, Gate, CASE SIGN(DATEDIFF(MINUTE,Times.ScheduleArrival,Times.ActualArrival)) WHEN 1 THEN 'Delay '+CAST(DATEDIFF(MINUTE,Times.ScheduleArrival,Times.ActualArrival) AS VARCHAR)+' Minute(s)' WHEN -1 THEN 'Early '+CAST(-DATEDIFF(MINUTE,Times.ScheduleArrival,Times.ActualArrival) AS VARCHAR)+' Minute(s)' ELSE 'On Time' END AS [Status] FROM Schedule, [Route], (SELECT Schedule.ScheduleId AS ScheduleId, DATEADD(MINUTE,Route.FlightTime,CAST([Date] AS DATETIME)+CAST([Time] AS DATETIME)) AS ScheduleArrival, ActualArrivalTime AS ActualArrival FROM Schedule, [Route], FlightStatus WHERE (@0=0 OR [Date]=@1) AND Schedule.RouteId=[Route].RouteId AND Schedule.ScheduleId=FlightStatus.ScheduleId) AS Times, Airport AS AirportFrom, City AS CityFrom, Airport AS AirportTo, City AS CityTo WHERE (@0=0 OR Schedule.[Date]=@1) AND Schedule.RouteId=[Route].RouteId AND Schedule.ScheduleId=Times.ScheduleId AND [Route].DepartureAirportIATA=AirportFrom.IATACode AND AirportFrom.CityCode=CityFrom.CityCode AND [Route].ArrivalAirportIATA=AirportTo.IATACode AND AirportTo.CityCode=CityTo.CityCode";

		private void FlightStatus_Load(object sender, EventArgs e) {
			inputDate.MaxDate = DateTime.Now;
			RefreshData(null);
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			RefreshData(inputDate.Value.Date);
		}

		void RefreshData(DateTime? date) {
			var table = Utils.ExecuteTable(sql, date.HasValue, date ?? DateTime.Today);
			var ds = new ReportDataSource("DataSet1", table);
			reportViewer.LocalReport.DataSources.Clear();
			reportViewer.LocalReport.DataSources.Add(ds);
			reportViewer.RefreshReport();
		}
	}
}
