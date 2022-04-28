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
	public partial class FlightItem : UserControl {
		public FlightItem(FlowLayoutPanel parentPanel) {
			this.parentPanel = parentPanel;
			InitializeComponent();
		}

		FlowLayoutPanel parentPanel;

		private void FlightItem_Load(object sender, EventArgs e) {

		}

		private void radioButton_CheckedChanged(object sender, EventArgs e) {
			if (!radioButton.Checked) {
				return;
			}
			foreach (var form in parentPanel.Controls) {
				var fi = form as FlightItem;
				if (fi == this) {
					continue;
				}
				fi.radioButton.Checked = false;
			}
		}
	}
}
