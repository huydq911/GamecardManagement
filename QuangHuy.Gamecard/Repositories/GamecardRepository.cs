using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class GamecardRepository
    {
        private GameCard2023DbContext _context;
        public GameCardInfo? Get(int GamecardId)
        {
            _context = new GameCard2023DbContext();

            return _context.GameCardInfos.Find(GamecardId);
        }

        public List<GameCardInfo> GetAll()
        {
            _context = new GameCard2023DbContext();

            return _context.GameCardInfos.Include(cat => cat.Provider).ToList();
        }

        public void Create(GameCardInfo gameCardInfo)
        {
            _context = new GameCard2023DbContext();
            _context.GameCardInfos.Add(gameCardInfo);
            _context.SaveChanges();
        }

        public void Update(GameCardInfo gameCardInfo)
        {
            _context = new GameCard2023DbContext();
            _context.GameCardInfos.Update(gameCardInfo);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context = new GameCard2023DbContext();
            var gamecard = _context.GameCardInfos.FirstOrDefault(b => b.GameCardId == id);

            if (gamecard != null)
            { 
                _context.GameCardInfos.Remove(gamecard);
                _context.SaveChanges();
            }
        }
    }
}
