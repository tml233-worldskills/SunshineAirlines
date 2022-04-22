namespace SunshineAirlines.Forms.User {
	partial class SearchFlights {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.inputOneWay = new System.Windows.Forms.RadioButton();
			this.inputRoundWays = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.inputDateDeparture = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.inputCityTo = new System.Windows.Forms.ComboBox();
			this.inputCityFrom = new System.Windows.Forms.ComboBox();
			this.panelReturnDate = new System.Windows.Forms.Panel();
			this.lblTitleReturnDate = new System.Windows.Forms.Label();
			this.inputDateReturn = new System.Windows.Forms.DateTimePicker();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.inputCabinType = new System.Windows.Forms.ComboBox();
			this.inputFlightType = new System.Windows.Forms.ComboBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panelDeparture = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panelReturnDate.SuspendLayout();
			this.panel4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("TeXGyreAdventor", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1160, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Search Flights";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.flowLayoutPanel1);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Location = new System.Drawing.Point(12, 52);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1160, 74);
			this.panel1.TabIndex = 2;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panelReturnDate);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1016, 73);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.inputOneWay);
			this.panel2.Controls.Add(this.inputRoundWays);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.inputDateDeparture);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.inputCityTo);
			this.panel2.Controls.Add(this.inputCityFrom);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(543, 73);
			this.panel2.TabIndex = 4;
			// 
			// inputOneWay
			// 
			this.inputOneWay.AutoSize = true;
			this.inputOneWay.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputOneWay.Location = new System.Drawing.Point(3, 3);
			this.inputOneWay.Name = "inputOneWay";
			this.inputOneWay.Size = new System.Drawing.Size(101, 28);
			this.inputOneWay.TabIndex = 0;
			this.inputOneWay.TabStop = true;
			this.inputOneWay.Text = "One Way";
			this.inputOneWay.UseVisualStyleBackColor = true;
			this.inputOneWay.CheckedChanged += new System.EventHandler(this.inputOneWay_CheckedChanged);
			// 
			// inputRoundWays
			// 
			this.inputRoundWays.AutoSize = true;
			this.inputRoundWays.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputRoundWays.Location = new System.Drawing.Point(3, 37);
			this.inputRoundWays.Name = "inputRoundWays";
			this.inputRoundWays.Size = new System.Drawing.Size(124, 28);
			this.inputRoundWays.TabIndex = 1;
			this.inputRoundWays.TabStop = true;
			this.inputRoundWays.Text = "Round Ways";
			this.inputRoundWays.UseVisualStyleBackColor = true;
			this.inputRoundWays.CheckedChanged += new System.EventHandler(this.inputRoundWays_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(147, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "From City:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(274, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "To City:";
			// 
			// inputDateDeparture
			// 
			this.inputDateDeparture.CustomFormat = "yyyy-MM-dd";
			this.inputDateDeparture.Font = new System.Drawing.Font("TeXGyreAdventor", 10F);
			this.inputDateDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputDateDeparture.Location = new System.Drawing.Point(405, 34);
			this.inputDateDeparture.Name = "inputDateDeparture";
			this.inputDateDeparture.Size = new System.Drawing.Size(135, 27);
			this.inputDateDeparture.TabIndex = 10;
			this.inputDateDeparture.ValueChanged += new System.EventHandler(this.inputDateDeparture_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(401, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 24);
			this.label4.TabIndex = 4;
			this.label4.Text = "Departure Date:";
			// 
			// inputCityTo
			// 
			this.inputCityTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputCityTo.Font = new System.Drawing.Font("TeXGyreAdventor", 10F);
			this.inputCityTo.FormattingEnabled = true;
			this.inputCityTo.Location = new System.Drawing.Point(278, 35);
			this.inputCityTo.Name = "inputCityTo";
			this.inputCityTo.Size = new System.Drawing.Size(121, 27);
			this.inputCityTo.TabIndex = 9;
			// 
			// inputCityFrom
			// 
			this.inputCityFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputCityFrom.Font = new System.Drawing.Font("TeXGyreAdventor", 10F);
			this.inputCityFrom.FormattingEnabled = true;
			this.inputCityFrom.Location = new System.Drawing.Point(151, 34);
			this.inputCityFrom.Name = "inputCityFrom";
			this.inputCityFrom.Size = new System.Drawing.Size(121, 27);
			this.inputCityFrom.TabIndex = 8;
			// 
			// panelReturnDate
			// 
			this.panelReturnDate.Controls.Add(this.lblTitleReturnDate);
			this.panelReturnDate.Controls.Add(this.inputDateReturn);
			this.panelReturnDate.Location = new System.Drawing.Point(552, 3);
			this.panelReturnDate.Name = "panelReturnDate";
			this.panelReturnDate.Size = new System.Drawing.Size(147, 73);
			this.panelReturnDate.TabIndex = 4;
			// 
			// lblTitleReturnDate
			// 
			this.lblTitleReturnDate.AutoSize = true;
			this.lblTitleReturnDate.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleReturnDate.Location = new System.Drawing.Point(3, 4);
			this.lblTitleReturnDate.Name = "lblTitleReturnDate";
			this.lblTitleReturnDate.Size = new System.Drawing.Size(106, 24);
			this.lblTitleReturnDate.TabIndex = 5;
			this.lblTitleReturnDate.Text = "Return Date:";
			// 
			// inputDateReturn
			// 
			this.inputDateReturn.CustomFormat = "yyyy-MM-dd";
			this.inputDateReturn.Font = new System.Drawing.Font("TeXGyreAdventor", 10F);
			this.inputDateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputDateReturn.Location = new System.Drawing.Point(7, 34);
			this.inputDateReturn.Name = "inputDateReturn";
			this.inputDateReturn.Size = new System.Drawing.Size(135, 27);
			this.inputDateReturn.TabIndex = 11;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.inputCabinType);
			this.panel4.Controls.Add(this.inputFlightType);
			this.panel4.Location = new System.Drawing.Point(705, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(250, 73);
			this.panel4.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 24);
			this.label6.TabIndex = 6;
			this.label6.Text = "Cabin Type:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(122, 4);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 24);
			this.label7.TabIndex = 7;
			this.label7.Text = "Flight Type:";
			// 
			// inputCabinType
			// 
			this.inputCabinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputCabinType.Font = new System.Drawing.Font("TeXGyreAdventor", 10F);
			this.inputCabinType.FormattingEnabled = true;
			this.inputCabinType.Location = new System.Drawing.Point(7, 34);
			this.inputCabinType.Name = "inputCabinType";
			this.inputCabinType.Size = new System.Drawing.Size(113, 27);
			this.inputCabinType.TabIndex = 12;
			// 
			// inputFlightType
			// 
			this.inputFlightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputFlightType.Font = new System.Drawing.Font("TeXGyreAdventor", 10F);
			this.inputFlightType.FormattingEnabled = true;
			this.inputFlightType.Items.AddRange(new object[] {
            "All",
            "Non-stop",
            "Stop"});
			this.inputFlightType.Location = new System.Drawing.Point(126, 34);
			this.inputFlightType.Name = "inputFlightType";
			this.inputFlightType.Size = new System.Drawing.Size(113, 27);
			this.inputFlightType.TabIndex = 13;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(1018, 7);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(137, 57);
			this.btnSearch.TabIndex = 11;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.panelDeparture);
			this.groupBox1.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 133);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1160, 244);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Departure Flights";
			// 
			// panelDeparture
			// 
			this.panelDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDeparture.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.panelDeparture.Location = new System.Drawing.Point(3, 27);
			this.panelDeparture.Name = "panelDeparture";
			this.panelDeparture.Size = new System.Drawing.Size(1154, 214);
			this.panelDeparture.TabIndex = 0;
			// 
			// SearchFlights
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 556);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "SearchFlights";
			this.Text = "Search Flights";
			this.Load += new System.EventHandler(this.SearchFlights_Load);
			this.panel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panelReturnDate.ResumeLayout(false);
			this.panelReturnDate.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox inputCityFrom;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblTitleReturnDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton inputRoundWays;
		private System.Windows.Forms.RadioButton inputOneWay;
		private System.Windows.Forms.DateTimePicker inputDateDeparture;
		private System.Windows.Forms.ComboBox inputCityTo;
		private System.Windows.Forms.ComboBox inputFlightType;
		private System.Windows.Forms.ComboBox inputCabinType;
		private System.Windows.Forms.DateTimePicker inputDateReturn;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.FlowLayoutPanel panelDeparture;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panelReturnDate;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}