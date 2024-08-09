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
using static PrintLabel.Common.CONSTANT;

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
            if(!AccountHelper.IsAdmin())           
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
            new FormInsertModel(ModelSetting.Insert).ShowDialog();
            btnSearch_Click(null, null);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            btnSearch_Click(null,null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectRow != null)
            {
                new FormInsertModel(ModelSetting.Update,selectRow).ShowDialog();
                btnSearch_Click(null, null);
            }
        }

        DataGridViewRow selectRow;
        private void dgvDatabase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex>=0)
            {
                selectRow = dgvDatabase.Rows[e.RowIndex];
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(selectRow != null)
            {
                if(MessageBox.Show("Bạn có chắc muốn xóa model này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (printHelper.DeleteModel(selectRow))
                    {
                        UIMessageTip.ShowError("Đã xóa thành công!");
                    }
                    else
                    {
                        UIMessageTip.ShowError("Không thành công!");
                    }
                    btnSearch_Click(null, null);
                }
            }
        }
    }
}
