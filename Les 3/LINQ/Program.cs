namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nummers = new List<int> { 1, 23, 4, 5, 6, 7, 8, };

            double average =  nummers.Average();


            List<Student> students = new List<Student>
            {
                new Student("Jef",20),
                new Student("Jaak",20),
                new Student("John",20),
                new Student("Jane",20),

            };

            double average2 = students.Average(GetScore);

            Console.WriteLine(average2);
        }

        static int GetScore(Student s)
        {
            Console.WriteLine($"Average vraagt score voor: {s.Naam}");
            return s.Score;
        }
    }
}
