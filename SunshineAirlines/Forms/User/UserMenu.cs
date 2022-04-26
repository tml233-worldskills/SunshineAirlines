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
	public partial class UserMenu : Form {
		int uid;
		public UserMenu(int uid) {
			this.uid = uid;
			InitializeComponent();
		}

		private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			if (MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes) {
				Login.Quitting = true;
				Close();
			}
		}

		private void searchFlightsToolStripMenuItem_Click(object sender, EventArgs e) {
			var form = new SearchFlights(uid) {
				MdiParent = this
			};
			form.Show();
		}

		private void foodServicesToolStripMenuItem_Click(object sender, EventArgs e) {
			var form = new FoodServices(uid) {
				MdiParent = this
			};
			form.Show();
		}

		private void flightStatusToolStripMenuItem_Click(object sender, EventArgs e) {
			var form = new FlightStatus() {
				MdiParent = this
			};
			form.Show();
		}
	}
}
