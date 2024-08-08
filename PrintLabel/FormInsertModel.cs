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

namespace PrintLabel
{
    public partial class FormInsertModel : Form
    {
        PrintHelper PrintHelper = new PrintHelper();
        public FormInsertModel()
        {
            InitializeComponent();
            cbbModel.Font = new Font("Arial", 12, FontStyle.Bold);
            cbbPrintType.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void FormInsertModel_Load(object sender, EventArgs e)
        {
            var model = PrintHelper.GetAllModel();
            cbbModel.Items.AddRange(model.ToArray());
            var print = PrintHelper.GetAllPrintType();
            cbbPrintType.Items.AddRange(print.ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbbModel.Text) || string.IsNullOrEmpty(cbbPrintType.Text) || string.IsNullOrEmpty(txtCell.Text)
                || string.IsNullOrEmpty(txtDest.Text) || string.IsNullOrEmpty(txtNumber.Text) || string.IsNullOrEmpty(txtStartcode.Text))
            {
                UIMessageTip.ShowWarning("Hãy điền đầy đủ thông tin bắt buộc!");
                return;
            }
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
    }
}
