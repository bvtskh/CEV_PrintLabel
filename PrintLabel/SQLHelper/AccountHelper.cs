﻿using PrintLabel.Models;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabel.SQLHelper
{
    public static class AccountHelper
    {
        public static USER Account {  get; set; }
        internal static USER GetAccount(string account, string password)
        {
            using(var db = new DBContext())
            {
                Account =  db.USER.Where(w=>w.ACCOUNT == account && w.PASSWORD == password).FirstOrDefault();
                return Account;
            }
        }

        internal static bool IsAdmin()
        {
            return Account.TYPE == 1;
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

        internal static bool IsStaff(USER account)
        {
            return account.TYPE == 2;
        }
    }
}
