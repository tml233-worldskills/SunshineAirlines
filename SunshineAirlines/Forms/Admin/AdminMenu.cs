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
	public partial class AdminMenu : Form {
		int uid;
		public AdminMenu(int uid) {
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

		private void userManagementToolStripMenuItem_Click(object sender, EventArgs e) {
			var form = new UserManagement {
				MdiParent = this
			};
			form.Show();
		}

		private void flightScheduleManagementToolStripMenuItem_Click(object sender, EventArgs e) {
			var form = new FlightScheduleManagement {
				MdiParent = this
			};
			form.Show();
		}

		private void ticketStatisticsToolStripMenuItem_Click(object sender, EventArgs e) {
			var form = new TicketStatistics {
				MdiParent = this
			};
			form.Show();
		}
	}
}
