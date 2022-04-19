using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines.Forms {
	public partial class Login : Form {
		public Login() {
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e) {
			Close();
		}

		public static bool Quitting { get; set; } = false;

		bool needCode = false;
		Random random = new Random();
		const string CodeAlphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		StringBuilder sb = new StringBuilder();
		void ResetCode() {
			inputCode.Clear();
			sb.Clear();
			for(int i = 0; i < 4; i += 1) {
				sb.Append(CodeAlphabet[random.Next(0, CodeAlphabet.Length)]);
			}
			lblCode.Text = sb.ToString();
		}
		void UpdateCode() {
			lblCode.Enabled = needCode;
			lblCode.Visible = needCode;
			lblCodeTitle.Visible = needCode;
			lblCodeTitle.Enabled = needCode;
			inputCode.Visible = needCode;
			inputCode.Enabled = needCode;
			if (needCode) {
				ResetCode();
			}
		}

		private void Login_Load(object sender, EventArgs e) {
			UpdateCode();

			if (File.Exists(SessionFilePath)) {
				var json=File.ReadAllText(SessionFilePath);
				var session = Utils.DeserializeFromJson<SessionData>(json);
				if (DateTimeOffset.Now <= session.saveTime.AddDays(7)) {
					inputEmail.Text = session.email;
					TryLogin(session.email, session.password);
				} else {
					File.Delete(SessionFilePath);
				}
			}
		}

		[DataContract]
		struct SessionData {
			[DataMember]
			public string email;
			[DataMember]
			public string password;
			[DataMember]
			public DateTimeOffset saveTime;
		}

		int failTimes = 0;
		const string SessionFilePath = "./session.json";
		private void button1_Click(object sender, EventArgs e) {
			if (needCode) {
				string code = inputCode.Text.Trim();
				if (code != lblCode.Text) {
					MessageBox.Show("Verification Code doesn't match!");
					ResetCode();
					return;
				}
			}

			string email = inputEmail.Text.Trim();
			string pwd = inputPwd.Text.Trim();
			TryLogin(email, pwd);
		}

		void TryLogin(string email,string pwd) {
			if (email.Length == 0) {
				MessageBox.Show("Please input your E-mail!");
				return;
			}
			if (pwd.Length == 0) {
				MessageBox.Show("Please input your password!");
				return;
			}

			var table = Utils.ExecuteQuery("SELECT UserId,RoleId FROM Users WHERE Email=@0 AND Password=@1", email, pwd);
			if (table.Rows.Count == 0) {
				if (File.Exists(SessionFilePath)) {
					File.Delete(SessionFilePath);
				}
				MessageBox.Show("Your E-mail and password doesn't match!");
				inputPwd.Clear();
				failTimes += 1;
				needCode = failTimes >= 3;
				UpdateCode();
				return;
			}

			if (inputRemember.Checked) {
				var json = Utils.SerializeToJson(new SessionData {
					email = email,
					password = pwd,
					saveTime = DateTimeOffset.Now
				});
				File.WriteAllText(SessionFilePath, json);
			}

			var row = table.Rows[0];
			int uid = (int)row["UserId"];
			int role = (int)row["RoleId"];

			Form form;
			switch (role) {
				case 2:
					form = new Admin.AdminMenu(uid);
					break;
				default:
					form = new User.UserMenu(uid);
					break;
			}

			inputPwd.Clear();
			UpdateCode();

			form.ShowDialog();

			if (Quitting) {
				Close();
			}
		}

		private void lblCode_Click(object sender, EventArgs e) {
			ResetCode();
		}
	}
}
