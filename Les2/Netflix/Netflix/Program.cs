namespace Netflix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NetflixSerie> series = new List<NetflixSerie>()
            {
                new NetflixSerie("Stranger Things", 4, 34, new DateTime(2016, 7, 15), "The Duffer Brothers", 8.7),
                new NetflixSerie("The Witcher", 3, 24, new DateTime(2019, 12, 20), "Lauren Schmidt Hissrich", 8.2),
                new NetflixSerie("Money Heist", 5, 41, new DateTime(2017, 5, 2), "Álex Pina", 8.3),
                new NetflixSerie("Bridgerton", 2, 16, new DateTime(2020, 12, 25), "Chris Van Dusen", 7.3),
                new NetflixSerie("The Crown", 5, 50, new DateTime(2016, 11, 4), "Peter Morgan", 8.6),
                new NetflixSerie("Ozark", 4, 44, new DateTime(2017, 7, 21), "Bill Dubuque", 8.4),
                new NetflixSerie("Narcos", 3, 30, new DateTime(2015, 8, 28), "Chris Brancato", 8.8),
                new NetflixSerie("Black Mirror", 5, 22, new DateTime(2011, 12, 4), "Charlie Brooker", 8.8),
                new NetflixSerie("The Umbrella Academy", 3, 30, new DateTime(2019, 2, 15), "Steve Blackman", 8.0),
                new NetflixSerie("Lucifer", 6, 93, new DateTime(2016, 1, 25), "Tom Kapinos", 8.1),
                new NetflixSerie("The Crown", 5, 50, new DateTime(2016, 11, 4), "Peter Morgan", 8.6)
            };


            series.Sort();
            foreach(NetflixSerie s in series)
            {
                Console.WriteLine(s.ToString("n",null));
            }

        }
    }
}
