using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines.Forms.Admin {
	public partial class EditUser : Form {
		int? editing = null;
		public EditUser(int? editing) {
			this.editing = editing;
			InitializeComponent();
		}

		Image curPhoto = null;
		private void EditUser_Load(object sender, EventArgs e) {
			if (editing.HasValue) {
				lblTitle.Text = "Edit User";
				inputEmail.Enabled = false;
				var table = Utils.ExecuteTable("SELECT Email,RoleId,Gender,FirstName,LastName,Phone,Address,DateOfBirth,Photo FROM Users WHERE UserId=@0", editing);
				if (table.Rows.Count == 0) {
					MessageBox.Show("User not found!");
					Close();
				}
				var row=table.Rows[0];
				inputEmail.Text = row["Email"].ToString();
				inputFirstName.Text = row["FirstName"].ToString();
				inputLastName.Text = row["LastName"].ToString();
				inputTelephone.Text = row["Phone"].ToString();
				inputAddress.Text = row["Address"].ToString();
				inputBirthdate.Value = (DateTime)row["DateOfBirth"];
				int role = (int)row["RoleId"];
				if (role == 2) {
					radioAdmin.Checked = true;
				}
				if (row["Gender"].ToString() == "F") {
					radioFemale.Checked = true;
				}
				var photo = row["Photo"] as byte[];
				if (photo != null) {
					var buf = new MemoryStream(photo);
					curPhoto = Image.FromStream(buf);
					photoBox.Image = curPhoto;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void button1_Click(object sender, EventArgs e) {
			string email = inputEmail.Text.Trim();
			if (email.Length == 0) {
				MessageBox.Show("Please input Email!");
				return;
			}
			if(!Regex.IsMatch(email, @"[A-Za-z0-9-_]+?@[A-Za-z0-9-_]+?(?:\.[A-Za-z0-9-_]+?)+")) {
				MessageBox.Show("Please input a correct Email!");
				return;
			}

			string phone = inputTelephone.Text.Trim();
			if (phone.Length != 0 && !Regex.IsMatch(phone, @"[0-9]{11}")) {
				MessageBox.Show("Please input a correct Phone!");
				return;
			}

			string firstName = inputFirstName.Text.Trim();
			if (firstName.Length == 0) {
				MessageBox.Show("Please input FirstName!");
				return;
			}

			string lastName = inputLastName.Text.Trim();
			if (lastName.Length == 0) {
				MessageBox.Show("Please input LastName!");
				return;
			}
			string address=inputAddress.Text.Trim();

			int roleId = radioUser.Checked ? 1 : 2;
			string gender = radioMale.Checked ? "M" : "F";
			DateTime birthdate = inputBirthdate.Value;
			byte[] photo = null;
			if (curPhoto != null) {
				using(var buf=new MemoryStream()) {
					curPhoto.Save(buf, ImageFormat.Jpeg);
					photo = buf.ToArray();
				}
			}

			if (!editing.HasValue) {
				string password;
				{
					int index = email.IndexOf('@');
					if (index > 6) {
						index = 6;
					}
					password = email.Substring(0, index);
				}

				Utils.ExecuteUpdate("INSERT INTO Users(Email,Password,FirstName,LastName,RoleId,Gender,Phone,Address,DateOfBirth,Photo) VALUES(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9)",
					email, password, firstName, lastName, roleId, gender, phone, address, birthdate, photo);
			} else {
				Utils.ExecuteUpdate("UPDATE Users SET FirstName=@1,LastName=@2,RoleId=@3,Gender=@4,Phone=@5,Address=@6,DateOfBirth=@7,Photo=@8 WHERE UserId=@0",
					editing.Value, firstName, lastName, roleId, gender, phone, address, birthdate, photo);
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnSelectPhoto_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() != DialogResult.OK) {
				return;
			}

			var path = openFileDialog.FileName;
			var size = new FileInfo(path).Length;
			if (size > 1024 * 100) {
				MessageBox.Show("Image needs to be smaller than 100KB!");
				return;
			}

			using (var file = File.OpenRead(path)) {
				var buf = new MemoryStream();
				file.CopyTo(buf);
				curPhoto = Image.FromStream(buf);
			}
			photoBox.Image = curPhoto;
		}
	}
}
