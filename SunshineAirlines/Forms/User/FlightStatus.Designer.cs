namespace SunshineAirlines.Forms.User {
	partial class FlightStatus {
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
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.flightStatusDataSet = new SunshineAirlines.Forms.User.FlightStatusDataSet();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.inputDate = new System.Windows.Forms.DateTimePicker();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.flightStatusDataSet)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// scheduleBindingSource
			// 
			this.scheduleBindingSource.DataMember = "Schedule";
			this.scheduleBindingSource.DataSource = this.flightStatusDataSet;
			// 
			// flightStatusDataSet
			// 
			this.flightStatusDataSet.DataSetName = "FlightStatusDataSet";
			this.flightStatusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("TeXGyreAdventor", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1008, 40);
			this.label1.TabIndex = 2;
			this.label1.Text = "Flight Status";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.inputDate);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 52);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1008, 68);
			this.panel1.TabIndex = 5;
			// 
			// inputDate
			// 
			this.inputDate.CustomFormat = "yyyy-MM-dd";
			this.inputDate.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F);
			this.inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputDate.Location = new System.Drawing.Point(3, 33);
			this.inputDate.Name = "inputDate";
			this.inputDate.Size = new System.Drawing.Size(188, 26);
			this.inputDate.TabIndex = 22;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F);
			this.btnSearch.Location = new System.Drawing.Point(197, 32);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 27);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Departure Date:";
			// 
			// reportViewer
			// 
			this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.scheduleBindingSource;
			this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer.LocalReport.ReportEmbeddedResource = "SunshineAirlines.Forms.User.FlightStatusReport.rdlc";
			this.reportViewer.Location = new System.Drawing.Point(12, 126);
			this.reportViewer.Name = "reportViewer";
			this.reportViewer.ServerReport.BearerToken = null;
			this.reportViewer.Size = new System.Drawing.Size(1008, 422);
			this.reportViewer.TabIndex = 6;
			// 
			// FlightStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1032, 560);
			this.Controls.Add(this.reportViewer);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "FlightStatus";
			this.Text = "FlightStatus";
			this.Load += new System.EventHandler(this.FlightStatus_Load);
			((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.flightStatusDataSet)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker inputDate;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
		private System.Windows.Forms.BindingSource scheduleBindingSource;
		private FlightStatusDataSet flightStatusDataSet;
	}
}