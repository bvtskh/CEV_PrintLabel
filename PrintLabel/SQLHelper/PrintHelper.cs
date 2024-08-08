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

namespace PrintLabel.SQLHelper
{
    public class PrintHelper
    {
        internal static bool SaveRePrintDataLog(MASTER_DATA data, List<string> barcodeList, string account, string reason)
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

        internal bool SaveAndUpdateLog(MASTER_DATA data, long printNumber, List<string> barcodeList, string account)
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
                            pRINT_DATA_LOG.IS_REPRINT = false;
                            pRINT_DATA_LOG.BASE_REQUEST = baseRq;
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
