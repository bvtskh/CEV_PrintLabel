using PrintLabel.Common;
using PrintLabel.Models;
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
    public partial class FormSelectPrintType : Form
    {
        string account;
        public FormSelectPrintType(string account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void btnBody_Click(object sender, EventArgs e)
        {
            //using(var db = new DBContext())
            //{
            //    var name = "Body";
            //    var type = 1;
            //    var id = Guid.NewGuid();
            //    var path = "C:\\DATA\\PrintDB.btw";
            //    PRINT_TYPE pRINT_TYPE = new PRINT_TYPE();
            //    pRINT_TYPE.ID = id;
            //    pRINT_TYPE.PRINT_NAME = name;
            //    pRINT_TYPE.PRINT_TYPE1 = type;
            //    pRINT_TYPE.PATH = path;
            //    db.PRINT_TYPE.Add(pRINT_TYPE);
            //    db.SaveChanges();
            //}
            this.Hide();
            new FormPrinter(CONSTANT.PRINT_BODY_TYPE, account).ShowDialog();
            this.Close();
        }
    }
}
