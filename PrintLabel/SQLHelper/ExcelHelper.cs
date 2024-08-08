using MiniExcelLibs;
using PrintLabel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintLabel.SQLHelper
{
    public class ExcelHelper
    {
        [Obsolete]
        internal void InsertDataSheet2()
        {
            var path = @"C:\Users\HP\Desktop\Thanh\3.PrintLabel\database.xlsx";
            var data = MiniExcel.QueryAsDataTable(path, false,"Sheet2");
            using (var db = new DBContext())
            {
                for (int i = 1; i < data.Rows.Count; i++)
                {
                    var model = data.Rows[i][0].ToString();
                    var des = data.Rows[i][1].ToString();
                    var number = data.Rows[i][2].ToString();
                    int cellNum = 1;
                    for (int j = 3; j < data.Columns.Count; j++)
                    {
                        var start = data.Rows[i][j].ToString();
                        if (string.IsNullOrEmpty(start)) continue;
                        var type = 1;
                        MASTER_DATA item = new MASTER_DATA();
                        item.ID = Guid.NewGuid();
                        item.MODEL = model;
                        item.CELL = cellNum.ToString().PadLeft(2, '0');
                        item.START_CODE = start;
                        item.DEST = des;
                        item.CHAR_NUMBER = ConvertINT(number);
                        item.PRINT_TYPE = type;
                        item.UPD_TIME = DateTime.Now;
                        item.USER_UPDATE = "Thành";
                        db.MASTER_DATA.Add(item);
                        db.SaveChanges();

                        cellNum++;
                    }
                }
            }
        }

        [Obsolete]
        internal void InsertDataSheet3()
        {
            var path = @"C:\Users\HP\Desktop\Thanh\3.PrintLabel\database.xlsx";
            
            var data = MiniExcel.QueryAsDataTable(path, false, "Sheet3");
            using (var db = new DBContext())
            {
                for (int i = 2; i < data.Rows.Count; i++)
                {
                    var model = data.Rows[i][0].ToString();
                    string des = "";
                    string start = "";
                    if (!string.IsNullOrEmpty(data.Rows[i][1].ToString()))
                    {
                        des = data.Rows[i][3].ToString()+"-base";
                        start = data.Rows[i][1].ToString();
                        var number = data.Rows[i][4].ToString();
                        string cellNum = "01";


                        var type = 1;
                        MASTER_DATA item = new MASTER_DATA();
                        item.ID = Guid.NewGuid();
                        item.MODEL = model;
                        item.CELL = cellNum;
                        item.START_CODE = start;
                        item.DEST = des;
                        item.CHAR_NUMBER = ConvertINT(number);
                        item.PRINT_TYPE = type;
                        item.UPD_TIME = DateTime.Now;
                        item.USER_UPDATE = "Thành";
                        db.MASTER_DATA.Add(item);
                        db.SaveChanges();

                    }
                    if (!string.IsNullOrEmpty(data.Rows[i][5].ToString()))
                    {
                        des = data.Rows[i][3].ToString() + "-head";
                        start = data.Rows[i][5].ToString();
                        var number = data.Rows[i][4].ToString();
                        string cellNum = "01";


                        var type = 1;
                        MASTER_DATA item = new MASTER_DATA();
                        item.ID = Guid.NewGuid();
                        item.MODEL = model;
                        item.CELL = cellNum;
                        item.START_CODE = start;
                        item.DEST = des;
                        item.CHAR_NUMBER = ConvertINT(number);
                        item.PRINT_TYPE = type;
                        item.UPD_TIME = DateTime.Now;
                        item.USER_UPDATE = "Thành";
                        db.MASTER_DATA.Add(item);
                        db.SaveChanges();

                    }
                }
            }
        }

        [Obsolete]
        internal void InsertDataSheet1()
        {
            var path = @"C:\Users\HP\Desktop\Thanh\3.PrintLabel\database.xlsx";

            var data = MiniExcel.QueryAsDataTable(path, false, "Sheet1");
            using (var db = new DBContext())
            {
                for (int i = 1; i < data.Rows.Count; i++)
                {
                    var model = data.Rows[i][0].ToString();
                    string des = data.Rows[i][1].ToString();
                    string start = data.Rows[i][3].ToString();
                    var number = data.Rows[i][2].ToString();
                    string cellNum = "01";
                    var type = ConvertINT(data.Rows[i][4].ToString());
                    MASTER_DATA item = new MASTER_DATA();
                    item.ID = Guid.NewGuid();
                    item.MODEL = model;
                    item.CELL = cellNum;
                    item.START_CODE = start;
                    item.DEST = des;
                    item.CHAR_NUMBER = ConvertINT(number);
                    item.PRINT_TYPE = type;
                    item.UPD_TIME = DateTime.Now;
                    item.USER_UPDATE = "Thành";
                    db.MASTER_DATA.Add(item);
                    db.SaveChanges();
                }
            }
        }
        private int? ConvertINT(string number)
        {
            Int16 result;
            if(string.IsNullOrEmpty(number)) return null;
            if (Int16.TryParse(number, out result))
            {
                return result;
            }
            return null;
        }
    }
}
