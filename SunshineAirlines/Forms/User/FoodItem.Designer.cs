namespace SunshineAirlines.Forms.User {
	partial class FoodItem {
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.lblName = new System.Windows.Forms.Label();
			this.checkBox = new System.Windows.Forms.CheckBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.numberBox = new System.Windows.Forms.NumericUpDown();
			this.lblPrice = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numberBox)).BeginInit();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblName.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(3, 1);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(302, 50);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Food Name Here\r\nLine 2 FOOD FOOD FOOD";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox
			// 
			this.checkBox.AutoSize = true;
			this.checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox.Location = new System.Drawing.Point(20, 95);
			this.checkBox.Name = "checkBox";
			this.checkBox.Size = new System.Drawing.Size(15, 14);
			this.checkBox.TabIndex = 1;
			this.checkBox.UseVisualStyleBackColor = true;
			this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// pictureBox
			// 
			this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox.Location = new System.Drawing.Point(72, 53);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(163, 94);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			// 
			// numberBox
			// 
			this.numberBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.numberBox.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numberBox.Location = new System.Drawing.Point(241, 77);
			this.numberBox.Name = "numberBox";
			this.numberBox.Size = new System.Drawing.Size(64, 32);
			this.numberBox.TabIndex = 3;
			this.numberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numberBox.ValueChanged += new System.EventHandler(this.numberBox_ValueChanged);
			// 
			// lblPrice
			// 
			this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPrice.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrice.Location = new System.Drawing.Point(3, 150);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(302, 29);
			this.lblPrice.TabIndex = 4;
			this.lblPrice.Text = "$ 60.00";
			this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FoodItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.numberBox);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.checkBox);
			this.Controls.Add(this.lblName);
			this.Name = "FoodItem";
			this.Size = new System.Drawing.Size(308, 178);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numberBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label lblName;
		public System.Windows.Forms.CheckBox checkBox;
		public System.Windows.Forms.PictureBox pictureBox;
		public System.Windows.Forms.NumericUpDown numberBox;
		public System.Windows.Forms.Label lblPrice;
	}
}
