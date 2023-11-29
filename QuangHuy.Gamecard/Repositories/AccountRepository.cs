using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository
    {
        GameCard2023DbContext db = new GameCard2023DbContext();
        public MemberAccount? Get(string email)
        {

            return db.MemberAccounts.FirstOrDefault(x => x.MemberEmail == email);
        }

        public string GetFullNameByEmail(string email)
        {
            MemberAccount account = Get(email);
            return account?.MemberFullName;
        }
    }
}
