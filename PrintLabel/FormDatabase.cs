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
    public partial class FormDatabase : Form
    {
        BackgroundWorker worker;
        PrintHelper printHelper = new PrintHelper();
        public FormDatabase()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable data = printHelper.GetMasterData(txtSearch.Text);
            this.BeginInvoke(new Action(() =>
            {
                dgvDatabase.DataSource = data;
                dgvDatabase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }));
        }

        private void FormDatabase_Load(object sender, EventArgs e)
        {
            if(AccountHelper.Account.TYPE == 3)
            {
                btnAdd.Enabled = false;
                context.Enabled = false;
            }
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormInsertModel().ShowDialog();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            btnSearch_Click(null,null);
        }
    }
}
