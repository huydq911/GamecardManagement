using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProviderService
    {
        private ProviderRepository _repo;
        public List<Provider> GetAllProviders()
        {
            _repo = new ProviderRepository();
            return _repo.GetAll();
        }
    }
}
