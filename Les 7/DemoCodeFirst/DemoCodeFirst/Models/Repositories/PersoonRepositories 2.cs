using DemoCodeFirst.Models.Entities;

namespace DemoCodeFirst.Models.Repositories
{
    public class PersoonRepository2
    {
        AppDbContext _context;

        public PersoonRepository2(AppDbContext context)
        {
            _context = context;
        }

        public void CreatePersoon(string naam, DateTime geboortedatum)
        {

            Persoon p = new Persoon(naam, geboortedatum);
            _context.Personen.Add(p);
            _context.SaveChanges();

        }


        public List<Persoon> GetAll()
        {


            return _context.Personen.ToList();

        }

        public void UpdatePersoon(Persoon p)
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

        public void Delete(string id)
        {


            Persoon personToDelete = _context.Personen.Find(id);
            _context.Personen.Remove(personToDelete);
            _context.SaveChanges();

        }
    }
}
