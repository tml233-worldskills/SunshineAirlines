namespace SunshineAirlines.Forms.Admin {
	partial class AdminMenu {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flightScheduleManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ticketStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightScheduleManagementToolStripMenuItem,
            this.ticketStatisticsToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 25);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
			this.logoutToolStripMenuItem.Text = "Logout";
			this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// flightScheduleManagementToolStripMenuItem
			// 
			this.flightScheduleManagementToolStripMenuItem.Name = "flightScheduleManagementToolStripMenuItem";
			this.flightScheduleManagementToolStripMenuItem.Size = new System.Drawing.Size(188, 21);
			this.flightScheduleManagementToolStripMenuItem.Text = "Flight Schedule Management";
			// 
			// ticketStatisticsToolStripMenuItem
			// 
			this.ticketStatisticsToolStripMenuItem.Name = "ticketStatisticsToolStripMenuItem";
			this.ticketStatisticsToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
			this.ticketStatisticsToolStripMenuItem.Text = "Ticket Statistics";
			// 
			// userManagementToolStripMenuItem
			// 
			this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
			this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(128, 21);
			this.userManagementToolStripMenuItem.Text = "User Management";
			// 
			// AdminMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 464);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "AdminMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Administrator Menu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem flightScheduleManagementToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ticketStatisticsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
	}
}