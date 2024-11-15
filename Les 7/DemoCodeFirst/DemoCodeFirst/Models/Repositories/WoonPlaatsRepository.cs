using DemoCodeFirst.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Models.Repositories
{
    public class WoonPlaatsRepository
    {
        AppDbContext _context;

        public WoonPlaatsRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<WoonPlaats> GetAll()
        {
            return _context.WoonPlaatsen.ToList();
        }
    }
}
