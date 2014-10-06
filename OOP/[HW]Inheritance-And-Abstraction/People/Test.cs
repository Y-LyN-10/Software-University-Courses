namespace People
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            Console.Title = "Problem 2.	Human, Student and Worker";

            IList<Student> students = new List<Student>
            {
                new Student("Salvador", "Dunn", "153190779"),
                new Student("Nora", "Adkins", "380878115"),
                new Student("Percy", "Campbell", "140433671"),
                new Student("Van", "Bridges", "380878115"),
                new Student("Julia", "Garcia", "380878115"),
                new Student("Darren", "Wood", "153190779"),
                new Student("John", "Rivera", "140433671"),
            };

            IList<Worker> workers = new List<Worker>
            {
                new Worker("Wendy", "Manning", 400, 8),
                new Worker("Flora", "Cannon", 350, 6),
                new Worker("Florence", "Reed", 80, 4),
                new Worker("Melanie", "Morales", 300, 6),
                new Worker("Byron", "Young", 380, 8),
                new Worker("Lisa", "Roberson", 150, 4),
            };

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorted students by faculty number:");
            Console.ForegroundColor = ConsoleColor.White;

            var sortedStudentByFacultyNumber = students.OrderBy(s => s.FacultyNumber);
            Console.WriteLine(string.Join(Environment.NewLine, sortedStudentByFacultyNumber.Select(s => s.ToString())));
            Console.Write(Environment.NewLine);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorted workers by payment per hour:");
            Console.ForegroundColor = ConsoleColor.White;

            var sortedWorkerByPaymentPerHour = workers.OrderByDescending(w => w.MoneyPerHour());
            Console.WriteLine(string.Join(Environment.NewLine, sortedWorkerByPaymentPerHour.Select(w => w.ToString())));
            Console.Write(Environment.NewLine);

            var humans = new List<Human>();

            humans.AddRange(students);
            humans.AddRange(workers);

            var sortHumansByNames = humans
                .OrderBy(h => h.FirstName)
                .ThenBy(h => h.LastName)
                .Select(h => h.FirstName + " " + h.LastName + " - " + h.GetType());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("All people sorted by names:");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(string.Join(Environment.NewLine, sortHumansByNames));

        }
    }
}
