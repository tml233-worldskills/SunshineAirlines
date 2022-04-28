namespace SunshineAirlines.Forms.User {
	partial class FlightItem {
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblFlights = new System.Windows.Forms.Label();
			this.lblCabinType = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblFromTime = new System.Windows.Forms.Label();
			this.lblFromPlace = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblTickets = new System.Windows.Forms.Label();
			this.lblTotalTime = new System.Windows.Forms.Label();
			this.lblStop = new System.Windows.Forms.Label();
			this.radioButton = new System.Windows.Forms.RadioButton();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblTransfer = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblToTime = new System.Windows.Forms.Label();
			this.lblToPlace = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lblFlights);
			this.panel1.Controls.Add(this.lblCabinType);
			this.panel1.Controls.Add(this.lblPrice);
			this.panel1.Location = new System.Drawing.Point(97, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(152, 189);
			this.panel1.TabIndex = 1;
			// 
			// lblFlights
			// 
			this.lblFlights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFlights.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFlights.Location = new System.Drawing.Point(3, 46);
			this.lblFlights.Name = "lblFlights";
			this.lblFlights.Size = new System.Drawing.Size(144, 141);
			this.lblFlights.TabIndex = 2;
			this.lblFlights.Text = "Flight 000";
			// 
			// lblCabinType
			// 
			this.lblCabinType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCabinType.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCabinType.Location = new System.Drawing.Point(3, 23);
			this.lblCabinType.Name = "lblCabinType";
			this.lblCabinType.Size = new System.Drawing.Size(144, 23);
			this.lblCabinType.TabIndex = 1;
			this.lblCabinType.Text = "Economy";
			this.lblCabinType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPrice
			// 
			this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPrice.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrice.Location = new System.Drawing.Point(3, 0);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(144, 23);
			this.lblPrice.TabIndex = 0;
			this.lblPrice.Text = "$0.00";
			this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.lblFromTime);
			this.panel2.Controls.Add(this.lblFromPlace);
			this.panel2.Location = new System.Drawing.Point(255, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(413, 68);
			this.panel2.TabIndex = 2;
			// 
			// lblFromTime
			// 
			this.lblFromTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFromTime.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFromTime.Location = new System.Drawing.Point(188, 0);
			this.lblFromTime.Name = "lblFromTime";
			this.lblFromTime.Size = new System.Drawing.Size(220, 66);
			this.lblFromTime.TabIndex = 1;
			this.lblFromTime.Text = "2018-06-25  12:12:12\r\n2018-06-25  12:12:12";
			this.lblFromTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFromPlace
			// 
			this.lblFromPlace.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFromPlace.Location = new System.Drawing.Point(3, 0);
			this.lblFromPlace.Name = "lblFromPlace";
			this.lblFromPlace.Size = new System.Drawing.Size(179, 66);
			this.lblFromPlace.TabIndex = 0;
			this.lblFromPlace.Text = "Hong Kong/HKG\r\nHong Kong/HKG";
			this.lblFromPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.lblTickets);
			this.panel4.Controls.Add(this.lblTotalTime);
			this.panel4.Controls.Add(this.lblStop);
			this.panel4.Location = new System.Drawing.Point(674, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(196, 189);
			this.panel4.TabIndex = 3;
			// 
			// lblTickets
			// 
			this.lblTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTickets.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTickets.Location = new System.Drawing.Point(3, 164);
			this.lblTickets.Name = "lblTickets";
			this.lblTickets.Size = new System.Drawing.Size(188, 23);
			this.lblTickets.TabIndex = 2;
			this.lblTickets.Text = "114 available tickets";
			this.lblTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTotalTime
			// 
			this.lblTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotalTime.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalTime.Location = new System.Drawing.Point(3, 58);
			this.lblTotalTime.Name = "lblTotalTime";
			this.lblTotalTime.Size = new System.Drawing.Size(188, 73);
			this.lblTotalTime.TabIndex = 1;
			this.lblTotalTime.Text = "Total Time: 16h 50m";
			this.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblStop
			// 
			this.lblStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblStop.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStop.Location = new System.Drawing.Point(3, 0);
			this.lblStop.Name = "lblStop";
			this.lblStop.Size = new System.Drawing.Size(188, 23);
			this.lblStop.TabIndex = 0;
			this.lblStop.Text = "Non-Stop";
			this.lblStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// radioButton
			// 
			this.radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.radioButton.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton.Location = new System.Drawing.Point(10, 4);
			this.radioButton.Name = "radioButton";
			this.radioButton.Size = new System.Drawing.Size(81, 187);
			this.radioButton.TabIndex = 4;
			this.radioButton.TabStop = true;
			this.radioButton.Text = "Select";
			this.radioButton.UseVisualStyleBackColor = true;
			this.radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.lblTransfer);
			this.panel5.Location = new System.Drawing.Point(255, 77);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(413, 41);
			this.panel5.TabIndex = 4;
			// 
			// lblTransfer
			// 
			this.lblTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTransfer.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTransfer.Location = new System.Drawing.Point(3, 0);
			this.lblTransfer.Name = "lblTransfer";
			this.lblTransfer.Size = new System.Drawing.Size(405, 39);
			this.lblTransfer.TabIndex = 0;
			this.lblTransfer.Text = "2h 30m Transfer in Hong Kong/HKG";
			this.lblTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.lblToTime);
			this.panel3.Controls.Add(this.lblToPlace);
			this.panel3.Location = new System.Drawing.Point(255, 124);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(413, 68);
			this.panel3.TabIndex = 3;
			// 
			// lblToTime
			// 
			this.lblToTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblToTime.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblToTime.Location = new System.Drawing.Point(188, 0);
			this.lblToTime.Name = "lblToTime";
			this.lblToTime.Size = new System.Drawing.Size(220, 66);
			this.lblToTime.TabIndex = 1;
			this.lblToTime.Text = "2018-06-25  12:12:12\r\n2018-06-25  12:12:12";
			this.lblToTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblToPlace
			// 
			this.lblToPlace.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblToPlace.Location = new System.Drawing.Point(3, 0);
			this.lblToPlace.Name = "lblToPlace";
			this.lblToPlace.Size = new System.Drawing.Size(179, 66);
			this.lblToPlace.TabIndex = 0;
			this.lblToPlace.Text = "Hong Kong/HKG\r\nHong Kong/HKG";
			this.lblToPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FlightItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.radioButton);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FlightItem";
			this.Size = new System.Drawing.Size(874, 195);
			this.Load += new System.EventHandler(this.FlightItem_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		public System.Windows.Forms.Label lblFlights;
		public System.Windows.Forms.Label lblCabinType;
		public System.Windows.Forms.Label lblPrice;
		public System.Windows.Forms.Label lblTickets;
		public System.Windows.Forms.Label lblTotalTime;
		public System.Windows.Forms.Label lblStop;
		public System.Windows.Forms.RadioButton radioButton;
		public System.Windows.Forms.Label lblTransfer;
		public System.Windows.Forms.Label lblFromTime;
		public System.Windows.Forms.Label lblFromPlace;
		private System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.Label lblToTime;
		public System.Windows.Forms.Label lblToPlace;
	}
}
