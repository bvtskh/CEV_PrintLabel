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
    public partial class FormModal : Form
    {
        public FormModal()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Opacity = 0.7; // Độ mờ 50%
            this.StartPosition = FormStartPosition.Manual;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }
    }
}
