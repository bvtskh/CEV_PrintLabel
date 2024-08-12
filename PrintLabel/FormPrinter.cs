using Sunny.UI.Win32;
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
using PrintLabel.SQLHelper;
using PrintLabel.Common;
using PrintLabel.Models;
using System.Security.Cryptography;
using System.Net;

namespace PrintLabel
{
    public partial class FormPrinter : Form
    {
        PrintHelper PrintHelper = new PrintHelper();
        ExcelHelper ExcelHelper = new ExcelHelper();
        int printType;
        string account;
        BackgroundWorker workerUpdateEndBody;
        Timer Timer1;

        MASTER_DATA data;
        DataGridViewRow selectRow;
        public FormPrinter(int printType, string account)
        {
            InitializeComponent();
            cbbModel.Font = new Font("Arial", 12, FontStyle.Bold);
            cbbCell.Font = new Font("Arial", 12, FontStyle.Bold);
            this.printType = printType;
            this.account = account;

            workerUpdateEndBody = new BackgroundWorker();
            workerUpdateEndBody.DoWork += WorkerUpdateEndBody_DoWork;

            Timer1 = new Timer();
            Timer1.Tick += Timer1_Tick;

            txtPrinter.Text = account;  
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (workerUpdateEndBody.IsBusy) return;
            workerUpdateEndBody.RunWorkerAsync();
        }

        private void WorkerUpdateEndBody_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.BeginInvoke(new Action(() =>
                {
                    var index = Common.Common.ConvertDefaultINT(txtNumberLastPrint.Text);
                    var printNumber = Common.Common.ConvertDefaultINT(txtPrintNumbers.Text);
                    var sum = index + printNumber - 1;
                    if (selectRow != null)
                    {
                        var des = selectRow.Cells[0].Value?.ToString();
                        var data = PrintHelper.GetMasterData(cbbModel.Text, cbbCell.Text, printType, des);
                        if (data != null)
                        {
                            var end = sum.ToString().PadLeft((int)data.CHAR_NUMBER - data.START_CODE.Length, '0');
                            txtEndBodyNo.Text = txtStartBodyNo.Text + end;
                            if(printNumber <= 0)
                            {
                                txtEndBodyNo.Text = "";
                            }
                        }
                    }
                }));
            }
            catch (Exception)
            {
                return;
            }
            
        }

        [Obsolete]
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1.Start();
            try
            {
                var modelList = PrintHelper.GetAllModel(printType);
                cbbModel.Items.AddRange(modelList.ToArray());
                //ExcelHelper.InsertDataSheet3();
                //ExcelHelper.InsertDataSheet2();
                //ExcelHelper.InsertDataSheet1();

                lbPrintType.Text = $"PRINT {PrintHelper.GetPrintType(printType)}".ToUpper();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtPrintNumbers_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var printNumber = Common.Common.ConvertDefaultINT(txtPrintNumbers.Text);

                if (string.IsNullOrEmpty(txtChecker.Text))
                {
                    UIMessageTip.ShowError("Nhập checker!", 2000);
                        txtChecker.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPart.Text))
                {
                    UIMessageTip.ShowError("Nhập mã phôi!", 2000);
                        txtPart.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPrintNumbers.Text) || printNumber <= 0)
                {
                    UIMessageTip.ShowError("Số lượng in không đúng!", 2000);
                        txtPrintNumbers.Focus();
                        txtPrintNumbers.SelectAll();
                    return;
                }
                using (FormLoading form = new FormLoading(PrintLabel))
                {
                    form.ShowDialog(this);                   
                }
            }
        }

        private void PrintLabel()
        {
            FileStream FILEDATA = new FileStream(data.DATABASE_PATH, FileMode.Create);
            TextWriter writer = new StreamWriter(FILEDATA);

            List<string> barcodeList = new List<string>();
            for (int i = 0; i < Int64.Parse(txtPrintNumbers.Text); i++)
            {
                long index = Common.Common.ConvertDefaultINT(txtNumberLastPrint.Text);

                var end = (index + i).ToString().PadLeft((int)data.CHAR_NUMBER - data.START_CODE.Length, '0');
                string barcode = txtStartBodyNo.Text + end;
                writer.Write(barcode);
                writer.WriteLine();
                barcodeList.Add(barcode);
            }

            writer.Close();

            // save log

            if (PrintHelper.SaveAndUpdateLog(data, Common.Common.ConvertDefaultINT(txtPrintNumbers.Text), barcodeList, account,txtChecker.Text,txtPart.Text))
            {
                var des = selectRow.Cells[0].Value?.ToString();
                this.BeginInvoke(new Action(() =>
                {
                    ShowInfoPrint(des);
                }));

                // print
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

        private void cbbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbCell.Items.Clear();
            dgvDes.Rows.Clear();
            if (cbbModel.SelectedIndex != -1)
            {
                var value = cbbModel.SelectedItem as string;
                var cell = PrintHelper.GetCell(value);
                cbbCell.Items.AddRange(cell.ToArray());
            }
        }

        private void cbbCell_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDes.Rows.Clear();
            if (cbbModel.SelectedIndex != -1 && cbbCell.SelectedIndex != -1)
            {
                var model = cbbModel.SelectedItem as string;
                var cell = cbbCell.SelectedItem as string;
                var data = PrintHelper.GetMasterData(model, cell, printType).OrderBy(o=>o.DEST);
                foreach (var item in data)
                {
                    var row = dgvDes.Rows.Add();
                    dgvDes.Rows[row].Cells[0].Value = item.DEST;
                }
            }
        }

        private void dgvDes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.ColumnIndex >=0)
            {
                selectRow = dgvDes.Rows [e.RowIndex];
                var des = dgvDes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                if (des != null)
                {
                    ShowInfoPrint(des);
                    //using (FormModal modal = new FormModal())
                    //{
                    //    modal.Show();
                    //    using (FormCheck f = new FormCheck(des, printType, cbbModel.Text, cbbCell.Text))
                    //    {
                    //        f.StartPosition = FormStartPosition.CenterParent;
                    //        f.ShowDialog(modal);
                    //        if (f.SUCCESS)
                    //        {
                    //            ShowInfoPrint(des);
                    //        }
                    //    }
                    //}                                 
                }
            }

        }

        private void ShowInfoPrint(string des)
        {
            data = PrintHelper.GetMasterData(cbbModel.Text, cbbCell.Text, printType, des);
            if (data != null)
            {
                txtStartBodyNo.Text = data.START_CODE;
                txtNumberLastPrint.Text = ((PrintHelper.GetPrintUpdateData(data.ID) +1)?.ToString()).PadLeft((int)data.CHAR_NUMBER - data.START_CODE.Length, '0');//Total Printed
                lbCharNumber.Text = $"Char number: {data.CHAR_NUMBER}";

                txtPathFile.Text = data.PRINT_PATH;
                if (!string.IsNullOrEmpty(data.PRINT_PATH))
                {
                    foreach (var item in panelSystem.Controls.OfType<UITextBox>())
                    {
                        item.Enabled = true;
                        lbAlarm.Text = "";
                        txtChecker.Focus();
                        txtChecker.SelectAll();
                    }
                }
                else
                {
                    foreach (var item in panelSystem.Controls.OfType<UITextBox>())
                    {
                        item.Enabled = false;
                    }
                    lbAlarm.Text = $"Model {cbbModel.Text} chưa cài đặt đường dẫn đến file in!";
                }
            }
        }

        private void txtClick_Click(object sender, EventArgs e)
        {
            UITextBox uITextBox = (UITextBox)sender;
            if (uITextBox != null)
            {
                uITextBox.Focus();
                uITextBox.SelectAll();
            }   
        }

        private void btnException_Click(object sender, EventArgs e)
        {
            if(data == null)
            {
                UIMessageTip.ShowWarning("Vui lòng kiểm tra Model, Cell, Thị trường!");
                return;
            }
            if(string.IsNullOrEmpty(data.PRINT_PATH) || string.IsNullOrEmpty(data.DATABASE_PATH))
            {
                UIMessageTip.ShowWarning($"Model {data.MODEL} chưa được cài đặt đường dẫn đến file in!",2000);
                return;
            }
            //using (FormModal modal = new FormModal())
            //{
            //    modal.Show();
            //    using (FormReprint f = new FormReprint(data, account, printType))
            //    {
            //        f.StartPosition = FormStartPosition.CenterParent;
            //        f.ShowDialog(modal);
            //    }
            //}
            //using (FormReprint f = new FormReprint(data, account, printType))
            //{
            //    f.StartPosition = FormStartPosition.CenterParent;
            //    f.ShowDialog();
            //}

            using (FormReprint1 f = new FormReprint1(data, account, printType))
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var printNumber = Common.Common.ConvertDefaultINT(txtPrintNumbers.Text);
            for (int i = 0; i < Int64.Parse(txtPrintNumbers.Text); i++)
            {
                long index = Common.Common.ConvertDefaultINT(txtNumberLastPrint.Text);

                var end = (index + i).ToString().PadLeft((int)data.CHAR_NUMBER - data.START_CODE.Length, '0');
                string barcode = txtStartBodyNo.Text + end;
            }
        }

        private void btnFixbartender_Click(object sender, EventArgs e)
        {
            new FormConfirm().ShowDialog();
        }

        private void txtChecker_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPart.Focus();
                txtPart.SelectAll();
            }
        }

        private void txtPart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrintNumbers.Focus();
                txtPrintNumbers.SelectAll();
            }
        }
    }
}
