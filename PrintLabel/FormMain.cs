using LiveCharts.WinForms;
using LiveCharts;
using PrintLabel.Common;
using PrintLabel.Graph;
using PrintLabel.Models;
using PrintLabel.SQLHelper;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZedGraph;
using Axis = LiveCharts.Wpf.Axis;
using System.Windows.Markup;
using System.Threading;
using System.Reflection;
using LiveCharts.Wpf;
using System.Windows.Media;
using LiveCharts.Definitions.Charts;
using System.Windows;

namespace PrintLabel
{
    public partial class FormMain : Form
    {
        DataTable dt;
        USER account;
        BackgroundWorker worker1;
        BackgroundWorker worker2;
        BackgroundWorker worker3;

        PrintHelper printHelper = new PrintHelper();

        public FormMain(USER account)
        {
            InitializeComponent();
            this.account = account;
            worker1 = new BackgroundWorker();
            worker1.DoWork += Worker1_DoWork;

            worker2 = new BackgroundWorker();
            worker2.DoWork += Worker2_DoWork;


            worker3 = new BackgroundWorker();
            worker3.DoWork += Worker3_DoWork;

            dtpFrom.Value = dtpFrom.Value.Date.AddDays(-7);

            //access
            Access();
        }

        private void Access()
        {
            if (AccountHelper.IsReadonly(account))
            {
                var allButtons = GetAllButtons(this).Where(w => w.Name != "btnDatabase");
                foreach (var button in allButtons)
                {
                    button.Enabled = false;
                }
            }
            if (AccountHelper.IsStaff(account))
            {
                var button = GetAllButtons(this).Where(w => w.Name == "btnConfig").FirstOrDefault();
                button.Enabled = false;
            }
        }
        private List<UISymbolButton> GetAllButtons(Control control)
        {
            List<UISymbolButton> buttons = new List<UISymbolButton>();

            foreach (Control c in control.Controls)
            {
                if (c is UISymbolButton)
                {
                    buttons.Add((UISymbolButton)c);
                }
                else if (c.Controls.Count > 0)
                {
                    buttons.AddRange(GetAllButtons(c));
                }
            }

            return buttons;
        }
        private void Worker3_DoWork(object sender, DoWorkEventArgs e)
        {
            if (IsHandleCreated)
            {
                this.BeginInvoke(new Action(() =>
                {
                    panelCirle.Visible = true;
                }));
            }
            ShowGraphCircle();
            this.BeginInvoke(new Action(() =>
            {
                panelCirle.Visible = false;
            }));
        }

        private void ShowGraphCircle()
        {
            var dataNormal = printHelper.GetPrintLog(dtpFrom.Value, dtpTo.Value);
            var dataException = printHelper.GetRePrintLog(dtpFrom.Value, dtpTo.Value);

            GraphPane myPane = graphCircle.GraphPane;

            // Đặt tiêu đề và nhãn
            myPane.Title.Text = "Normal/Exception print report";
            myPane.Title.FontSpec.Size = 24;
            myPane.Legend.IsVisible = true;
            myPane.Legend.FontSpec.Size = 13;
            myPane.Legend.Position = LegendPos.Top;

            // Tạo dữ liệu cho biểu đồ tròn
            string[] labels = { "Normal", "Exception"};
            double[] values = { dataNormal.Count, dataException.Count};

            System.Drawing.Color[] colors = {System.Drawing.Color.Green, System.Drawing.Color.Red };

            // Xóa các phần tử cũ trong biểu đồ
            myPane.CurveList.Clear();

            // Tạo biểu đồ tròn
            for (int i = 0; i < values.Length; i++)
            {
                PieItem pieSlice = myPane.AddPieSlice(values[i], colors[i], 0.2, labels[i]);
                pieSlice.LabelType = PieLabelType.Name_Value_Percent;
                pieSlice.LabelDetail.FontSpec.Size = 15;
                pieSlice.LabelDetail.FontSpec.FontColor = System.Drawing.Color.Black;
                pieSlice.Displacement = 0.1; 
            }

            // Cấu hình thêm cho biểu đồ tròn
            myPane.Fill = new Fill(System.Drawing.Color.White, System.Drawing.Color.LightGray, 45.0f);
            //myPane.Chart.Fill = new Fill(System.Drawing.Color.White, System.Drawing.Color.LightBlue, 45.0f);

            // Làm mới ZedGraphControl
            graphCircle.AxisChange();
            graphCircle.Invalidate();
        }

        private void Worker2_DoWork(object sender, DoWorkEventArgs e)
        {
            ShowGraph();
            this.BeginInvoke(new Action(() =>
            {              
                panelChart.Visible = false;
            }));
        }

        private void ShowGraph()
        {
            #region live chart
            this.BeginInvoke(new Action(() =>
            {
                panelChart.Visible = true;
                graphColumns.Series.Clear();
                graphColumns.AxisX.Clear();
                graphColumns.AxisY.Clear();
            }));
           

            #region data
            var data = printHelper.GetPrintLog(dtpFrom.Value, dtpTo.Value);
            var fromDate = dtpFrom.Value.Date;
            var toDate = dtpTo.Value.Date;
            List<BarChart> BarChartList = new List<BarChart>();
            var data_id_list = data.Select(s => s.DATA_ID).Distinct().ToList();
            while (fromDate <= toDate)
            {

                foreach (var id in data_id_list)
                {
                    BarChart barChart = new BarChart();
                    barChart.ID = id;
                    barChart.Date = fromDate;
                    var qty = GetQty(fromDate, id, data);
                    if (qty <= 0) continue;
                    barChart.Qty = qty;
                    barChart.Model = printHelper.GetMasterData(id).MODEL;
                    BarChartList.Add(barChart);

                }
                fromDate = fromDate.AddDays(1);
            }
            List<BarChart> BarChartNewList = new List<BarChart>();
            var group = BarChartList.GroupBy(g => new { g.Model });
            int indexColor = 1;
            foreach (var item in group)
            {

                int qty = 0;
                foreach (var dt in item)
                {
                    qty += dt.Qty;
                }
                BarChartNewList.Add(new BarChart
                {
                    ID = item.First().ID,
                    Model = item.Key.Model,
                    Date = item.First().Date,
                    Qty = qty,
                    Color = DefineColor.GetColor(indexColor)
                });
                indexColor++;
            }
            #endregion
            this.BeginInvoke(new Action(() =>
            {
                List<ColumnSeries> listColumns = new List<ColumnSeries>();
                foreach (var item in BarChartNewList)
                {
                    var columns = new ColumnSeries
                    {
                        Title = item.Model,
                        Values = new ChartValues<double> { item.Qty },
                        FontSize=12,
                        Fill = new LinearGradientBrush
                        {
                            GradientStops = new GradientStopCollection
                            {
                                new GradientStop(System.Windows.Media.Color.FromRgb(item.Color.B, item.Color.R, item.Color.G), 0),   // Start color
                                new GradientStop(System.Windows.Media.Color.FromRgb(item.Color.B, item.Color.B, item.Color.G), 1) // End color
                            }
                        },
                        DataLabels = true,
                        LabelPoint = point => point.Y.ToString(),
                        MaxColumnWidth = double.NaN,
                        ColumnPadding = 15   // Adjust padding as needed
                    };
                    listColumns.Add(columns);
                }
                var a = graphColumns.Series = new SeriesCollection();
                a.AddRange(listColumns);
            }));
          
            this.BeginInvoke(new Action(() =>
            {
                graphColumns.AxisX.Add(new Axis
                {
                    Title = "",
                    Labels = new[] { "" },
                    FontWeight = FontWeights.Bold
                });

                graphColumns.AxisY.Add(new Axis
                {
                    Title = "Value",
                    LabelFormatter = value => value.ToString("N"),
                    FontSize = 12,
                    FontWeight = FontWeights.Bold
                });

                graphColumns.LegendLocation = LegendLocation.Top;
                graphColumns.DefaultLegend.FontSize = 13;

                // Disable tooltips
                //graphColumns.DataTooltip = null;
                // Enable zooming and panning
                graphColumns.Zoom = ZoomingOptions.X;
                graphColumns.Pan = PanningOptions.X;
                graphColumns.UpdaterTick += GraphColumns_UpdaterTick; ;
            }));
            #endregion
            #region zedgraph
            //this.BeginInvoke(new Action(() =>
            //{
            //    panelChart.Visible = true;
            //}));
            //var data = printHelper.GetPrintLog(dtpFrom.Value, dtpTo.Value);
            //GraphPane myPane = graphColumns.GraphPane;

            //myPane.CurveList.Clear();
            //// Đặt tiêu đề và nhãn trục
            //myPane.Title.Text = "Print normal daily report";
            //myPane.XAxis.Title.Text = $"Data form {dtpFrom.Value.Date.ToString("dd/MM/yyyy")} -> {dtpTo.Value.Date.ToString("dd/MM/yyyy")}";
            //myPane.YAxis.Title.Text = "Value";
            //// setting
            //var fromDate = dtpFrom.Value.Date;
            //var toDate = dtpTo.Value.Date;
            //List<BarChart> BarChartList = new List<BarChart>();
            //var data_id_list = data.Select(s => s.DATA_ID).Distinct().ToList();


            //while (fromDate <= toDate)
            //{

            //    foreach (var id in data_id_list)
            //    {
            //        BarChart barChart = new BarChart();
            //        barChart.ID = id;
            //        barChart.Date = fromDate;
            //        var qty = GetQty(fromDate, id, data);
            //        if (qty <= 0) continue;
            //        barChart.Qty = qty;
            //        barChart.Model = printHelper.GetMasterData(id).MODEL;
            //        BarChartList.Add(barChart);

            //    }
            //    fromDate = fromDate.AddDays(1);
            //}
            //List<BarChart> BarChartNewList = new List<BarChart>();
            //var group = BarChartList.GroupBy(g => new { g.Model });
            //int indexColor = 1;
            //foreach (var item in group)
            //{

            //    int qty = 0;
            //    foreach (var dt in item)
            //    {
            //        qty += dt.Qty;
            //    }
            //    BarChartNewList.Add(new BarChart
            //    {
            //        ID = item.First().ID,
            //        Model = item.Key.Model,
            //        Date = item.First().Date,
            //        Qty = qty,
            //        Color = DefineColor.GetColor(indexColor)
            //    });
            //    indexColor++;
            //}
            //List<double> values = BarChartNewList.Select(s => (double)s.Qty).ToList();
            //// Tạo từng cột riêng biệt với màu sắc khác nhau
            //for (int i = 0; i < values.Count; i++)
            //{
            //    double[] x = { (double)i + 1 };
            //    double[] y = { values[i] };
            //    BarItem bar = myPane.AddBar(BarChartNewList[i].Model, x, y, BarChartNewList[i].Color);
            //}
            //// Đặt các nhãn trục X nằm ngang
            //myPane.XAxis.Scale.IsSkipFirstLabel = false; // Hiển thị tất cả các nhãn
            //myPane.XAxis.Scale.FontSpec.Angle = 0; // Góc xoay của nhãn
            //myPane.XAxis.Type = ZedGraph.AxisType.Text;
            //myPane.XAxis.Scale.FontSpec.Size = 12;

            //// Cập nhật biểu đồ
            //graphColumns.AxisChange();
            //graphColumns.Invalidate();


            ///////////////////////////////////////-----------------..........////////////
            //foreach (var item in BarChartNewList)
            //{
            //    //var bar = myPane.AddBar(item.Model, null, values.ToArray(), item.Color);
            //    //var point = bar.Points;
            //    //TextObj text = new TextObj(item.Qty.ToString(), point[0].X, point[0].Y);
            //    //text.FontSpec.Size = 12;
            //    //text.FontSpec.FontColor = System.Drawing.Color.Black; // Màu chữ
            //    //text.Location.AlignH = AlignH.Center; // Căn giữa ngang
            //    //text.Location.AlignV = AlignV.Top; // Căn giữa dọc
            //    //myPane.GraphObjList.Add(text);
            //}
            //foreach(var item in BarChartNewList)
            //{
            //    var bar = myPane.AddBar(item.Model,null , new[] { (double)item.Qty}, item.Color);
            //    var point = bar.Points;
            //    TextObj text = new TextObj(item.Qty.ToString(), point[0].X, point[0].Y);
            //    text.FontSpec.Size = 12;
            //    text.FontSpec.FontColor = System.Drawing.Color.Black; // Màu chữ
            //    text.Location.AlignH = AlignH.Center; // Căn giữa ngang
            //    text.Location.AlignV = AlignV.Top; // Căn giữa dọc
            //    myPane.GraphObjList.Add(text);
            //}
            // Hiển thị giá trị của mỗi cột
            //for (int i = 0; i < BarChartNewList.Count; i++)
            //{
            //    TextObj text = new TextObj(BarChartNewList[i].Qty.ToString(), i + 1, BarChartNewList[i].Qty);
            //    text.FontSpec.Size = 12; // Kích thước font
            //    text.FontSpec.FontColor = System.Drawing.Color.Black; // Màu chữ
            //    text.Location.AlignH = AlignH.Center; // Căn giữa ngang
            //    text.Location.AlignV = AlignV.Top; // Căn giữa dọc
            //    myPane.GraphObjList.Add(text);
            //}
            //List<BarChart> BarChartNewList = new List<BarChart>();
            //var group = BarChartList.GroupBy(g => new { g.Model, g.Date });
            //int indexColor = 1;
            //foreach (var item in group)
            //{

            //    int qty = 0;
            //    foreach (var dt in item)
            //    {
            //        qty += dt.Qty;
            //    }
            //    BarChartNewList.Add(new BarChart
            //    {
            //        ID = item.First().ID,
            //        Model = item.Key.Model,
            //        Date = item.Key.Date,
            //        Qty = qty,
            //        Color = DefineColor.GetColor(indexColor)
            //    });
            //    indexColor++;
            //}

            //var modelList = BarChartNewList.Select(s => s.Model).Distinct().ToList();
            //var dayList = BarChartNewList.Select(s => s.Date).Distinct().ToList();

            //for (int i = 0; i < modelList.Count; i++)
            //{
            //    List<double> values = new List<double>();

            //    var datas = BarChartNewList.Where(w => w.Date == dayList[i]).ToList();
            //    foreach (var d in datas)
            //    {
            //        values.Add(d.Qty);
            //    }



            //    myPane.AddBar(modelList[i], null, values.ToArray(), GetColor(modelList[i],BarChartNewList));
            //}
            #endregion
        }

        private void GraphColumns_UpdaterTick(object sender)
        {
            foreach (var series in graphColumns.Series)
            {
                if (series is ColumnSeries columnSeries)
                {
                    columnSeries.MaxColumnWidth = double.NaN; // Set to NaN to auto-scale
                }
            }
        }

        private System.Drawing.Color GetColor(string model, List<BarChart> barChartNewList)
        {
            return barChartNewList.Where(w=>w.Model == model).Select(s=>s.Color).FirstOrDefault();
        }

        private int GetQty(DateTime date, Guid? id, List<PRINT_DATA_LOG> data)
        {
            return data.Where(w=>w.DATA_ID == id && w.UPD_TIME.Value.Year == date.Year && w.UPD_TIME.Value.Month == date.Month && w.UPD_TIME.Value.Date == date.Date).Count();
        }

        private void Worker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ShowReportData();         
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lbUser.Text = account.FULLNAME;
            if (this.IsHandleCreated)
            {
                if (!worker1.IsBusy)
                {
                    worker1.RunWorkerAsync();
                }
                if (!worker2.IsBusy)
                {
                    worker2.RunWorkerAsync();
                }
                if (!worker3.IsBusy)
                {
                    worker3.RunWorkerAsync();
                }
                process1.Start();
                process2.Start();
            }
          
        }

        private void ShowReportData()
        {
            var isNormal = cbNormal.Checked;
            var dt = printHelper.GetLogData(dtpFrom.Value.Date, dtpTo.Value.Date, isNormal);

            this.BeginInvoke(new Action(() =>
            {
                dgvReport.DataSource = dt;
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }));
        }

        private void btnPrintBody_Click(object sender, EventArgs e)
        {
            new FormPrinter(CONSTANT.PRINT_BODY_TYPE, account.FULLNAME).ShowDialog();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (!worker1.IsBusy)
            {
                worker1.RunWorkerAsync();
            }
            if (!worker2.IsBusy)
            {
                worker2.RunWorkerAsync();
            }
            if (!worker3.IsBusy)
            {
                worker3.RunWorkerAsync();
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            //using (FormModal modal = new FormModal())
            //{
            //    modal.Show();
            //    using (FormConfigPath f = new FormConfigPath())
            //    {
            //        f.StartPosition = FormStartPosition.CenterParent;
            //        f.ShowDialog(modal);
            //    }
            //}
            using (FormConfigPath f = new FormConfigPath())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();
            }
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            new FormDatabase().ShowDialog();
        }

        private void cbNormal_ValueChanged(object sender, bool value)
        {
            if (!worker1.IsBusy)
            {
                worker1.RunWorkerAsync();
            }
            if (!worker2.IsBusy)
            {
                worker2.RunWorkerAsync();
            }
            if (!worker3.IsBusy)
            {
                worker3.RunWorkerAsync();
            }
        }

        private void btnPrintRating_Click(object sender, EventArgs e)
        {
            new FormPrinter(CONSTANT.PRINT_RATING_TYPE, account.FULLNAME).ShowDialog();
        }

        private void btnPrintOuterBox_Click(object sender, EventArgs e)
        {
            new FormPrinter(CONSTANT.PRINT_OUTERBOX_TYPE, account.FULLNAME).ShowDialog();
        }
    }
}
