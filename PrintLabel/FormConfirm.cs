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
    public partial class FormConfirm : Form
    {
        public FormConfirm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var account = txtAccount.Text;
            var password = txtPassword.Text;
            if (AccountHelper.IsAdmin(account, password))
            {
                this.Hide();
                new FormConfigPath().ShowDialog();
                this.Close();
            }
            else
            {
                UIMessageTip.ShowWarning("Chỉ có tài khoản quyền Admin mới có thể sửa!");
            }
        }
    }
}
