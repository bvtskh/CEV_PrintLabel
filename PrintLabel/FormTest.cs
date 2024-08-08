using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace PrintLabel
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

            List<string> list = new List<string> { "John", "Alex", "Lyly" };
            foreach (string s in list)
            {
                cartesianChart1.Series = new SeriesCollection{
                new ColumnSeries
                {
                    Title = s,
                    Values = new ChartValues<double>{10},
                }
            };
            }

            //ColumnSeries columnSeries1  = new ColumnSeries{
            //    Title = "John",
            //    Values = new ChartValues<double> { 9 },
            //    Fill = new LinearGradientBrush
            //    {
            //        GradientStops = new GradientStopCollection
            //            {
            //                new GradientStop(Color.FromRgb(255, 0, 0), 0),   // Start color
            //                new GradientStop(Color.FromRgb(255, 150, 150), 1) // End color
            //            }
            //    },
            //    DataLabels = true,
            //    LabelPoint = point => point.Y.ToString(),
            //    MaxColumnWidth = 50, // Adjust width as needed
            //    ColumnPadding = 10   // Adjust padding as needed
            //};

            //ColumnSeries columnSeries2 = new ColumnSeries
            //{
            //    Title = "Alex",
            //    Values = new ChartValues<double> { 8 },
            //    Fill = new LinearGradientBrush
            //    {
            //        GradientStops = new GradientStopCollection
            //            {
            //                new GradientStop(Color.FromRgb(0, 255, 0), 0),   // Start color
            //                new GradientStop(Color.FromRgb(150, 255, 150), 1) // End color
            //            }
            //    },
            //    DataLabels = true,
            //    LabelPoint = point => point.Y.ToString(),
            //    MaxColumnWidth = 50, // Adjust width as needed
            //    ColumnPadding = 10   // Adjust padding as needed
            //};

            //ColumnSeries columnSeries3 = new ColumnSeries
            //{
            //    Title = "Lyly",
            //    Values = new ChartValues<double> { 10 },
            //    Fill = new LinearGradientBrush
            //    {
            //        GradientStops = new GradientStopCollection
            //            {
            //                new GradientStop(Color.FromRgb(0, 0, 255), 0),   // Start color
            //                new GradientStop(Color.FromRgb(150, 150, 255), 1) // End color
            //            }
            //    },
            //    DataLabels = true,
            //    LabelPoint = point => point.Y.ToString(),
            //    MaxColumnWidth = 50, // Adjust width as needed
            //    ColumnPadding = 10  // Adjust padding as needed
            //};
            //cartesianChart1.Series = new SeriesCollection{
            //    columnSeries1, columnSeries2, columnSeries3
            //};
            //cartesianChart1.Series = new SeriesCollection
            //{
            //    new ColumnSeries
            //    {

            //    },
            //    new ColumnSeries
            //    {

            //    },
            //    new ColumnSeries
            //    {

            //    }
            //};

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Students",
                Labels = new[] { "" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Scores",
                LabelFormatter = value => value.ToString("N")
            });

            cartesianChart1.LegendLocation = LegendLocation.Top;

            // Disable tooltips
            cartesianChart1.DataTooltip = null;
        }
    }
}
