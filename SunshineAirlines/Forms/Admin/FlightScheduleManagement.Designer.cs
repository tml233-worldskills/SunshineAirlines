namespace SunshineAirlines.Forms.Admin {
	partial class FlightScheduleManagement {
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
			this.btnExchange = new System.Windows.Forms.PictureBox();
			this.comboTo = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.radioCity = new System.Windows.Forms.RadioButton();
			this.radioAirport = new System.Windows.Forms.RadioButton();
			this.btnSearch = new System.Windows.Forms.Button();
			this.comboFrom = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.btnEdit = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.inputDateFrom = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.inputDateTo = new System.Windows.Forms.DateTimePicker();
			this.ColumnScheduleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAircraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnEconomyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnFlightNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnGate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDetail = new System.Windows.Forms.DataGridViewLinkColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnExchange)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("TeXGyreAdventor", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1028, 40);
			this.label1.TabIndex = 3;
			this.label1.Text = "Flight Schedule Management";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.inputDateTo);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.inputDateFrom);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.btnExchange);
			this.panel1.Controls.Add(this.comboTo);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.radioCity);
			this.panel1.Controls.Add(this.radioAirport);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.comboFrom);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 52);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1028, 68);
			this.panel1.TabIndex = 4;
			// 
			// btnExchange
			// 
			this.btnExchange.Image = global::SunshineAirlines.Properties.Resources.exchange;
			this.btnExchange.Location = new System.Drawing.Point(274, 6);
			this.btnExchange.Name = "btnExchange";
			this.btnExchange.Size = new System.Drawing.Size(41, 52);
			this.btnExchange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnExchange.TabIndex = 10;
			this.btnExchange.TabStop = false;
			this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
			// 
			// comboTo
			// 
			this.comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboTo.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboTo.FormattingEnabled = true;
			this.comboTo.Location = new System.Drawing.Point(321, 34);
			this.comboTo.Name = "comboTo";
			this.comboTo.Size = new System.Drawing.Size(139, 27);
			this.comboTo.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(322, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "To:";
			// 
			// radioCity
			// 
			this.radioCity.AutoSize = true;
			this.radioCity.Font = new System.Drawing.Font("TeXGyreAdventor", 12F);
			this.radioCity.Location = new System.Drawing.Point(5, 35);
			this.radioCity.Name = "radioCity";
			this.radioCity.Size = new System.Drawing.Size(80, 28);
			this.radioCity.TabIndex = 7;
			this.radioCity.TabStop = true;
			this.radioCity.Text = "By City";
			this.radioCity.UseVisualStyleBackColor = true;
			this.radioCity.CheckedChanged += new System.EventHandler(this.radioCity_CheckedChanged);
			// 
			// radioAirport
			// 
			this.radioAirport.AutoSize = true;
			this.radioAirport.Font = new System.Drawing.Font("TeXGyreAdventor", 12F);
			this.radioAirport.Location = new System.Drawing.Point(5, 6);
			this.radioAirport.Name = "radioAirport";
			this.radioAirport.Size = new System.Drawing.Size(101, 28);
			this.radioAirport.TabIndex = 6;
			this.radioAirport.TabStop = true;
			this.radioAirport.Text = "By Airport";
			this.radioAirport.UseVisualStyleBackColor = true;
			this.radioAirport.CheckedChanged += new System.EventHandler(this.radioAirport_CheckedChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F);
			this.btnSearch.Location = new System.Drawing.Point(806, 34);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 27);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// comboFrom
			// 
			this.comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFrom.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboFrom.FormattingEnabled = true;
			this.comboFrom.Location = new System.Drawing.Point(128, 34);
			this.comboFrom.Name = "comboFrom";
			this.comboFrom.Size = new System.Drawing.Size(139, 27);
			this.comboFrom.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(129, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "From:";
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnScheduleId,
            this.ColumnDate,
            this.ColumnTime,
            this.ColumnFrom,
            this.ColumnTo,
            this.ColumnAircraft,
            this.ColumnEconomyPrice,
            this.ColumnFlightNumber,
            this.ColumnGate,
            this.ColumnStatus,
            this.ColumnDetail});
			this.dataGridView.Location = new System.Drawing.Point(13, 127);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowTemplate.Height = 23;
			this.dataGridView.Size = new System.Drawing.Size(1027, 406);
			this.dataGridView.TabIndex = 5;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(879, 538);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(161, 32);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "Cancel/Confirm";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(484, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 24);
			this.label4.TabIndex = 11;
			this.label4.Text = "Departure Date:";
			// 
			// inputDateFrom
			// 
			this.inputDateFrom.CustomFormat = "yyyy-MM-dd";
			this.inputDateFrom.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F);
			this.inputDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputDateFrom.Location = new System.Drawing.Point(482, 35);
			this.inputDateFrom.Name = "inputDateFrom";
			this.inputDateFrom.Size = new System.Drawing.Size(140, 26);
			this.inputDateFrom.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(628, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 24);
			this.label5.TabIndex = 14;
			this.label5.Text = "To";
			// 
			// inputDateTo
			// 
			this.inputDateTo.CustomFormat = "yyyy-MM-dd";
			this.inputDateTo.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F);
			this.inputDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputDateTo.Location = new System.Drawing.Point(660, 35);
			this.inputDateTo.Name = "inputDateTo";
			this.inputDateTo.Size = new System.Drawing.Size(140, 26);
			this.inputDateTo.TabIndex = 15;
			// 
			// ColumnScheduleId
			// 
			this.ColumnScheduleId.DataPropertyName = "ScheduleId";
			this.ColumnScheduleId.HeaderText = "ScheduleId";
			this.ColumnScheduleId.Name = "ColumnScheduleId";
			this.ColumnScheduleId.ReadOnly = true;
			this.ColumnScheduleId.Visible = false;
			// 
			// ColumnDate
			// 
			this.ColumnDate.DataPropertyName = "Date";
			this.ColumnDate.HeaderText = "Date";
			this.ColumnDate.Name = "ColumnDate";
			this.ColumnDate.ReadOnly = true;
			// 
			// ColumnTime
			// 
			this.ColumnTime.DataPropertyName = "Time";
			this.ColumnTime.HeaderText = "Time";
			this.ColumnTime.Name = "ColumnTime";
			this.ColumnTime.ReadOnly = true;
			// 
			// ColumnFrom
			// 
			this.ColumnFrom.DataPropertyName = "From";
			this.ColumnFrom.HeaderText = "From";
			this.ColumnFrom.Name = "ColumnFrom";
			this.ColumnFrom.ReadOnly = true;
			// 
			// ColumnTo
			// 
			this.ColumnTo.DataPropertyName = "To";
			this.ColumnTo.HeaderText = "To";
			this.ColumnTo.Name = "ColumnTo";
			this.ColumnTo.ReadOnly = true;
			// 
			// ColumnAircraft
			// 
			this.ColumnAircraft.DataPropertyName = "Aircraft";
			this.ColumnAircraft.HeaderText = "Aircraft";
			this.ColumnAircraft.Name = "ColumnAircraft";
			this.ColumnAircraft.ReadOnly = true;
			// 
			// ColumnEconomyPrice
			// 
			this.ColumnEconomyPrice.DataPropertyName = "EconomyPrice";
			this.ColumnEconomyPrice.HeaderText = "Economy Price";
			this.ColumnEconomyPrice.Name = "ColumnEconomyPrice";
			this.ColumnEconomyPrice.ReadOnly = true;
			// 
			// ColumnFlightNumber
			// 
			this.ColumnFlightNumber.DataPropertyName = "FlightNumber";
			this.ColumnFlightNumber.HeaderText = "Flight Number";
			this.ColumnFlightNumber.Name = "ColumnFlightNumber";
			this.ColumnFlightNumber.ReadOnly = true;
			// 
			// ColumnGate
			// 
			this.ColumnGate.DataPropertyName = "Gate";
			this.ColumnGate.HeaderText = "Gate";
			this.ColumnGate.Name = "ColumnGate";
			this.ColumnGate.ReadOnly = true;
			// 
			// ColumnStatus
			// 
			this.ColumnStatus.DataPropertyName = "Status";
			this.ColumnStatus.HeaderText = "Status";
			this.ColumnStatus.Name = "ColumnStatus";
			this.ColumnStatus.ReadOnly = true;
			// 
			// ColumnDetail
			// 
			this.ColumnDetail.HeaderText = "Detail";
			this.ColumnDetail.Name = "ColumnDetail";
			this.ColumnDetail.ReadOnly = true;
			this.ColumnDetail.Text = "Detail";
			this.ColumnDetail.UseColumnTextForLinkValue = true;
			// 
			// FlightScheduleManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1052, 582);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "FlightScheduleManagement";
			this.Text = "FlightScheduleManagement";
			this.Load += new System.EventHandler(this.UserManagement_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnExchange)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox comboFrom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.RadioButton radioAirport;
		private System.Windows.Forms.PictureBox btnExchange;
		private System.Windows.Forms.ComboBox comboTo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radioCity;
		private System.Windows.Forms.DateTimePicker inputDateTo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker inputDateFrom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScheduleId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrom;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAircraft;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEconomyPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFlightNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
		private System.Windows.Forms.DataGridViewLinkColumn ColumnDetail;
	}
}