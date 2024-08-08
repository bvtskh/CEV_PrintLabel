using BarTender;
using PrintLabel.Models;
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
    public partial class FormConfigPath : Form
    {
        PrintHelper printHelper = new PrintHelper();
        public FormConfigPath()
        {
            InitializeComponent();
            SetFont(cbbModel, cbbDest, cbbPrintType);
        }

        private void SetFont(params UIComboBox[] cbb)
        {
            foreach(var item in cbb)
            {
                item.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            }
        }

        private void FormConfigPath_Load(object sender, EventArgs e)
        {
            cbbModel.Items.AddRange(printHelper.GetAllModel().ToArray());          
        }

        private void btnOpenBar_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Text files (*.btw)|*.btw|All files (*.*)|*.*";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtBartender.Text = open.FileName;
                }
            }
        }

        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtDatabase.Text = open.FileName;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbModel.Text) || string.IsNullOrEmpty(cbbDest.Text) || string.IsNullOrEmpty(cbbPrintType.Text))
            {
                UIMessageTip.ShowWarning("Please select complete information", 2000);
                return;
            }
            if (string.IsNullOrEmpty(txtDatabase.Text) || string.IsNullOrEmpty(txtDatabase.Text))
            {
                UIMessageTip.ShowWarning("Please select full path", 2000);
                return;
            }
            var printType = printHelper.GetPrintType(cbbPrintType.Text);
            if (printHelper.SaveChangePath(txtBartender.Text, txtDatabase.Text, cbbModel.Text, cbbDest.Text, printType))
            {
                MessageBox.Show("Save change success full");
            }
            else
            {
                MessageBox.Show("Error!!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ResetResult()
        {
            cbbPrintType.Items.Clear();
            cbbPrintType.Clear();
            txtBartender.Clear();
            txtDatabase.Clear();
        }

        private void cbbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDest.Items.Clear();
            cbbDest.Clear();
            ResetResult();
            var destList = printHelper.GetMasterDataByModelName(cbbModel.Text).Select(s => s.DEST).Distinct().ToArray();
            cbbDest.Items.AddRange(destList);
        }

        private void cbbDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetResult();
            var bodyList = printHelper.GetPrintType(cbbModel.Text, cbbDest.Text).ToArray();
            if (bodyList.Length > 0)
            {
                cbbPrintType.Items.AddRange(bodyList);
            }
        }

        private void cbbPrintType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var printType = printHelper.GetPrintType(cbbPrintType.Text);
            txtBartender.Text = printHelper.GetBartenderPath(cbbModel.Text, cbbDest.Text, printType);
            txtDatabase.Text = printHelper.GetDatabsePath(cbbModel.Text, cbbDest.Text, printType);
        }
        //private void ShowMessage(string key, string str_status, string str_message)
        //{
        //    switch (key)
        //    {
        //        case "PASS":
        //            this.BeginInvoke(new Action(() => { lblStatus.Text = str_status; }));
        //            this.BeginInvoke(new Action(() => { lblStatus.BackColor = Color.DarkGreen; }));
        //            this.BeginInvoke(new Action(() => { lblMessage.Text = str_message; }));
        //            this.BeginInvoke(new Action(() => { lblMessage.BackColor = Color.DarkGreen; }));
        //            break;
        //        case "FAIL":
        //            this.BeginInvoke(new Action(() => { lblStatus.Text = str_status; }));
        //            this.BeginInvoke(new Action(() => { lblStatus.BackColor = Color.DarkRed; }));
        //            this.BeginInvoke(new Action(() => { lblMessage.Text = str_message; }));
        //            this.BeginInvoke(new Action(() => { lblMessage.BackColor = Color.DarkRed; }));
        //            break;
        //        case "Wait":
        //            this.BeginInvoke(new Action(() => { lblStatus.Text = str_status; }));
        //            this.BeginInvoke(new Action(() => { lblStatus.BackColor = Color.FromArgb(255, 128, 0); }));
        //            this.BeginInvoke(new Action(() => { lblMessage.Text = str_message; }));
        //            this.BeginInvoke(new Action(() => { lblMessage.BackColor = Color.FromArgb(255, 128, 0); }));
        //            break;
        //        case "Default":
        //            this.BeginInvoke(new Action(() => { lblStatus.Text = @"[N\A]"; }));
        //            this.BeginInvoke(new Action(() => { lblStatus.BackColor = Color.FromArgb(255, 128, 0); }));
        //            this.BeginInvoke(new Action(() => { lblMessage.Text = "no results"; }));
        //            this.BeginInvoke(new Action(() => { lblMessage.BackColor = Color.FromArgb(255, 128, 0); }));
        //            break;
        //    }
        //}

    }
}
