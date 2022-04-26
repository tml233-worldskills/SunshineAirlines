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
	public partial class SeatItem4 : UserControl, ISeatItem {
		int col;
		public SeatItem4(int col) {
			this.col = col;
			InitializeComponent();
		}

		public Label GetA() => lblA;
		public Label GetB() => null;
		public Label GetC() => lblC;
		public Label GetJ() => lblJ;
		public Label GetK() => null;
		public Label GetL() => lblL;

		private void SeatItem4_Load(object sender, EventArgs e) {
			lblA.Text = col + "A";
			lblC.Text = col + "C";
			lblJ.Text = col + "J";
			lblL.Text = col + "L";
		}
	}
}
