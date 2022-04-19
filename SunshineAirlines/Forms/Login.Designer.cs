namespace SunshineAirlines.Forms {
	partial class Login {
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

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.inputEmail = new System.Windows.Forms.TextBox();
			this.inputPwd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.inputCode = new System.Windows.Forms.TextBox();
			this.lblCodeTitle = new System.Windows.Forms.Label();
			this.lblCode = new System.Windows.Forms.Label();
			this.inputRemember = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("TeXGyreAdventor", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(650, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(650, 40);
			this.label2.TabIndex = 1;
			this.label2.Text = "The system can be logged in through email and password";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(180, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// inputEmail
			// 
			this.inputEmail.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputEmail.Location = new System.Drawing.Point(266, 138);
			this.inputEmail.Name = "inputEmail";
			this.inputEmail.Size = new System.Drawing.Size(230, 31);
			this.inputEmail.TabIndex = 3;
			// 
			// inputPwd
			// 
			this.inputPwd.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputPwd.Location = new System.Drawing.Point(266, 184);
			this.inputPwd.Name = "inputPwd";
			this.inputPwd.Size = new System.Drawing.Size(230, 31);
			this.inputPwd.TabIndex = 5;
			this.inputPwd.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(149, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 28);
			this.label4.TabIndex = 4;
			this.label4.Text = "Password:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// inputCode
			// 
			this.inputCode.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputCode.Location = new System.Drawing.Point(266, 231);
			this.inputCode.Name = "inputCode";
			this.inputCode.Size = new System.Drawing.Size(127, 31);
			this.inputCode.TabIndex = 7;
			// 
			// lblCodeTitle
			// 
			this.lblCodeTitle.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCodeTitle.Location = new System.Drawing.Point(100, 234);
			this.lblCodeTitle.Name = "lblCodeTitle";
			this.lblCodeTitle.Size = new System.Drawing.Size(160, 28);
			this.lblCodeTitle.TabIndex = 6;
			this.lblCodeTitle.Text = "Verification Code:";
			this.lblCodeTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCode
			// 
			this.lblCode.BackColor = System.Drawing.Color.Black;
			this.lblCode.Font = new System.Drawing.Font("TeXGyreAdventor", 16F, System.Drawing.FontStyle.Bold);
			this.lblCode.ForeColor = System.Drawing.Color.White;
			this.lblCode.Location = new System.Drawing.Point(399, 227);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(97, 41);
			this.lblCode.TabIndex = 8;
			this.lblCode.Text = "1234";
			this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCode.Click += new System.EventHandler(this.lblCode_Click);
			// 
			// inputRemember
			// 
			this.inputRemember.AutoSize = true;
			this.inputRemember.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputRemember.Location = new System.Drawing.Point(245, 283);
			this.inputRemember.Name = "inputRemember";
			this.inputRemember.Size = new System.Drawing.Size(178, 28);
			this.inputRemember.TabIndex = 9;
			this.inputRemember.Text = "Auto login in 7 days";
			this.inputRemember.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(201, 330);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 43);
			this.button1.TabIndex = 10;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(356, 330);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(118, 43);
			this.button2.TabIndex = 11;
			this.button2.Text = "Close";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 414);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.inputRemember);
			this.Controls.Add(this.lblCode);
			this.Controls.Add(this.inputCode);
			this.Controls.Add(this.lblCodeTitle);
			this.Controls.Add(this.inputPwd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.inputEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox inputEmail;
		private System.Windows.Forms.TextBox inputPwd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox inputCode;
		private System.Windows.Forms.Label lblCodeTitle;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.CheckBox inputRemember;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

