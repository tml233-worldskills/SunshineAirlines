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
	public partial class FoodItem : UserControl {
		public FoodItem() {
			InitializeComponent();
		}

		FoodData foodData;

		private void checkBox_CheckedChanged(object sender, EventArgs e) {
			UpdateDataCount();
		}
		private void numberBox_ValueChanged(object sender, EventArgs e) {
			UpdateDataCount();
		}
		void UpdateDataCount() {
			if (checkBox.Checked) {
				foodData.count = (int)numberBox.Value;
			} else {
				foodData.count = 0;
			}
			UpdatePrice();
			foodData.parent.UpdatePrice();
		}
		void UpdatePrice() {
			var price = foodData.price * (foodData.count - foodData.originalCount);
			lblPrice.Text = string.Format("{0}${1:F2}", price < 0 ? "-" : string.Empty, Math.Abs(price));
		}
		public void Init(FoodData foodData) {
			foodData.form = this;
			this.foodData = foodData;
		}
		public void UpdateDisplay() {
			int count = foodData.count;
			checkBox.Checked = count > 0;
			numberBox.Value = count;
			foodData.count = count;

			lblName.Text = foodData.name;
			pictureBox.Image = foodData.image;
			UpdatePrice();
		}
	}
}
