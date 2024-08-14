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
    public partial class FormReprint1 : Form
    {
        MASTER_DATA data;
        string account;
        int printType;

        PrintHelper printHelper = new PrintHelper();

        BackgroundWorker worker;
        Timer timer;
        public FormReprint1(Models.MASTER_DATA data, string account, int printType)
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
                var from = Common.Common.ConvertDefaultINT(txtEndNumber.Text);
                var numberPrint = Common.Common.ConvertDefaultINT(txtNumberPrint.Text);

                this.BeginInvoke(new Action(() =>
                {
                    if ((txtEndNumber.Text.Length != data.CHAR_NUMBER - data.START_CODE.Length) || from <= 0)
                    {
                        txtEndBodyNo.Clear();
                        return;
                    }
                    //if (from > total || (from + numberPrint) > total+1 || numberPrint <= 0 || from <= 0)
                    //{
                    //    txtEndBodyNo.Clear();
                    //}
                    else
                    {
                        var start = data.START_CODE;
                        var end = "";
                        if(from <= total && from + numberPrint <= total+1)
                        {
                            end = (from + numberPrint -1).ToString().PadLeft((int)data.CHAR_NUMBER - start.Length, '0');

                            if (numberPrint == 0)
                            {
                                end = "";
                            }
                        }
                        //else
                        //{
                        //    end = total.ToString().PadLeft((int)data.CHAR_NUMBER - start.Length, '0');
                        //}
                        else
                        {
                            end = "";
                        }
                        txtEndBodyNo.Text = start + end;
                    }
                    //if (from > total || to > total || from > to)
                    //{
                    //    txtStartBodyNo.Clear();
                    //    txtEndBodyNo.Clear();
                    //}
                    //else
                    //{
                    //    var start = data.START_CODE;
                    //    txtStartBodyNo.Text = start + from.ToString().PadLeft((int)(data.CHAR_NUMBER - start.Length), '0');
                    //    txtEndBodyNo.Text = start + to.ToString().PadLeft((int)(data.CHAR_NUMBER - start.Length), '0');
                    //}
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
            txtStartBodyNo.Text = data.START_CODE.ToString();
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
            //using (FormLoading form = new FormLoading(PrintLabel))
            //{
            //    form.ShowDialog(this);
            //}
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
            var from = Common.Common.ConvertDefaultINT(txtEndNumber.Text);
            var to = Common.Common.ConvertDefaultINT(txtNumberPrint.Text);
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
            //if(PrintHelper.SaveRePrintDataLog(data, barcodeList, account, reason))
            //{
            //    BarTender.Application btApp;
            //    BarTender.Format btFomart;
            //    btApp = new BarTender.Application();

            //    if (File.Exists(data.PRINT_PATH))
            //    {
            //        btFomart = btApp.Formats.Open(data.PRINT_PATH, false, string.Empty);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error: The Template is not exist !");
            //        return;
            //    }
            //    btFomart.PrintOut(false, false);
            //    btFomart.Close(BarTender.BtSaveOptions.btDoNotSaveChanges);
            //    MessageBox.Show("Printed success full!");
            //}
            //else
            //{
            //    MessageBox.Show("Có lỗi xảy ra, in thất bại!");
            //    return;
            //}
        }

        private void FormReprint_Shown(object sender, EventArgs e)
        {
            txtChecker.Focus();
            txtChecker.SelectAll();
        }

        private void txtEndNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtNumberPrint.Focus();
                txtNumberPrint.SelectAll();
            }
        }

        private void txtNumberPrint_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                var checker = txtChecker.Text;
                var reason = cbbReason.Text;
                var printNumer = Common.Common.ConvertDefaultINT(txtNumberPrint.Text);
                var start = Common.Common.ConvertDefaultINT(txtEndNumber.Text);

                if (lbPrintedTotal.Text == "0")
                {
                    UIMessageTip.ShowError("Model này chưa từng được in!");
                    return;
                }

                if (string.IsNullOrEmpty(checker))
                {
                    UIMessageTip.ShowWarning("Nhập Checker!");
                    txtChecker.Focus();
                    txtChecker.SelectAll();
                    return;
                }
                if (string.IsNullOrEmpty(reason))
                {
                    UIMessageTip.ShowWarning("Chọn lý do in lại!");
                    cbbReason.Focus();
                    cbbReason.SelectAll();
                    return;
                }
                if (txtEndBodyNo.Text.Length != data.CHAR_NUMBER)
                {
                    UIMessageTip.ShowWarning("Label in lại chưa đúng!");
                    return;
                }
                using (FormCheckReprint f = new FormCheckReprint(data, checker, reason, printNumer, start))
                {
                    f.ShowDialog();
                }
            }              
        }

        private void txtChecker_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cbbReason.ShowDropDown();
                cbbReason.Focus();
                cbbReason.SelectAll();

            }
        }

        private void cbbReason_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtEndNumber.Focus();
                txtEndNumber.SelectAll();   
            }
        }

        private void cbbReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEndNumber.Focus();
            txtEndNumber.SelectAll();
        }
    }
}
