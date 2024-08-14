using BarTender;
using PrintLabel.Models;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace PrintLabel.SQLHelper
{
    public class PrintHelper
    {
        internal static bool SaveRePrintDataLog(MASTER_DATA data, List<string> barcodeList, string account, string reason, string checker)
        {
            try
            {
                using (var db = new DBContext())
                {
                    List<RE_PRINT_DATA_LOG> reprints = new List<RE_PRINT_DATA_LOG>();
                    foreach (var item in barcodeList)
                    {
                        RE_PRINT_DATA_LOG reprint = new RE_PRINT_DATA_LOG();
                        reprint.DATA_ID = data.ID;
                        reprint.PRINT_TYPE = data.PRINT_TYPE;
                        reprint.PRINT_CODE = item;
                        reprint.UPD_TIME = DateTime.Now;
                        reprint.PRINTER = account;
                        reprint.MACHINE_NAME = System.Environment.MachineName;
                        reprint.BASE_REQUEST = GetReprintBaseRequest();
                        reprint.REASON = reason;
                        reprint.CHECKER = checker;
                        reprints.Add(reprint);
                    }
                    db.RE_PRINT_DATA_LOG.AddRange(reprints);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }           
        }

        private static int? GetReprintBaseRequest()
        {
            using (var db = new DBContext())
            {
                var request = db.RE_PRINT_DATA_LOG.Max(m => m.BASE_REQUEST);
                return request == null ? 1 : request + 1;
            }
        }

        internal bool DeleteModel(DataGridViewRow selectRow)
        {
            using(var db = new DBContext())
            {
                using(var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        var model = selectRow.Cells[0].Value?.ToString();
                        if (string.IsNullOrEmpty(model))
                        {
                            MessageBox.Show("Không tìm thấy model này!");
                            return false;
                        }
                        var cell = selectRow.Cells[1].Value?.ToString();
                        var dest = selectRow.Cells[2].Value?.ToString();
                        var printType = GetPrintType(selectRow.Cells[5].Value?.ToString());
                        var dataExisted = db.MASTER_DATA.Where(w => w.MODEL == model && w.CELL == cell && w.DEST == dest && w.PRINT_TYPE == printType).FirstOrDefault();
                        
                        if(dataExisted == null)
                        {
                            MessageBox.Show("Không tìm thấy model này!");
                            return false;
                        }
                        if (dataExisted != null)
                        {
                            db.MASTER_DATA.Remove(dataExisted);
                            db.SaveChanges();
                        }
                        HISTORY_MODIFIED_DATA_MASTER history = new HISTORY_MODIFIED_DATA_MASTER();
                        history.UPD_TYPE = 2; //xóa
                        history.UPD_TIME = DateTime.Now;
                        history.UPD_USER = AccountHelper.Account.ACCOUNT;
                        history.MACHINE_NAME = System.Environment.MachineName;
                        
                        history.DESCRIBE = $"Xóa model {dataExisted.MODEL}";
                        history.DATA_ID = dataExisted.ID;
                        history.MODEL = dataExisted.MODEL;
                        history.CELL = dataExisted.CELL;
                        history.DEST = dataExisted.DEST;
                        history.START_CODE = dataExisted.START_CODE;
                        history.CHAR_NUMBER = dataExisted.CHAR_NUMBER;
                        history.PRINT_TYPE = dataExisted.PRINT_TYPE;
                        history.PRINT_PATH = dataExisted.PRINT_PATH;
                        history.DATABASE_PATH = dataExisted.DATABASE_PATH;
                        db.HISTORY_MODIFIED_DATA_MASTER.Add(history);
                        db.SaveChanges();

                        trans.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                        return false;
                    }                  
                }                 
            }   
        }

        internal List<string> GetAllDest()
        {
            using (var db = new DBContext())
            {
                return db.MASTER_DATA.Select(s => s.DEST).Distinct().ToList();
            }
        }

        internal List<string> GetAllModel()
        {
            using (var db = new DBContext())
            {
                return db.MASTER_DATA.Select(s => s.MODEL).Distinct().ToList();
            }
        }

        internal List<string> GetAllModel(int printType)
        {
            using (var db = new DBContext())
            {
                return db.MASTER_DATA.Where(w=>w.PRINT_TYPE == printType).Select(s => s.MODEL).Distinct().ToList();
            }
        }

        internal List<string> GetAllPrintType()
        {
            using (var db = new DBContext())
            {
                return db.PRINT_TYPE.Select(s => s.PRINT_NAME).Distinct().ToList();
            }
        }

        internal string GetBartenderPath(string model, string dest, int? printType)
        {
            using (var db = new DBContext())
            {
                return db.MASTER_DATA.Where(s => s.MODEL == model && s.DEST == dest && s.PRINT_TYPE == printType).Select(w => w.PRINT_PATH).FirstOrDefault();
            }
        }

        internal List<string> GetCell(string model)
        {
            using (var db = new DBContext())
            {
                return db.MASTER_DATA.Where(w => w.MODEL == model).Select(s => s.CELL).Distinct().ToList();
            }
        }

        internal string GetDatabsePath(string model, string dest, int? printType)
        {
            using (var db = new DBContext())
            {
                return db.MASTER_DATA.Where(s => s.MODEL == model && s.DEST == dest && s.PRINT_TYPE == printType).Select(w => w.DATABASE_PATH).FirstOrDefault();
            }
        }

        internal DataTable GetLogData(DateTime from, DateTime to, bool isNormal)
        {
            using (SqlConnection connection = new SqlConnection(@"data source=192.168.1.10;initial catalog=PrintLabel;persist security info=True;user id=sa;password=cev@2017;"))
            {
                string stored = "";
                if (isNormal)
                {
                    stored = "GetNormalLog";
                }
                else
                {
                    stored = "GetExceptionLog";
                }
                using (SqlCommand command = new SqlCommand(stored, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@from", from));
                    command.Parameters.Add(new SqlParameter("@to", to));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        internal List<MASTER_DATA> GetMasterData(string model, string cell, int printType)
        {
            using (var db = new DBContext())
            {
                return db.MASTER_DATA.Where(w => w.MODEL == model && w.CELL == cell && w.PRINT_TYPE == printType).ToList();
            }
        }

        internal MASTER_DATA GetMasterData(string model, string cell, int printType, string des)
        {
            using (var db = new DBContext())
            {
                return db.MASTER_DATA.Where(w => w.MODEL == model && w.CELL == cell && w.PRINT_TYPE == printType && w.DEST == des).FirstOrDefault();
            }
        }

        internal MASTER_DATA GetMasterData(Guid? dATA_ID)
        {
            using (var db = new DBContext())
            {
                return db.MASTER_DATA.Where(w => w.ID == dATA_ID).FirstOrDefault();
            }
        }

        internal DataTable GetMasterData(string search)
        {
            using (SqlConnection connection = new SqlConnection(@"data source=192.168.1.10;initial catalog=PrintLabel;persist security info=True;user id=sa;password=cev@2017;"))
            {
                using (SqlCommand command = new SqlCommand("GetMasterData", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@search", search));
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        internal List<MASTER_DATA> GetMasterDataByModelName(string model)
        {
            using (var db = new DBContext())
            {
                return db.MASTER_DATA.Where(w => w.MODEL == model).ToList();
            }
        }

        internal List<PRINT_DATA_LOG> GetPrintLog(DateTime from, DateTime to)
        {
            using (var db = new DBContext())
            {
                return db.PRINT_DATA_LOG.Where(w => DbFunctions.TruncateTime(w.UPD_TIME) >= from && DbFunctions.TruncateTime(w.UPD_TIME) <= to).ToList();
            }
        }

        internal string GetPrintType(int printType)
        {
            using (var db = new DBContext())
            {
                return db.PRINT_TYPE.Where(w => w.PRINT_TYPE1 == printType).Select(s => s.PRINT_NAME).FirstOrDefault();
            }
        }

        internal List<string> GetPrintType(string model, string dest)
        {
            using (var db = new DBContext())
            {
                var data = db.MASTER_DATA.Where(w => w.MODEL == model && w.DEST == dest && w.PRINT_TYPE != null).Select(s => s.PRINT_TYPE).Distinct().ToList();
                List<string> list = new List<string>();
                foreach (var item in data)
                {
                    var print = (GetPrintType((int)item));
                    if (print != null)
                        list.Add(print);
                }
                return list;
            }
        }

        internal int? GetPrintType(string printName)
        {
            using (var db = new DBContext())
            {
                return db.PRINT_TYPE.Where(w => w.PRINT_NAME == printName).Select(s => s.PRINT_TYPE1).FirstOrDefault();
            }
        }

        internal decimal? GetPrintUpdateData(Guid iD)
        {
            using (var db = new DBContext())
            {
                var updateData = db.PRINTED_UPDATE.Where(w => w.DATA_ID == iD).FirstOrDefault();
                if (updateData == null)
                {
                    // create update log
                    PRINTED_UPDATE pRINTED_UPDATE = new PRINTED_UPDATE();
                    pRINTED_UPDATE.DATA_ID = iD;
                    pRINTED_UPDATE.UPD_TIME = DateTime.Now;
                    pRINTED_UPDATE.PRINTED_TOTAL = 0;
                    db.PRINTED_UPDATE.Add(pRINTED_UPDATE);
                    db.SaveChanges();
                    return 0;
                }
                return updateData.PRINTED_TOTAL;
            }
        }

        internal List<RE_PRINT_DATA_LOG> GetRePrintLog(DateTime from, DateTime to)
        {
            using (var db = new DBContext())
            {
                return db.RE_PRINT_DATA_LOG.Where(w =>DbFunctions.TruncateTime(w.UPD_TIME) >= from && DbFunctions.TruncateTime(w.UPD_TIME) <= to).ToList();
            }
        }

        internal bool InsertNewModel(string model, string printType, string cell, string dest, string number, string startCode, string bar, string database)
        {
            try
            {
                using (var db = new DBContext())
                {
                    //check tồn tại model
                    var print = GetPrintType(printType);
                    var existed = db.MASTER_DATA.Where(w=>w.MODEL == model && w.CELL == cell && w.DEST == dest && w.PRINT_TYPE == print).FirstOrDefault();
                    if (existed != null)
                    {
                        MessageBox.Show("Đã tồn tại model này rồi!");
                        return false;
                    }
                    MASTER_DATA data = new MASTER_DATA();
                    data.ID = Guid.NewGuid();
                    data.MODEL = model;
                    data.CELL = cell;
                    data.DEST = dest;
                    data.PRINT_TYPE = print;
                    data.CHAR_NUMBER = Common.Common.ConvertDefaultINT(number);
                    data.START_CODE = startCode;
                    data.UPD_TIME = DateTime.Now;
                    data.PRINT_PATH = bar;
                    data.DATABASE_PATH = database;
                    data.USER_UPDATE = AccountHelper.Account.ACCOUNT;
                    db.MASTER_DATA.Add(data);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)

            {
                return false;
            }
        }

        internal bool SaveAndUpdateLog(MASTER_DATA data, long printNumber, List<string> barcodeList, string account, string checker ="", string partNumber ="")
        {
            using (var db = new DBContext())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        // cập nhật số lượng
                        var data_update = db.PRINTED_UPDATE.Where(w => w.DATA_ID == data.ID).FirstOrDefault();
                        if (data_update != null)
                        {
                            data_update.PRINTED_TOTAL += printNumber;
                            data_update.UPD_TIME = DateTime.Now;
                            db.Entry(data_update).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }
                        // lưu log
                        var baseRq = GetLastRequestNo();
                        foreach (var barcode in barcodeList)
                        {
                            PRINT_DATA_LOG pRINT_DATA_LOG = new PRINT_DATA_LOG();
                            pRINT_DATA_LOG.DATA_ID = data.ID;
                            pRINT_DATA_LOG.PRINT_TYPE = data.PRINT_TYPE;
                            pRINT_DATA_LOG.PRINT_CODE = barcode;
                            pRINT_DATA_LOG.UPD_TIME = DateTime.Now;
                            pRINT_DATA_LOG.PRINTER = account;
                            pRINT_DATA_LOG.MACHINE_NAME = System.Environment.MachineName;
                            pRINT_DATA_LOG.BASE_REQUEST = baseRq;
                            pRINT_DATA_LOG.CHECKER =checker;
                            pRINT_DATA_LOG.PART_NUMBER =partNumber;
                            db.PRINT_DATA_LOG.Add(pRINT_DATA_LOG);
                            db.SaveChanges();
                        }
                        trans.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }

        internal bool SaveChangePath(string bartender, string database, Guid iD)
        {
            try
            {
                using (var db = new DBContext())
                {
                    var data = db.MASTER_DATA.Where(w => w.ID == iD).FirstOrDefault();
                    if (data != null)
                    {
                        data.PRINT_PATH = bartender;
                        data.DATABASE_PATH = database;
                        db.Entry(data).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal bool SaveChangePath(string bartender, string database, string model, string dest, int? printType)
        {
            using (var db = new DBContext())
            {
                using(var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        HISTORY_CONFIG_FILE_PATH history = new HISTORY_CONFIG_FILE_PATH();
                        history.MODEL = model;
                        history.DEST = dest;
                        history.PRINT_TYPE = printType;
                        history.OLD_PRINT_PATH = GetBartenderPath(model, dest, printType); // trước khi thay đổi
                        history.OLD_DATABASE_PATH = GetDatabsePath(model, dest, printType);

                        history.NEW_PRINT_PATH = bartender; // sau khi thay đổi
                        history.NEW_DATABASE_PATH = database;

                        history.UPD_TIME = DateTime.Now;
                        history.USER_CHANGE = AccountHelper.Account.ACCOUNT;
                        history.MACHINE_NAME = System.Environment.MachineName;
                        db.HISTORY_CONFIG_FILE_PATH.Add(history);
                        db.SaveChanges();
                        // cập nhật
                        var dataUpdate = db.MASTER_DATA.Where(w => w.MODEL == model && w.DEST == dest && w.PRINT_TYPE == printType).ToList();
                        foreach (var data in dataUpdate)
                        {
                            data.PRINT_PATH = bartender;
                            data.DATABASE_PATH = database;
                            db.Entry(data).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }
                        trans.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }

        internal bool UpdateModel(string model, string printType, string cell, string dest, string bartender, string database, string startCode)
        {
            using (var db = new DBContext())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {      
                        var print = GetPrintType(printType);
                        var existed = db.MASTER_DATA.Where(w => w.MODEL == model && w.CELL == cell && w.DEST == dest && w.PRINT_TYPE == print).FirstOrDefault();
                        
                        var old_StartCode = existed.START_CODE ?? "";
                        var old_Bartender = existed.PRINT_PATH ?? "";
                        var old_Database = existed.DATABASE_PATH ?? "";   
                        if(old_StartCode == startCode && old_Bartender == bartender && old_Database == database)
                        {
                            MessageBox.Show("Bạn chưa thay đổi gì ?");
                            return false;
                        }
                        if(existed == null)
                        {
                            MessageBox.Show("Không tìm thấy model này, vui lòng kiểm tra lại!");
                            return false;
                        }    
                        if (existed != null)
                        {
                            existed.START_CODE = startCode;
                            existed.PRINT_PATH = bartender;
                            existed.DATABASE_PATH = database;
                            existed.UPD_TIME = DateTime.Now;
                            existed.USER_UPDATE = AccountHelper.Account.ACCOUNT;
                            db.Entry(existed).State = EntityState.Modified;
                            db.SaveChanges();                           
                        }

                        HISTORY_MODIFIED_DATA_MASTER history = new HISTORY_MODIFIED_DATA_MASTER();
                        history.UPD_TYPE = 1; //sửa
                        history.UPD_TIME = DateTime.Now;
                        history.UPD_USER =AccountHelper.Account.ACCOUNT;
                        history.MACHINE_NAME = System.Environment.MachineName;
                        var des = $"({old_StartCode} -> {startCode})";

                        if (string.IsNullOrEmpty(old_Bartender) && old_Bartender != bartender)
                        {
                            des += $"(Thêm mới {bartender})";
                        }
                                            
                        else
                        {
                            if (old_Bartender != bartender)
                            {
                                des += $"({old_Bartender} -> {bartender})";
                            }
                        }
                        if (string.IsNullOrEmpty(old_Database) && old_Database != database)
                        {
                            des += $"(Thêm mới {database})";
                        }
                   
                        else
                        {
                            if (old_Database != database)
                            {
                                des += $"({old_Database} -> {database})";
                            }
                        }
                        history.DESCRIBE = des;
                        history.DATA_ID =existed.ID;
                        history.MODEL= existed.MODEL;
                        history.CELL = existed.CELL;
                        history.DEST = existed.DEST;
                        history.START_CODE = existed.START_CODE;
                        history.CHAR_NUMBER = existed.CHAR_NUMBER;
                        history.PRINT_TYPE = existed.PRINT_TYPE;
                        history.PRINT_PATH = old_Bartender;
                        history.DATABASE_PATH = old_Database;
                        db.HISTORY_MODIFIED_DATA_MASTER.Add(history);
                        db.SaveChanges();

                        trans.Commit();
                        return true;

                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        return false;
                    }   
                } 
            }
        }

        internal bool UpdateModel(string model, string printType, string cell, string dest, string bartender, string database, string startCode, int charNumber, int totalPrinted)
        {
            using (var db = new DBContext())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        var print = GetPrintType(printType);
                        var existed = db.MASTER_DATA.Where(w => w.MODEL == model && w.CELL == cell && w.DEST == dest && w.PRINT_TYPE == print).FirstOrDefault();

                        var old_StartCode = existed.START_CODE ?? "";
                        var old_Bartender = existed.PRINT_PATH ?? "";
                        var old_Database = existed.DATABASE_PATH ?? "";
                        if (existed == null)
                        {
                            MessageBox.Show("Không tim thấy model này, vui lòng kiểm tra lại!");
                            return false;
                        }
                        if (existed != null)
                        {
                            existed.START_CODE = startCode;
                            existed.PRINT_PATH = bartender;
                            existed.DATABASE_PATH = database;
                            existed.UPD_TIME = DateTime.Now;
                            existed.USER_UPDATE = AccountHelper.Account.ACCOUNT;
                            existed.MODEL = model;
                            existed.CELL = cell;
                            existed.DEST = dest;
                            existed.PRINT_TYPE = print;
                            existed.CHAR_NUMBER =charNumber;
                            db.Entry(existed).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                        
                        var update = db.PRINTED_UPDATE.Where(w=>w.DATA_ID == existed.ID).FirstOrDefault();
                        if (update != null)
                        {
                            update.PRINTED_TOTAL = totalPrinted;
                            db.Entry(update).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                        trans.Commit();
                        return true;

                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }

        private int? GetLastRequestNo()
        {
            using (var db = new DBContext())
            {
                var request = db.PRINT_DATA_LOG.Max(m => m.BASE_REQUEST);
                return request == null ? 1 : request + 1;
            }
        }
    }
}
