using DemoCodeFirst.Models;
using DemoCodeFirst.Models.Entities;
using DemoCodeFirst.Models.Repositories;

namespace DemoCodeFirst
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Deel1();
            // Deel2();
            Deel3();
        }

        private static void Deel3()
        {
            PersoonRepository repository = new PersoonRepository();
            repository.CreatePersoon("J", DateTime.Now);

            UnitOfWork.Instance.PersoonRepository.CreatePersoon("J", DateTime.Now);
        }

        private static void Deel2()
        {
            AppDbContext context = new AppDbContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.Personen.Add(new Persoon("John", new DateTime(1950, 1, 1)));
            context.Personen.Add(new Student("TI", "Mo", new DateTime(2000, 1, 1)));
            context.Personen.Add(new Docent("AAD","Matthias", new DateTime(1980, 1, 1)));

            context.SaveChanges();

            Student s = context.Studenten.First();
            Vak v = new Vak("AAD");
            s.Vakken.Add(v);
            context.SaveChanges();
            Student s2 = new Student("TI", "Jane", new DateTime(2006, 1, 1));
            s2.Vakken.Add(v);

            context.Studenten.Add(s2);
            context.SaveChanges();
        }

        private static void Deel1()
        {
            WoonPlaats woonPlaats = new WoonPlaats("Brussel");
            using (AppDbContext context1 = new AppDbContext())
            {
                context1.Database.EnsureDeleted();
                context1.Database.EnsureCreated();
                context1.WoonPlaatsen.Add(woonPlaats);
                context1.SaveChanges();
            }

            Persoon john = new Persoon("John", new DateTime(1950, 1, 1));
            john.WoonPlaats = woonPlaats;



            using (AppDbContext context = new AppDbContext())
            {

                context.Attach(woonPlaats);
                context.Personen.Add(john);

                Console.WriteLine(context.Entry(john).State);
                context.SaveChanges();

                john.Naam = "Jef";
                Console.WriteLine(context.Entry(john).State);
                context.SaveChanges();

                /*context.Personen.Remove(john);

                Console.WriteLine(context.Entry(john).State);
                context.SaveChanges();*/
            }

            using (AppDbContext context2 = new AppDbContext())
            {
                Persoon? personToUpdate = context2.Personen.Find(john.Id);

                personToUpdate.Naam = "qwertyu";
                context2.SaveChanges();
                Console.WriteLine(context2.Entry(john).State);
            }


            Console.WriteLine("Done!");

            using (AppDbContext context3 = new AppDbContext())
            {
                List<Persoon> personen = context3.Personen.ToList();
                personen.Where(p => p.Naam.Contains("a"));

                List<Persoon> filterdPersonen = context3.Personen.Where(p => p.Naam.Contains("a")).ToList();

                foreach (Persoon p in context3.Personen)
                {
                    Console.WriteLine(p.Naam);
                }
            }
        }
    }
}