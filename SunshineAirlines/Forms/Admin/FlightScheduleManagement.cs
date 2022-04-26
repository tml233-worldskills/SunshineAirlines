using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines.Forms.Admin {
	public partial class FlightScheduleManagement : Form {
		public FlightScheduleManagement() {
			InitializeComponent();
		}

		bool byCity = false;

		bool lastByCity = false;
		string lastFrom = "";
		string lastTo = "";
		DateTime lastDateFrom;
		DateTime lastDateTo;

		List<string> airportIds = new List<string>();
		List<string> airportNames = new List<string>();
		List<string> cityIds = new List<string>();
		List<string> cityNames=new List<string>();
		private void UserManagement_Load(object sender, EventArgs e) {
			comboFrom.Items.Add("All");
			comboFrom.SelectedIndex = 0;
			foreach(var r in Utils.ExecuteReader("SELECT IATACode as Id FROM Airport ORDER BY Id")) {
				airportIds.Add(r["Id"].ToString());
				airportNames.Add(r["Id"].ToString());
			}
			foreach (var r in Utils.ExecuteReader("SELECT CityCode as Id, CityName as Name FROM City ORDER BY Name")) {
				cityIds.Add(r["Id"].ToString());
				cityNames.Add(r["Name"].ToString());
			}
			radioAirport.Checked = true;
		}

		void UpdateByMode() {
			byCity = radioCity.Checked;
			comboFrom.Items.Clear();
			comboTo.Items.Clear();
			List<string> list = byCity ? cityNames : airportNames;
			foreach(var name in list) {
				comboFrom.Items.Add(name);
				comboTo.Items.Add(name);
			}
			comboFrom.SelectedIndex = comboFrom.Items.Count > 0 ? 0 : -1;
			comboTo.SelectedIndex = comboTo.Items.Count > 0 ? 0 : -1;

		}
		private void btnSearch_Click(object sender, EventArgs e) {
			lastByCity = byCity;
			var ids = byCity ? cityIds : airportIds;
			lastFrom = ids[comboFrom.SelectedIndex];
			lastTo = ids[comboTo.SelectedIndex];
			lastDateFrom = inputDateFrom.Value.Date;
			lastDateTo = inputDateTo.Value.Date;

			UpdateData();
		}

		void UpdateData() {
			string sql = @"SELECT ScheduleId,FORMAT(Date,'yyyy-MM-dd') AS Date ,FORMAT(Time,'hh\:mm') AS Time,CityFrom.CityName+'/'+AirportFrom.IATACode AS [From],CityTo.CityName+'/'+AirportTo.IATACode AS [To],Aircraft.Name as Aircraft,EconomyPrice,FlightNumber, Gate, Status FROM Schedule,Aircraft,Route, Airport as AirportFrom, City as CityFrom, Airport as AirportTo, City as CityTo WHERE Schedule.AircraftId=Aircraft.AircraftId AND Schedule.RouteId=Route.RouteId AND AirportFrom.CityCode=CityFrom.CityCode AND AirportFrom.IATACode=Route.DepartureAirportIATA AND AirportTo.CityCode=CityTo.CityCode AND AirportTo.IATACode=Route.ArrivalAirportIATA AND Date>=@0 AND Date<=@1";
			if (!byCity) {
				sql += " AND AirportFrom.IATACode=@2 AND AirportTo.IATACode=@3";
			} else {
				sql += " AND CityFrom.CityCode=@2 AND CityTo.CityCode=@3";
			}
			dataGridView.DataSource = Utils.ExecuteQuery(sql, lastDateFrom, lastDateTo, lastFrom, lastTo);
		}


		private void btnExchange_Click(object sender, EventArgs e) {
			int index = comboFrom.SelectedIndex;
			comboFrom.SelectedIndex=comboTo.SelectedIndex;
			comboTo.SelectedIndex = index;
		}

		private void radioAirport_CheckedChanged(object sender, EventArgs e) {
			UpdateByMode();
		}

		private void radioCity_CheckedChanged(object sender, EventArgs e) {
			UpdateByMode();
		}

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex == -1 || e.ColumnIndex == -1) {
				return;
			}
			if (dataGridView.Columns[e.ColumnIndex].Name != "ColumnDetail") {
				return;
			}
			int id = (int)(dataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView)["ScheduleId"];
			MessageBox.Show(id.ToString());
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			if (dataGridView.SelectedCells.Count == 0) {
				MessageBox.Show("Please select a schedule!");
				return;
			}
			int rowIndex = dataGridView.SelectedCells[0].RowIndex;
			var dataRow = dataGridView.Rows[rowIndex].DataBoundItem as DataRowView;
			int id = (int)dataRow["ScheduleId"];
			string status = dataRow["Status"].ToString();
			string newStatus = status == "Confirmed" ? "Canceled" : "Confirmed";

			Utils.ExecuteUpdate("UPDATE Schedule SET Status=@1 WHERE ScheduleId=@0", id, newStatus);
			UpdateData();

			dataGridView.ClearSelection();
			dataGridView.Rows[rowIndex].Selected = true;

		}
	}
}
