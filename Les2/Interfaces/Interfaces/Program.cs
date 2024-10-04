namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adres adres1 = new Adres("Stormstraat", "12", 1000, "Brussel", "België");

            //IAdres adres2 = adres1;
            //IAdres adres4 = new Adres("Demo", "2", 1000, "Brussel", "België");
            //adres1.Straat = "Demo";
            //adres2.Straat = "Demo";

            //IAdres adres3 = new IAdres();


            List<int> ints = new List<int>() { 1, 2, 33, 35, 212, 43, 2, 1 };
            ints.Sort();

            foreach (int i in ints)
            {
                Console.WriteLine(i);

            }

            List<Adres> adressen = new List<Adres>()
            {
                new Adres("Astraat", "10B", 1000, "Brussel", "België"),
                new Adres("Astraat", "10A", 1000, "Brussel", "België"),
                new Adres("Bstraat", "21", 1000, "Brussel", "België"),
                new Adres("Bstraat", "11", 1000, "Brussel", "België")
            };
            adressen.Sort();

            foreach (Adres adres in adressen)
            {
                Console.WriteLine(adres);
            }
        }
    }
}
