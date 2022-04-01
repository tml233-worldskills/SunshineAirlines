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
	}
}
