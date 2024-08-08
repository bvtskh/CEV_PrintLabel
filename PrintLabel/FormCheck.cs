using PrintLabel.SQLHelper;
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
    public partial class FormCheck : Form
    {
        PrintHelper PrintHelper = new PrintHelper();
        string des;
        public int printType;
        string model;
        string cell;

        public bool SUCCESS = false;


        public FormCheck(string des, int printType, string model, string cell)
        {
            InitializeComponent();
            this.des = des;
            this.printType = printType;
            this.model = model;
            this.cell = cell;

            this.KeyPreview = true; // Bắt sự kiện bàn phím trước khi đến các control khác
            this.KeyDown += new KeyEventHandler(DialogForm_KeyDown);
        }

        private void DialogForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn chặn sự kiện Enter thực hiện các hành động mặc định
                SUCCESS = true;
                this.Close();
            }
        }

        private void FormCheck_Load(object sender, EventArgs e)
        {
            if (des != null)
            {
                var data = PrintHelper.GetMasterData(model, cell, printType, des);
                if(data != null)
                {
                    txtDes.Text = data.DEST;
                    txtRule.Text =data.START_CODE;
                }
            }
            btnApproval.Focus();
        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            SUCCESS = true;
            this.Close();
        }
    }
}
