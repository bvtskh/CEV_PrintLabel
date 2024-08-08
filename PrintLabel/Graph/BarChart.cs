using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabel.Graph
{
    public class BarChart
    {
        public DateTime Date {  get; set; }
        public Guid? ID { get; set; }       
        public int Qty { get; set; }
        public string Model { get; set; } 
        public Color Color { get; set; }
    }
}
