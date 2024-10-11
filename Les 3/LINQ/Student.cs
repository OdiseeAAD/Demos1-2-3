namespace LINQ
{
    internal class Student
    {
        public string Naam { get; set; }
        public int Score { get; set; }

        public Student(string naam, int score)
        {
            Naam = naam;
            Score = score;
        }
    }
}