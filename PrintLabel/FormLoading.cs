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
    public partial class FormLoading : Form
    {
        public Action Worker { get; set; }
        public FormLoading(Action worker)
        {
            InitializeComponent();
            if (worker == null)
            {
                throw new ArgumentNullException();
            }
            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            System.Threading.Tasks.Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        //private async void FormLoading_Load(object sender, EventArgs e)
        //{
        //    await RunTaskAsync();
        //    this.Close();
        //}

        //private Task RunTaskAsync()
        //{
        //    return Task.Run(() =>
        //    {
        //        Worker();
        //    });
        //}
    }
}
