namespace SunshineAirlines.Forms.Admin {
	partial class UserManagement {
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
			this.button1 = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.inputName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboRole = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comboPage = new System.Windows.Forms.ComboBox();
			this.lblInfo = new System.Windows.Forms.Label();
			this.btnEdit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnPreviousPage = new System.Windows.Forms.PictureBox();
			this.btnFirstPage = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPreviousPage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnFirstPage)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("TeXGyreAdventor", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(776, 40);
			this.label1.TabIndex = 3;
			this.label1.Text = "User Management";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.inputName);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.comboRole);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 52);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 68);
			this.panel1.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F);
			this.button1.Location = new System.Drawing.Point(407, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 27);
			this.button1.TabIndex = 5;
			this.button1.Text = "Add a new user";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F);
			this.btnSearch.Location = new System.Drawing.Point(326, 32);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 27);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// inputName
			// 
			this.inputName.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputName.Location = new System.Drawing.Point(165, 33);
			this.inputName.Name = "inputName";
			this.inputName.Size = new System.Drawing.Size(146, 26);
			this.inputName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(165, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Name:";
			// 
			// comboRole
			// 
			this.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboRole.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboRole.FormattingEnabled = true;
			this.comboRole.Location = new System.Drawing.Point(4, 32);
			this.comboRole.Name = "comboRole";
			this.comboRole.Size = new System.Drawing.Size(139, 27);
			this.comboRole.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Role:";
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
            this.Column1});
			this.dataGridView.Location = new System.Drawing.Point(13, 127);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowTemplate.Height = 23;
			this.dataGridView.Size = new System.Drawing.Size(775, 287);
			this.dataGridView.TabIndex = 5;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "UserId";
			this.Column1.HeaderText = "Column1";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// comboPage
			// 
			this.comboPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboPage.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F);
			this.comboPage.FormattingEnabled = true;
			this.comboPage.Location = new System.Drawing.Point(88, 422);
			this.comboPage.Name = "comboPage";
			this.comboPage.Size = new System.Drawing.Size(68, 27);
			this.comboPage.TabIndex = 8;
			this.comboPage.SelectedIndexChanged += new System.EventHandler(this.comboPage_SelectedIndexChanged);
			// 
			// lblInfo
			// 
			this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfo.Location = new System.Drawing.Point(238, 423);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(39, 24);
			this.lblInfo.TabIndex = 6;
			this.lblInfo.Text = "Info";
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(706, 419);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(82, 32);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox1.Image = global::SunshineAirlines.Properties.Resources.lastPage;
			this.pictureBox1.Location = new System.Drawing.Point(200, 419);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox2.Image = global::SunshineAirlines.Properties.Resources.nextPage;
			this.pictureBox2.Location = new System.Drawing.Point(162, 419);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// btnPreviousPage
			// 
			this.btnPreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPreviousPage.Image = global::SunshineAirlines.Properties.Resources.previousPage;
			this.btnPreviousPage.Location = new System.Drawing.Point(50, 419);
			this.btnPreviousPage.Name = "btnPreviousPage";
			this.btnPreviousPage.Size = new System.Drawing.Size(32, 32);
			this.btnPreviousPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnPreviousPage.TabIndex = 7;
			this.btnPreviousPage.TabStop = false;
			this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
			// 
			// btnFirstPage
			// 
			this.btnFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnFirstPage.Image = global::SunshineAirlines.Properties.Resources.firstPage;
			this.btnFirstPage.Location = new System.Drawing.Point(12, 419);
			this.btnFirstPage.Name = "btnFirstPage";
			this.btnFirstPage.Size = new System.Drawing.Size(32, 32);
			this.btnFirstPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnFirstPage.TabIndex = 6;
			this.btnFirstPage.TabStop = false;
			this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
			// 
			// UserManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 463);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.comboPage);
			this.Controls.Add(this.btnPreviousPage);
			this.Controls.Add(this.btnFirstPage);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "UserManagement";
			this.Text = "UserManagement";
			this.Load += new System.EventHandler(this.UserManagement_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPreviousPage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnFirstPage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox inputName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboRole;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.PictureBox btnFirstPage;
		private System.Windows.Forms.PictureBox btnPreviousPage;
		private System.Windows.Forms.ComboBox comboPage;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
	}
}