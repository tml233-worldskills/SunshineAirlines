using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines.Forms.Admin {
	public partial class UserManagement : Form {
		public UserManagement() {
			InitializeComponent();
		}

		List<int> roleIds = new List<int>();
		private void UserManagement_Load(object sender, EventArgs e) {
			comboRole.Items.Add("All");
			comboRole.SelectedIndex = 0;
			foreach(var r in Utils.ExecuteReader("SELECT RoldId, RoleName FROM Role")) {
				comboRole.Items.Add(r["RoleName"].ToString());
				roleIds.Add((int)r["RoldId"]);
			}
			UpdateData(-1, null);
		}

		const int PageSize = 10;
		int curPage = 0;
		int RecordCount => table?.Rows.Count ?? 0;
		int PageCount => (int)Math.Round(RecordCount / (float)PageSize);
		DataTable table;

		void UpdatePage() {
			if (table == null) {
				curPage = 0;
				return;
			}
			if (curPage < 0) curPage = 0;
			if (curPage >= PageCount) curPage = PageCount - 1;

			comboPageStop = true;
			comboPage.SelectedIndex = curPage;
			comboPageStop = false;

			dataGridView.DataSource = table.AsEnumerable().Skip(curPage * PageSize).Take(PageSize).CopyToDataTable();
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			int role = comboRole.SelectedIndex == 0 ? -1 : roleIds[comboRole.SelectedIndex-1];
			UpdateData(role, inputName.Text.Trim());
		}

		int lastRole = -1;
		string lastName = null;
		void UpdateData(int role,string name) {
			lastRole = role;
			lastName = name;

			string sql = "SELECT UserId,Email,FirstName+' '+LastName as Name, CASE Gender WHEN 'M' THEN 'Male' ELSE 'Female' END, DateOfBirth, Phone, RoleName FROM Users,Role WHERE Users.RoleId=Role.RoldId";
			List<object> args = new List<object>();
			int argIndex = 0;
			if (role >= 0) {
				sql += string.Format(" AND RoleId=@{0}", argIndex);
				argIndex += 1;
				args.Add(role);
			}
			if (!string.IsNullOrWhiteSpace(name)) {
				sql += string.Format(" AND FirstName+' '+LastName LIKE @{0}", argIndex);
				argIndex += 1;
				args.Add("%"+name+"%");
			}
			table = Utils.ExecuteQuery(sql, args.ToArray());
			if (table.Rows.Count == 0) {
				table = null;
				dataGridView.DataSource = null;
			}
			curPage = 0;

			comboPageStop = true;
			comboPage.Items.Clear();
			for(int i = 0; i < PageCount; i += 1) {
				comboPage.Items.Add((i + 1).ToString());
			}
			comboPage.SelectedIndex = comboPage.Items.Count > 0 ? 0 : -1;
			comboPageStop = false;

			lblInfo.Text = String.Format("Total Pages: {0}    Total Records: {1}", PageCount, RecordCount);
			UpdatePage();
		}

		private void btnFirstPage_Click(object sender, EventArgs e) {
			curPage = 0;
			UpdatePage();
		}

		private void btnPreviousPage_Click(object sender, EventArgs e) {
			curPage -= 1;
			UpdatePage();
		}

		private void pictureBox2_Click(object sender, EventArgs e) {
			curPage += 1;
			UpdatePage();
		}

		private void pictureBox1_Click(object sender, EventArgs e) {
			curPage = PageCount-1;
			UpdatePage();
		}

		bool comboPageStop = false;
		private void comboPage_SelectedIndexChanged(object sender, EventArgs e) {
			int index = comboPage.SelectedIndex;
			if (comboPageStop || index == -1) {
				return;
			}
			curPage = index;
			UpdatePage();
		}

		private void button1_Click(object sender, EventArgs e) {
			var form = new EditUser(null);
			if (form.ShowDialog() == DialogResult.OK) {
				UpdateData(lastRole, lastName);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			if(dataGridView.SelectedCells.Count == 0) {
				MessageBox.Show("Please select a user!");
				return;
			}
			int id = (int)(dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].DataBoundItem as DataRowView)["UserId"];
			var form = new EditUser(id);
			if (form.ShowDialog() == DialogResult.OK) {
				UpdateData(lastRole, lastName);
			}
		}
	}
}
