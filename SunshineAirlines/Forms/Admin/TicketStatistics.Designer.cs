namespace SunshineAirlines.Forms.Admin {
	partial class TicketStatistics {
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.inputDateFrom = new System.Windows.Forms.DateTimePicker();
			this.inputDateTo = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.checkAmount = new System.Windows.Forms.CheckBox();
			this.comboViewBy = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("TeXGyreAdventor", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(856, 40);
			this.label1.TabIndex = 3;
			this.label1.Text = "Ticket Statistics";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
			this.dataGridView.Location = new System.Drawing.Point(12, 84);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowTemplate.Height = 23;
			this.dataGridView.Size = new System.Drawing.Size(331, 409);
			this.dataGridView.TabIndex = 4;
			// 
			// inputDateFrom
			// 
			this.inputDateFrom.CustomFormat = "yyyy-MM";
			this.inputDateFrom.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputDateFrom.Location = new System.Drawing.Point(12, 52);
			this.inputDateFrom.Name = "inputDateFrom";
			this.inputDateFrom.Size = new System.Drawing.Size(105, 26);
			this.inputDateFrom.TabIndex = 5;
			// 
			// inputDateTo
			// 
			this.inputDateTo.CustomFormat = "yyyy-MM";
			this.inputDateTo.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputDateTo.Location = new System.Drawing.Point(123, 52);
			this.inputDateTo.Name = "inputDateTo";
			this.inputDateTo.Size = new System.Drawing.Size(105, 26);
			this.inputDateTo.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(243, 52);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 26);
			this.button1.TabIndex = 7;
			this.button1.Text = "Statistics";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// chart
			// 
			this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea5.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea5);
			legend5.Name = "Legend1";
			this.chart.Legends.Add(legend5);
			this.chart.Location = new System.Drawing.Point(349, 84);
			this.chart.Name = "chart";
			series5.ChartArea = "ChartArea1";
			series5.Legend = "Legend1";
			series5.Name = "Series1";
			this.chart.Series.Add(series5);
			this.chart.Size = new System.Drawing.Size(519, 409);
			this.chart.TabIndex = 8;
			this.chart.Text = "chart1";
			// 
			// checkAmount
			// 
			this.checkAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkAmount.AutoSize = true;
			this.checkAmount.Font = new System.Drawing.Font("TeXGyreAdventor", 12F);
			this.checkAmount.Location = new System.Drawing.Point(732, 51);
			this.checkAmount.Name = "checkAmount";
			this.checkAmount.Size = new System.Drawing.Size(136, 28);
			this.checkAmount.TabIndex = 9;
			this.checkAmount.Text = "Show Amount";
			this.checkAmount.UseVisualStyleBackColor = true;
			this.checkAmount.CheckedChanged += new System.EventHandler(this.checkAmount_CheckedChanged);
			// 
			// comboViewBy
			// 
			this.comboViewBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboViewBy.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F);
			this.comboViewBy.FormattingEnabled = true;
			this.comboViewBy.Items.AddRange(new object[] {
            "FlightsAmount",
            "TicketsAmount",
            "TicketsRevenue"});
			this.comboViewBy.Location = new System.Drawing.Point(424, 55);
			this.comboViewBy.Name = "comboViewBy";
			this.comboViewBy.Size = new System.Drawing.Size(121, 27);
			this.comboViewBy.TabIndex = 10;
			this.comboViewBy.SelectedIndexChanged += new System.EventHandler(this.comboViewBy_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(345, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 24);
			this.label2.TabIndex = 11;
			this.label2.Text = "View By:";
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MonthValue";
			this.Column1.HeaderText = "Column1";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// TicketStatistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 505);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboViewBy);
			this.Controls.Add(this.checkAmount);
			this.Controls.Add(this.chart);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.inputDateTo);
			this.Controls.Add(this.inputDateFrom);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.label1);
			this.Name = "TicketStatistics";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "TicketSalesDetail";
			this.Load += new System.EventHandler(this.UserManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DateTimePicker inputDateFrom;
		private System.Windows.Forms.DateTimePicker inputDateTo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Windows.Forms.CheckBox checkAmount;
		private System.Windows.Forms.ComboBox comboViewBy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
	}
}