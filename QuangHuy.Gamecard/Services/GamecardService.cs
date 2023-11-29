using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GamecardService
    {
        private GamecardRepository _repo = new GamecardRepository();

        public List<GameCardInfo> GetAllGamecards()
        {
            return _repo.GetAll();
        }
        public List<GameCardInfo> SearchGamecard(string keyword)
        {
            return _repo.GetAll().Where(s => s.GamePlatform.ToLower().Contains(keyword.ToLower()) ||
                                             s.Price.ToString().Contains(keyword.ToLower())).ToList();
        }
        public void DeleteAGamecard(int id)
        {
            _repo.Delete(id);
        }

        public GameCardInfo? GetAGamecard(int id)
        {
            return _repo.Get(id);
        }

        public void UpdateAGamecard(GameCardInfo gameCardInfo)
        {
            _repo.Update(gameCardInfo); 
        }

        public void AddAGamecard(GameCardInfo gameCardInfo)
        {
            _repo.Create(gameCardInfo);
        }

        public List<GameCardInfo> SearchGamecardByProviderId(string providerId)
        {
            if (string.IsNullOrEmpty(providerId))
            {
                return new List<GameCardInfo>();
            }

            var result = _repo.GetAll().Where(s => s.ProviderId == providerId).ToList();

            return result;
        }


    }
}
