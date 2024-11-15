using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Models.Repositories
{
    // Singleton
    public class UnitOfWork
    {
        private static UnitOfWork instance;
        private AppDbContext dbContext;

        public WoonPlaatsRepository WoonPlaatsRepository { get; set; }
        public PersoonRepository2 PersoonRepository { get; set; }
        public static UnitOfWork Instance {
            get {
                if(instance == null)
                {
                    instance = new UnitOfWork();
                }
                return instance;
            }
        }

        private UnitOfWork()
        {
            dbContext = new AppDbContext();
            WoonPlaatsRepository = new WoonPlaatsRepository(dbContext);
            PersoonRepository = new PersoonRepository2(dbContext);

        }
    }
}
