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
	public partial class FlightStatus : Form {
		public FlightStatus() {
			InitializeComponent();
		}

		private void FlightStatus_Load(object sender, EventArgs e) {

			this.reportViewer.RefreshReport();
		}
	}
}
