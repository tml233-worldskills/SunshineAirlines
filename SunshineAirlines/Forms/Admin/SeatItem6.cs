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
	public partial class SeatItem6 : UserControl, ISeatItem {
		int col;
		public SeatItem6(int col) {
			this.col = col;
			InitializeComponent();
		}

		public Label GetA() => lblA;
		public Label GetB() => lblB;
		public Label GetC() => lblC;
		public Label GetJ() => lblJ;
		public Label GetK() => lblK;
		public Label GetL() => lblL;

		private void SeatItem6_Load(object sender, EventArgs e) {
			lblA.Text = col + "A";
			lblB.Text = col + "B";
			lblC.Text = col + "C";
			lblJ.Text = col + "J";
			lblK.Text = col + "K";
			lblL.Text = col + "L";
		}
	}
}
