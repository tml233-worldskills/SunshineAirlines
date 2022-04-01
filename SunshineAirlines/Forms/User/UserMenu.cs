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
			Login.Quitting = true;
			Close();
		}
	}
}
