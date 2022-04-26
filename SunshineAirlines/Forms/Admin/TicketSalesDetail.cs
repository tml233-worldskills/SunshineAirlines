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

namespace SunshineAirlines.Forms.Admin {
	public partial class TicketSalesDetail : Form {
		int scheduleId;
		public TicketSalesDetail(int scheduleId) {
			this.scheduleId = scheduleId;
			InitializeComponent();
		}

		Dictionary<int, ISeatItem> seatItems = new Dictionary<int, ISeatItem>();
		Dictionary<int, FlowLayoutPanel> cabinPanels = new Dictionary<int, FlowLayoutPanel>();
		Dictionary<int, Label> cabinLabels = new Dictionary<int, Label>();
		Dictionary<int, string> cabinNames = new Dictionary<int, string>() {
			{1,"Economy" },
			{2,"Business" },
			{3,"First" }
		};
		List<int> cabinIds = new List<int>() {
			3,2,1
		};

		private void UserManagement_Load(object sender, EventArgs e) {
			cabinPanels[1] = panelEconomy;
			cabinPanels[2] = panelBusiness;
			cabinPanels[3] = panelFirst;
			cabinLabels[1] = lblEconomy;
			cabinLabels[2] = lblBusiness;
			cabinLabels[3] = lblFirst;

			var table = Utils.ExecuteTable(@"SELECT DepartureAirportIATA+' to '+ArrivalAirportIATA+', '+FORMAT(Date,'yyyy-MM-dd')+', '+FORMAT(Time,'hh\:mm')+', '+Name as Text,Aircraft.AircraftId as AircraftId, FirstSeatsAmount,FirstSeatsLayout,BusinessSeatsAmount,BusinessSeatsLayout,EconomySeatsAmount,EconomySeatsLayout FROM Schedule,Route,Aircraft WHERE Schedule.RouteId=Route.RouteId AND Schedule.AircraftId=Aircraft.AircraftId AND Schedule.ScheduleId=@0", scheduleId);
			if (table.Rows.Count <= 0) {
				MessageBox.Show("Schedule not found!");
				return;
			}
			var row = table.Rows[0];
			lblInfo.Text = row["Text"].ToString();

			using (var file = File.OpenRead(Utils.ResourceRoot + string.Format("Aircraft/{0}.jpg", row["AircraftId"]))) {
				var buf = new MemoryStream();
				file.CopyTo(buf);
				pictureBox1.Image = Image.FromStream(buf);
			}

			int colIndex = 1;
			foreach (var cabinId in cabinIds) {
				var cabinName = cabinNames[cabinId];

				int total = (int)row[cabinName + "SeatsAmount"];

				var layout = row[cabinName + "SeatsLayout"] as string;
				var split = layout.Split('*');
				var cols = int.Parse(split[0]);
				var type = int.Parse(split[1]);

				var panel = cabinPanels[cabinId];
				panel.SuspendLayout();
				for (int i = 0; i < cols; i += 1) {
					UserControl seat;
					if (type == 4) {
						seat = new SeatItem4(colIndex);
					} else {
						seat = new SeatItem6(colIndex);
					}
					panel.Controls.Add(seat);
					seatItems[colIndex] = seat as ISeatItem;
					colIndex += 1;
				}
				panel.ResumeLayout();

				int sold = 0;
				int seated = 0;
				foreach(var r in Utils.ExecuteReader(@"SELECT SeatLayoutId,RowNumber,ColumnName FROM FlightReservation LEFT JOIN SeatLayout ON FlightReservation.SeatLayoutId=SeatLayout.Id WHERE ScheduleId=@0 AND FlightReservation.CabinTypeId=@1", scheduleId, cabinId)) {
					sold += 1;
					if (r["SeatLayoutId"] == DBNull.Value) {
						continue;
					}
					seated += 1;
					int rowNumber = (int)r["RowNumber"];
					string colName = r["ColumnName"].ToString();
					ISeatItem seatItem = null;
					if(!seatItems.TryGetValue(rowNumber,out seatItem)) {
						continue;
					}
					Label lbl = null;
					switch (colName) {
						case "A":
							lbl = seatItem.GetA();
							break;
						case "B":
							lbl = seatItem.GetB();
							break;
						case "C":
							lbl = seatItem.GetC();
							break;
						case "J":
							lbl = seatItem.GetJ();
							break;
						case "K":
							lbl = seatItem.GetK();
							break;
						case "L":
							lbl = seatItem.GetL();
							break;
					}
					if (lbl == null) {
						continue;
					}
					lbl.BackColor = Color.FromArgb(252, 149, 0);
				}
				cabinLabels[cabinId].Text = String.Format("{0}/{1} {2}%\nTotal Tickets: {1}\nSold Tickets: {0}\nSeats Selected: {3}", sold, total, Math.Round((float)sold / (float)total * 100, 2), seated);
			}
		}
	}
}
