using PrintLabel.SQLHelper;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintLabel
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            txtAccount.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using(FormLoading f = new FormLoading(Login))
            {
                f.ShowDialog();
            }
        }

        private void Login()
        {
            var account = AccountHelper.GetAccount(txtAccount.Text, txtPassword.Text);
            if (account == null)
            {
                UIMessageTip.ShowError("Thông tin tài khoản hoặc mật khẩu không chính xác!");
                return;
            }
            this.BeginInvoke(new Action(() =>
            {
                this.Hide();
                new FormMain(account).ShowDialog();
                this.Close();
            }));
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
