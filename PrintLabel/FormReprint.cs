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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintLabel
{
    public partial class FormReprint : Form
    {
        MASTER_DATA data;
        string account;
        int printType;

        PrintHelper printHelper = new PrintHelper();

        BackgroundWorker worker;
        Timer timer;
        public FormReprint(Models.MASTER_DATA data, string account, int printType)
        {
            InitializeComponent();
            this.data = data;
            this.account = account;
            this.printType = printType;

            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;

            timer = new Timer();
            timer.Tick += Timer_Tick;

            cbbReason.Font = new Font("Arial",12, FontStyle.Bold);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(worker.IsBusy) { return; }
            worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var total = Common.Common.ConvertDefaultINT(lbPrintedTotal.Text);
                var from = Common.Common.ConvertDefaultINT(txtFrom.Text);
                var to = Common.Common.ConvertDefaultINT(txtTo.Text);
                this.BeginInvoke(new Action(() =>
                {
                    if (from > total || to > total || from > to)
                    {
                        txtStartBodyNo.Clear();
                        txtEndBodyNo.Clear();
                    }
                    else
                    {
                        var start = data.START_CODE;
                        txtStartBodyNo.Text = start + from.ToString().PadLeft((int)(data.CHAR_NUMBER - start.Length), '0');
                        txtEndBodyNo.Text = start + to.ToString().PadLeft((int)(data.CHAR_NUMBER - start.Length), '0');
                    }
                }));
            }
            catch (Exception)
            {
                return;
            }
        }

        private void FormReprint_Load(object sender, EventArgs e)
        {
            txtModel.Text = data.MODEL;
            txtDest.Text = data.DEST;
            txtCell.Text = data.CELL;
            lbPrinter.Text = account;
            lbPrintType.Text = printHelper.GetPrintType(printType);
            lbCharNumber.Text = data.CHAR_NUMBER?.ToString();
            lbPrintedTotal.Text = printHelper.GetPrintUpdateData(data.ID)?.ToString();

            timer.Start();
        }

        private void txtFrom_Click(object sender, EventArgs e)
        {
            UITextBox uITextBox = sender as UITextBox;
            if (uITextBox != null)
            {
                uITextBox.SelectAll();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (FormLoading form = new FormLoading(PrintLabel))
            {
                form.ShowDialog(this);
            }
        }

        private void PrintLabel()
        {
            if(lbPrintedTotal.Text == "0")
            {
                UIMessageTip.ShowError("Model này chưa từng được in!");
                return;
            }
            if(string.IsNullOrEmpty(cbbReason.Text))
            {
                UIMessageTip.ShowError("Nhập hoặc chọn lý do in lại!");
                return;
            }
            var reason = cbbReason.Text;
            var from = Common.Common.ConvertDefaultINT(txtFrom.Text);
            var to = Common.Common.ConvertDefaultINT(txtTo.Text);
            if(from > to)
            {
                UIMessageTip.ShowError("Nhập số lượng cần in lại!");
                return;
            }
            if(string.IsNullOrEmpty(txtStartBodyNo.Text) || string.IsNullOrEmpty(txtEndBodyNo.Text))
            {
                UIMessageTip.ShowError("Số lượng in lại lớn hơn số lượng thực tế đã in!");
                return;
            }
            FileStream FILEDATA = new FileStream(data.DATABASE_PATH, FileMode.Create);
            TextWriter writer = new StreamWriter(FILEDATA);

            List<string> barcodeList = new List<string>();
            for (int i = from; i <= to; i++)
            {
                var end = i.ToString().PadLeft((int)data.CHAR_NUMBER - data.START_CODE.Length, '0');
                string barcode = data.START_CODE + end;
                writer.Write(barcode);
                writer.WriteLine();
                barcodeList.Add(barcode);
            }

            writer.Close();
            if(PrintHelper.SaveRePrintDataLog(data, barcodeList, account, reason))
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
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, in thất bại!");
                return;
            }
        }

        private void FormReprint_Shown(object sender, EventArgs e)
        {
            txtFrom.Focus();
            txtFrom.SelectAll();
        }
    }
}
