using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SunshineAirlines.Forms.Admin {
	public partial class TicketStatistics : Form {
		public TicketStatistics() {
			InitializeComponent();
			table = new DataTable();
			table.Columns.Add("Month", typeof(string));
			table.Columns.Add("MonthValue", typeof(int));
			table.Columns.Add("FlightsAmount", typeof(int));
			table.Columns.Add("TicketsAmount", typeof(int));
			table.Columns.Add("TicketsRevenue", typeof(float));
		}

		Series series;
		private void UserManagement_Load(object sender, EventArgs e) {
			series = chart.Series[0];
			series.ChartType = SeriesChartType.Line;
			series.IsVisibleInLegend = false;
			comboViewBy.SelectedIndex = 0;
		}

		DataTable table;
		private void button1_Click(object sender, EventArgs e) {
			table.Rows.Clear();

			DateTime dateFrom = inputDateFrom.Value.Date;
			dateFrom=dateFrom.AddDays(-dateFrom.Day + 1);
			DateTime dateTo = inputDateTo.Value.Date;
			dateTo=dateTo.AddDays(-dateTo.Day + 1);
			for (; dateFrom <= dateTo; dateFrom = dateFrom.AddMonths(1)) {
				var row = table.NewRow();
				row["Month"] = dateFrom.ToString("yyyy-MM");
				int monthValue = dateFrom.Year * 100 + dateFrom.Month;
				row["MonthValue"] = monthValue;

				foreach (var r in Utils.ExecuteReader("SELECT ISNULL(COUNT(DISTINCT Schedule.ScheduleId),0) as FlightsAmount,ISNULL(COUNT(ReservationId),0) as TicketsAmount,ISNULL(SUM(CASE CabinTypeId WHEN 1 THEN EconomyPrice WHEN 2 THEN EconomyPrice*1.25 WHEN 3 THEN EconomyPrice*1.5 END),0) as TicketsRevenue FROM Schedule LEFT JOIN FlightReservation ON Schedule.ScheduleId=FlightReservation.ScheduleId WHERE Date>=@0 AND Date<DATEADD(MONTH,1,@0)", dateFrom)) {
					row["FlightsAmount"] = (int)r["FlightsAmount"];
					row["TicketsAmount"] = (int)r["TicketsAmount"];
					row["TicketsRevenue"] = (float)Math.Round((decimal)r["TicketsRevenue"], 2);
				}
				
				table.Rows.Add(row);
			}

			dataGridView.DataSource = table;

			RefreshChart();
		}

		void RefreshChart() {
			series.Points.Clear();
			foreach (DataRow row in table.Rows) {
				double value = 0;
				switch (comboViewBy.SelectedIndex) {
					case 0:
						value = (int)row["FlightsAmount"];
						break;
					case 1:
						value = (int)row["TicketsAmount"];
						break;
					case 2:
						value = (float)row["TicketsRevenue"];
						break;
				}

				series.Points.AddXY((int)row["MonthValue"], value);
			}
		}
		private void comboViewBy_SelectedIndexChanged(object sender, EventArgs e) {
			RefreshChart();
		}

		private void checkAmount_CheckedChanged(object sender, EventArgs e) {
			series.IsValueShownAsLabel = checkAmount.Checked;
		}
	}
}
