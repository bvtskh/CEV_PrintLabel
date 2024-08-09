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
using System.Windows.Media;
using static PrintLabel.Common.CONSTANT;

namespace PrintLabel
{
    public partial class FormInsertModel : Form
    {
        PrintHelper PrintHelper = new PrintHelper();
        ModelSetting setting;
        DataGridViewRow row;

        public FormInsertModel(ModelSetting modelSetting, DataGridViewRow selectRow = null)
        {
            InitializeComponent();
            cbbModel.Font = new Font("Arial", 12, FontStyle.Bold);
            cbbPrintType.Font = new Font("Arial", 12, FontStyle.Bold);
            this.setting = modelSetting;
            this.row = selectRow;
        }

        private void FormInsertModel_Load(object sender, EventArgs e)
        {
            
            if(setting == ModelSetting.Insert)
            {
                lbTitle.Text = "Thêm mới model";
                var model = PrintHelper.GetAllModel();
                cbbModel.Items.AddRange(model.ToArray());
                var print = PrintHelper.GetAllPrintType();
                cbbPrintType.Items.AddRange(print.ToArray());
            }
            else
            {
                lbTitle.Text = "Sửa model";
                cbbModel.Text = row.Cells[0].Value?.ToString();
                cbbModel.Enabled = false;
                txtCell.Text = row.Cells[1].Value?.ToString();
                txtCell.Enabled = false;

                txtDest.Text = row.Cells[2].Value?.ToString();
                txtDest.Enabled = false;

                txtStartcode.Text = row.Cells[3].Value?.ToString();

                txtNumber.Text = row.Cells[4].Value?.ToString();
                txtNumber.Enabled = false;

                cbbPrintType.Text = row.Cells[5].Value?.ToString();
                cbbPrintType.Enabled = false;

                txtBartender.Text = row.Cells[8].Value?.ToString();
                txtDatabase.Text = row.Cells[9].Value?.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbbModel.Text) || string.IsNullOrEmpty(cbbPrintType.Text) || string.IsNullOrEmpty(txtCell.Text)
                || string.IsNullOrEmpty(txtDest.Text) || string.IsNullOrEmpty(txtNumber.Text) || string.IsNullOrEmpty(txtStartcode.Text))
            {
                UIMessageTip.ShowWarning("Hãy điền đầy đủ thông tin bắt buộc!");
                return;
            }
            if(setting == ModelSetting.Insert)
            {
                if (PrintHelper.InsertNewModel(cbbModel.Text, cbbPrintType.Text, txtCell.Text, txtDest.Text, txtNumber.Text, txtStartcode.Text, txtBartender.Text, txtDatabase.Text))
                {
                    UIMessageTip.ShowOk("Đã thêm mới thành công!",2000);
                }
                else
                {
                    UIMessageTip.ShowError("Không thành công!", 2000);
                }
            }
            else
            {
                if (PrintHelper.UpdateModel(cbbModel.Text, cbbPrintType.Text, txtCell.Text, txtDest.Text, txtBartender.Text, txtDatabase.Text, txtStartcode.Text))
                {
                    UIMessageTip.ShowOk("Đã cập nhật thành công!",2000);
                }
                else
                {
                    UIMessageTip.ShowError("Không thành công!", 2000);
                }
            }
            this.Close();
        }

        private void btnOpenBar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Text files (*.btw)|*.btw|All files (*.*)|*.*";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtBartender.Text = open.FileName;
                }
            }
        }

        private void btnOpenDb_Click(object sender, EventArgs e)
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

        private void FormInsertModel_Shown(object sender, EventArgs e)
        {
            txtStartcode.Focus();
            txtStartcode.SelectAll();
        }
    }
}
