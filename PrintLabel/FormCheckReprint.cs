using PrintLabel.Models;
using PrintLabel.SQLHelper;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrintLabel
{
    public partial class FormCheckReprint : Form
    {
        MASTER_DATA data;
        string checker;
        string reason;
        int printNumer;
        int start;
        public FormCheckReprint(MASTER_DATA data, string checker, string reason, int printNumer, int start)
        {
            InitializeComponent();
            this.data = data;
            this.checker = checker;
            this.reason = reason;
            this.start = start;
            this.printNumer = printNumer;
        }

        private void FormCheckReprint_Load(object sender, EventArgs e)
        {
            for(int i = start ; i < printNumer+start; i++)
            {
                var index = dgvCheck.Rows.Add();
                dgvCheck.Rows[index].Cells[0].Value = index+1;
                dgvCheck.Rows[index].Cells[1].Value = data.START_CODE + i.ToString().PadLeft((int)data.CHAR_NUMBER - data.START_CODE.Length,'0');
            }
        }

        private void txtCheckLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var value = txtCheckLabel.Text;
                if (string.IsNullOrEmpty(value)) return;
                var row = dgvCheck.Rows.Cast<DataGridViewRow>().Where(w => w.Cells[1].Value?.ToString() == value).FirstOrDefault();
                if (row != null)
                {
                    row.Cells[2].Value = value;
                }       
                var checkConfirm = dgvCheck.Rows.Cast<DataGridViewRow>().Where(w => w.Cells[2].Value == null).ToList();
                if (checkConfirm.Count == 0)
                {
                    using (FormLoading form = new FormLoading(PrintLabel))
                    {
                        form.ShowDialog(this);
                    }
                }
                txtCheckLabel.Focus();
                txtCheckLabel.SelectAll();
            }
        }
        private void PrintLabel()
        {
            FileStream FILEDATA = new FileStream(data.DATABASE_PATH, FileMode.Create);
            TextWriter writer = new StreamWriter(FILEDATA);

            List<string> barcodeList = dgvCheck.Rows.Cast<DataGridViewRow>().Select(s=>s.Cells[1].Value?.ToString()).ToList();
            foreach(var barcode in barcodeList)
            {
                writer.Write(barcode);
                writer.WriteLine();
            }


            writer.Close();
            if (PrintHelper.SaveRePrintDataLog(data, barcodeList, AccountHelper.Account.ACCOUNT, reason, checker))
            {
                BarTender.Application btApp;
                BarTender.Format btFomart;
                btApp = new BarTender.Application();

                if (File.Exists(data.PRINT_PATH))
                {
                    btFomart = btApp.Formats.Open(data.PRINT_PATH, false, string.Empty);
                }
                else
                {
                    MessageBox.Show("Error: The Template is not exist !");
                    return;
                }
                btFomart.PrintOut(false, false);
                btFomart.Close(BarTender.BtSaveOptions.btDoNotSaveChanges);
                MessageBox.Show("Printed success full!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, in thất bại!");
                return;
            }
        }

        private void txtCheckLabel_Click(object sender, EventArgs e)
        {
            txtCheckLabel.Focus();
            txtCheckLabel.SelectAll();
        }
    }
}
