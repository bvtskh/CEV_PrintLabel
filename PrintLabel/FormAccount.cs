using PrintLabel.SQLHelper;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintLabel
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            var account = AccountHelper.GetAllAccount();
            DataTable dt = new DataTable();
            dt.Columns.Add("Account");
            dt.Columns.Add("Full Name");
            dt.Columns.Add("Dept");
            foreach (var item in account)
            {
                var row = dt.NewRow();
                row[0] = item.ACCOUNT;
                row[1] = item.FULLNAME;
                row[2] = item.DEPT;
                dt.Rows.Add(row);
            }
            dgvAccount.DataSource = dt;
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectRow = dgvAccount.Rows[e.RowIndex];
                if(selectRow != null)
                {
                    var account = AccountHelper.GetAccount(selectRow.Cells[0].Value?.ToString());
                    if(account != null)
                    {
                        txtAccount.Text = account.ACCOUNT;
                        txtPass.Text = account.PASSWORD;
                        txtFullName.Text = account.FULLNAME;
                        txtDept.Text = account.DEPT;
                        txtDescribe.Text = account.DESCRIBE;
                        cbbType.Text = account.TYPE.ToString();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var acc = AccountHelper.GetAccount(txtAccount.Text);
            var type = Common.Common.ConvertDefaultINT(cbbType.Text);
            if (type == 0)
            {
                UIMessageTip.ShowError("Type không phù hợp");
                return;
            }
            if (acc == null)
            {
                // thêm mới
                if(string.IsNullOrEmpty(txtAccount.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(cbbType.Text))
                {
                    UIMessageTip.ShowError("Điền đủ thông tin");
                    return;
                }

               
                AccountHelper.InsertAccount(txtAccount.Text, txtPass.Text, txtFullName.Text, txtDept.Text, txtDescribe.Text, type);
                FormAccount_Load(null, null);
            }
            else
            {
                // sửa
                AccountHelper.Update(txtAccount.Text, txtPass.Text, txtFullName.Text, txtDept.Text, txtDescribe.Text, type);
                FormAccount_Load(null, null);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa User này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AccountHelper.Delete(txtAccount.Text);
                FormAccount_Load(null, null);
            }
        }
    }
}
