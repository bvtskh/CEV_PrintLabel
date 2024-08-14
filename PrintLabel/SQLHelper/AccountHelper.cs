using PrintLabel.Models;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabel.SQLHelper
{
    public static class AccountHelper
    {
        public static USER Account {  get; set; }

        internal static void Delete(string account)
        {
            using (var db = new DBContext())
            {
                var uSER = db.USER.Where(W=>W.ACCOUNT == account).FirstOrDefault();
                if(uSER != null)
                {
                    db.USER.Remove(uSER);
                    db.SaveChanges();
                }
            }
        }

        internal static USER GetAccount(string account, string password)
        {
            using(var db = new DBContext())
            {
                Account =  db.USER.Where(w=>w.ACCOUNT == account && w.PASSWORD == password).FirstOrDefault();
                return Account;
            }
        }

        internal static USER GetAccount(string account)
        {
            using (var db = new DBContext())
            {
                 return db.USER.Where(w => w.ACCOUNT == account).FirstOrDefault();
            }
        }

        internal static List<USER> GetAllAccount()
        {
            using (var db = new DBContext())
            {
                return db.USER.ToList();
            }
        }

        internal static void InsertAccount(string account, string pass, string name, string dept, string describe, int type)
        {
            using (var db = new DBContext())
            {
                USER uSER = new USER();
                uSER.ACCOUNT = account;
                uSER.PASSWORD = pass;
                uSER.FULLNAME = name;
                uSER.TYPE = type;
                uSER.DEPT = dept;
                uSER.DESCRIBE = describe;
                db.USER.Add(uSER);
                db.SaveChanges();
            }
        }

        internal static bool IsAdmin()
        {
            return Account.TYPE == 1 || Account.TYPE == 0;
        }

        internal static bool IsAdmin(string account, string password)
        {
            using (var db = new DBContext())
            {
                var type = db.USER.Where(w => w.ACCOUNT == account && w.PASSWORD == password).Select(s=>s.TYPE).FirstOrDefault();
                if (type == null) return false;
                return type == 1;
            }
        }

        internal static bool IsReadonly(USER account)
        {
            return account.TYPE == 3;
        }

        internal static bool IsSpecial()
        {
            return Account.TYPE == 0;
        }

        internal static bool IsStaff(USER account)
        {
            return account.TYPE == 2;
        }

        internal static void Update(string account, string pass, string name, string dept, string describe, int type)
        {
            using (var db = new DBContext())
            {
                var uSER = GetAccount(account);
                uSER.PASSWORD = pass;
                uSER.FULLNAME = name;
                uSER.TYPE = type;
                uSER.DEPT = dept;
                uSER.DESCRIBE = describe;
                db.Entry(uSER).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
