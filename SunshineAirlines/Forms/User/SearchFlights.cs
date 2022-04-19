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
	public partial class SearchFlights : Form {
		int uid;
		public SearchFlights(int uid) {
			this.uid = uid;
			InitializeComponent();
		}

		bool roundWays = false;
		List<(string, string)> cities = new List<(string, string)>();
		List<(int, string)> cabinTypes = new List<(int, string)>();
		private void SearchFlights_Load(object sender, EventArgs e) {
			foreach(var r in Utils.ExecuteReader("SELECT CityCode, CityName FROM City ORDER BY CityName")) {
				var code = r["CityCode"] as string;
				var name = r["CityName"] as string;
				cities.Add((code, name));
				inputCityFrom.Items.Add(name);
				inputCityTo.Items.Add(name);
			}
			foreach(var r in Utils.ExecuteReader("SELECT CabinTypeId,CabinTypeName FROM CabinType")) {
				var id = (int)r["CabinTypeId"];
				var name = r["CabinTypeName"] as string;
				cabinTypes.Add((id, name));
				inputCabinType.Items.Add(name);
			}

			inputDateDeparture.MinDate = DateTime.Now;
			UpdateReturnDate();

			inputOneWay.Checked = true;
		}
		void UpdateRoundWays() {
			panelReturnDate.Visible = roundWays;
		}
		void UpdateReturnDate() {
			inputDateReturn.MinDate = inputDateDeparture.Value;
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
	}
}
