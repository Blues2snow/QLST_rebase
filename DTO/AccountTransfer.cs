using Avalonia.Controls.Primitives;
using Microsoft.EntityFrameworkCore;
using QLST_rebase.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST_rebase.DTO
{
    internal class AccountTransfer
    {
        public bool CheckSignIn(string account, string password)
        {
            using (DataDBContext context = new())
            {
                var temp = context.accounts.Where(p => p._account == account && p._password == password).ToList();
                return temp.Any(p => p._account.Equals(account,StringComparison.Ordinal) && p._password.Equals(password,StringComparison.Ordinal));
            }
        }
    }
}
