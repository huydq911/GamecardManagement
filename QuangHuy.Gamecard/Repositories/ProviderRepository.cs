using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProviderRepository
    {
        public List<Provider> GetAll()
        {
            return new GameCard2023DbContext().Providers.ToList();
        }
    }
}
