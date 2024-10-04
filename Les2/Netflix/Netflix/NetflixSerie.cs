namespace Netflix
{
    internal class NetflixSerie : IEquatable<NetflixSerie>, IComparable<NetflixSerie>, IFormattable
    {
        public NetflixSerie(string title, int seasons, int episodes, DateTime releaseDate, string director, double rating)
        {
            Title = title;
            Seasons = seasons;
            Episodes = episodes;
            ReleaseDate = releaseDate;
            Director = director;
            Rating = rating;
        }

        public string Title { get; set; }
        public int Seasons { get; set; }
        public int Episodes { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public double Rating { get; set; }

        public int CompareTo(NetflixSerie? other)
        {
            if(other== null)
            {
                throw new ArgumentException("Can't compare with NULL");
            } 

            int ratingCompare = Rating.CompareTo(other.Rating);
            int releaseDateCompare = ReleaseDate.CompareTo(other.ReleaseDate);
            int titleCompare = Title.CompareTo(other.Title);

            if(ratingCompare == 0)
            {
                if(releaseDateCompare == 0)
                {
                    return titleCompare;
                } else
                {
                    return releaseDateCompare;
                }
            } else
            {
                return ratingCompare;
            }
        }

        public bool Equals(NetflixSerie? other)
        {
            if(other == null)
            {
                return false;
            }

            return Title == other.Title && Seasons == other.Seasons && Episodes == other.Episodes && ReleaseDate == other.ReleaseDate && Director == other.Director && Rating == other.Rating;
        }

        public override string ToString()
        {
            return $"{Title} - {Seasons} seasons, {Episodes} episodes, Released on {ReleaseDate.ToShortDateString()}, Directed by {Director}, Rating: {Rating}";
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            switch (format)
            {
                case "s": return Title;
                case "n": return $"{Title} {ReleaseDate}: {Rating}";
                case "e": return ToString();
                default: throw new FormatException("Invalid Format");
            }
        }
    }
}
