namespace SunshineAirlines.Forms.User {
	partial class FoodServices {
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.inputIDTypeNumber = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboIdType = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLoad = new System.Windows.Forms.Button();
			this.comboFlight = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panelFood = new System.Windows.Forms.FlowLayoutPanel();
			this.lblInfo = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("TeXGyreAdventor", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(873, 40);
			this.label1.TabIndex = 2;
			this.label1.Text = "Food Services";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.inputIDTypeNumber);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.comboIdType);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 52);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(873, 63);
			this.panel1.TabIndex = 3;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(369, 4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(134, 51);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// inputIDTypeNumber
			// 
			this.inputIDTypeNumber.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputIDTypeNumber.Location = new System.Drawing.Point(161, 28);
			this.inputIDTypeNumber.Name = "inputIDTypeNumber";
			this.inputIDTypeNumber.Size = new System.Drawing.Size(181, 26);
			this.inputIDTypeNumber.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(157, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "ID Type Number:";
			// 
			// comboIdType
			// 
			this.comboIdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboIdType.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboIdType.FormattingEnabled = true;
			this.comboIdType.Items.AddRange(new object[] {
            "ID Card",
            "Passport"});
			this.comboIdType.Location = new System.Drawing.Point(7, 28);
			this.comboIdType.Name = "comboIdType";
			this.comboIdType.Size = new System.Drawing.Size(144, 27);
			this.comboIdType.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "ID Type:";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnLoad);
			this.panel2.Controls.Add(this.comboFlight);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Location = new System.Drawing.Point(12, 121);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(873, 63);
			this.panel2.TabIndex = 5;
			// 
			// btnLoad
			// 
			this.btnLoad.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoad.Location = new System.Drawing.Point(369, 4);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(134, 51);
			this.btnLoad.TabIndex = 4;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// comboFlight
			// 
			this.comboFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFlight.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboFlight.FormattingEnabled = true;
			this.comboFlight.Location = new System.Drawing.Point(7, 28);
			this.comboFlight.Name = "comboFlight";
			this.comboFlight.Size = new System.Drawing.Size(335, 27);
			this.comboFlight.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 24);
			this.label5.TabIndex = 0;
			this.label5.Text = "Flight:";
			// 
			// panelFood
			// 
			this.panelFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelFood.AutoScroll = true;
			this.panelFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelFood.Location = new System.Drawing.Point(12, 190);
			this.panelFood.Name = "panelFood";
			this.panelFood.Size = new System.Drawing.Size(873, 313);
			this.panelFood.TabIndex = 6;
			// 
			// lblInfo
			// 
			this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfo.Location = new System.Drawing.Point(12, 510);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(160, 72);
			this.lblInfo.TabIndex = 7;
			this.lblInfo.Text = "Selected Items: 0\r\nSelected Amount: 0\r\nPayment: $0";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(300, 531);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 37);
			this.button1.TabIndex = 5;
			this.button1.Text = "Confirm";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(456, 531);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(134, 37);
			this.button2.TabIndex = 8;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// FoodServices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 594);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.panelFood);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "FoodServices";
			this.Text = "FoodServices";
			this.Load += new System.EventHandler(this.FoodServices_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.ComboBox comboFlight;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox inputIDTypeNumber;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboIdType;
		private System.Windows.Forms.FlowLayoutPanel panelFood;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}