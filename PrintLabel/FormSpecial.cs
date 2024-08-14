using PrintLabel.SQLHelper;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintLabel
{
    public partial class FormSpecial : Form
    {
        DataGridViewRow selectRow;
        PrintHelper printHelper = new PrintHelper();
        public FormSpecial(DataGridViewRow selectRow)
        {
            InitializeComponent();
            this.selectRow = selectRow;
        }

        private void FormSpecial_Load(object sender, EventArgs e)
        {
            var print = printHelper.GetAllPrintType();
            cbbPrintType.Items.AddRange(print.ToArray());
            txtModel.Text = selectRow.Cells[0].Value?.ToString();
            txtModel.ReadOnly = true;
            txtCell.Text = selectRow.Cells[1].Value?.ToString();
            txtCell.ReadOnly = true;
            txtDest.Text = selectRow.Cells[2].Value?.ToString();
            txtDest.ReadOnly = true;
            txtStartcode.Text = selectRow.Cells[3].Value?.ToString();

            txtNumber.Text = selectRow.Cells[4].Value?.ToString();

            cbbPrintType.Text = selectRow.Cells[5].Value?.ToString();
            cbbPrintType.ReadOnly = true;
            txtBartender.Text = selectRow.Cells[8].Value?.ToString();
            txtDatabase.Text = selectRow.Cells[9].Value?.ToString();

            var data = printHelper.GetMasterData(txtModel.Text, txtCell.Text, (int)printHelper.GetPrintType(cbbPrintType.Text), txtDest.Text);
            txtprintedTotal.Text = printHelper.GetPrintUpdateData(data.ID).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int totalPrinted = Common.Common.ConvertDefaultINT(txtprintedTotal.Text);
            int charNumber = Common.Common.ConvertDefaultINT(txtNumber.Text);
            if (printHelper.UpdateModel(txtModel.Text, cbbPrintType.Text, txtCell.Text, txtDest.Text, txtBartender.Text, txtDatabase.Text, txtStartcode.Text, charNumber, totalPrinted))
            {
                UIMessageTip.ShowOk("Đã cập nhật thành công!", 2000);
                this.Close();
            }
            else
            {
                UIMessageTip.ShowError("Không thành công!", 2000);
            }
        }
    }
}
