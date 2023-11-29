using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService
    {
        AccountRepository repo = new AccountRepository();
        public MemberAccount? CheckLogin(string email, string password)
        {
            MemberAccount account = repo.Get(email);

            return account != null && account.MemberAccountPassword == password ? account : null;
        }

        public string GetFullNameByEmail(string email)
        {
            return repo.GetFullNameByEmail(email);
        }
    }
}
