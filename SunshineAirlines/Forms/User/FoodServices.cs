using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines.Forms.User {
	public partial class FoodServices : Form {
		int uid;
		public FoodServices(int uid) {
			InitializeComponent();
			this.uid = uid;
		}

		private void FoodServices_Load(object sender, EventArgs e) {
			foreach(var r in Utils.ExecuteReader("SELECT FoodId,[Name],Price,Img FROM FlightFood")) {
				var form = new FoodItem();
				var data = new FoodData {
					parent = this,
					name = r["Name"] as string,
					price = Convert.ToSingle(r["Price"]),
					image = Image.FromFile(Utils.ResourceRoot + "Food/" + (r["Img"] as string))
				};
				form.Init(data);
				panelFood.Controls.Add(form);
				foodData.Add((int)r["FoodId"], data);
			}
			ClearFoodData();
		}
		void ClearFoodData() {
			foreach(var data in foodData.Values) {
				data.count = 0;
				data.originalCount = 0;
				data.form.UpdateDisplay();
			}
			UpdatePrice();
		}
		public void UpdatePrice() {
			int itemCount = 0;
			int amount = 0;
			float payment = 0;
			foreach(var data in foodData.Values) {
				if (data.count > 0) {
					itemCount += 1;
					amount += data.count;
				}
				payment += (data.count - data.originalCount) * data.price;
			}
			lblInfo.Text = string.Format("Selected Items: {0}\nSelect Amount:{1}\n{2}: ${3:F2}", itemCount, amount, payment >= 0 ? "Payment" : "Refund", Math.Abs(payment));
		}

		private void button2_Click(object sender, EventArgs e) {
			Close();
		}

		List<int> rIds = new List<int>();
		int? currentRId = null;
		Dictionary<int, FoodData> foodData = new Dictionary<int, FoodData>();

		private void btnSearch_Click(object sender, EventArgs e) {
			if (comboIdType.SelectedIndex < 0) {
				MessageBox.Show("Please select a ID Type!");
				return;
			}
			string idType = comboIdType.Text;
			string idTypeNumber = inputIDTypeNumber.Text.Trim();
			if (idTypeNumber.Length <= 0) {
				MessageBox.Show("Please input ID Type Number!");
				return;
			}

			rIds.Clear();
			comboFlight.SelectedIndex = -1;
			comboFlight.Items.Clear();
			foreach (var r in Utils.ExecuteReader("SELECT ReservationId, FlightNumber, DepartureAirportIATA, ArrivalAirportIATA, CAST(Date AS DATETIME)+CAST(Time AS DATETIME) AS DateTime, CabinTypeName FROM FlightReservation,Schedule,Route,CabinType WHERE FlightReservation.ScheduleId=Schedule.ScheduleId AND Schedule.RouteId=Route.RouteId AND FlightReservation.CabinTypeId=CabinType.CabinTypeId AND IDType=@0 AND IDTypeNumber=@1 ORDER BY DateTime", idType, idTypeNumber)) {
				rIds.Add((int)r["ReservationId"]);
				comboFlight.Items.Add(string.Format("{0},{1}-{2},{3},{4},{5}", r["FlightNumber"], r["DepartureAirportIATA"], r["ArrivalAirportIATA"], ((DateTime)r["DateTime"]).ToString("yyyy-MM-dd"), ((DateTime)r["DateTime"]).ToString("HH:mm"), r["CabinTypeName"]));
			}
			if (rIds.Count == 0) {
				MessageBox.Show("No reservation found!");
				return;
			}
			//MessageBox.Show(string.Format("Found {0} reservation(s).", rIds.Count));
			comboFlight.SelectedIndex = 0;
		}

		private void btnLoad_Click(object sender, EventArgs e) {
			if (comboFlight.SelectedIndex < 0) {
				MessageBox.Show("Please select a Flight!");
				return;
			}
			currentRId = rIds[comboFlight.SelectedIndex];
			ClearFoodData();
			foreach (var r in Utils.ExecuteReader("SELECT FoodId,Amount FROM FlightFoodReservation WHERE ReservationId=@0", currentRId.Value)) {
				var data = foodData[(int)r["FoodId"]];
				data.count = (int)r["Amount"];
				data.originalCount = data.count;
				data.form.UpdateDisplay();
			}
			UpdatePrice();
		}

		private void button1_Click(object sender, EventArgs e) {
			if (currentRId == null) {
				MessageBox.Show("No reservation loaded.");
				return;
			}
			Utils.ExecuteUpdate("DELETE FROM FlightFoodReservation WHERE ReservationId=@0", currentRId.Value);
			foreach (var pair in foodData) {
				var fid = pair.Key;
				var data = pair.Value;
				if (data.count > 0) {
					Utils.ExecuteUpdate("INSERT INTO FlightFoodReservation(ReservationId,FoodId,Amount) VALUES(@0,@1,@2)", currentRId.Value, fid, data.count);
				}
			}
			MessageBox.Show("Update complete.");
		}
	}
	public class FoodData {
		public FoodServices parent;
		public FoodItem form;
		public string name;
		public float price;
		public int originalCount;
		public int count;
		public Image image;
	}
}
