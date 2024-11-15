using DemoCodeFirst.Models.Entities;

namespace DemoCodeFirst.Models.Repositories
{
    public class PersoonRepository
    {


        public void CreatePersoon(string naam, DateTime geboortedatum)
        {
            using (AppDbContext _context = new AppDbContext())
            {
                Persoon p = new Persoon(naam, geboortedatum);
                _context.Personen.Add(p);
                _context.SaveChanges();
            }
        }


        public List<Persoon> GetAll()
        {
            using (AppDbContext _context = new AppDbContext())
            {

                return _context.Personen.ToList();
            }
        }

        public void UpdatePersoon(Persoon p)
        {
            using (AppDbContext _context = new AppDbContext())
            {

                Persoon? personToUpdate = _context.Personen.Find(p.Id);

                if (personToUpdate == null)
                {
                    throw new ArgumentException();
                }

                personToUpdate.Naam = p.Naam;
                personToUpdate.Geboortedatum = p.Geboortedatum;

                _context.SaveChanges();
            }

        }

        public void Delete(string id)
        {
            using (AppDbContext _context = new AppDbContext())
            {

                Persoon personToDelete = _context.Personen.Find(id);
                _context.Personen.Remove(personToDelete);
                _context.SaveChanges();
            }
        }
    }
}
