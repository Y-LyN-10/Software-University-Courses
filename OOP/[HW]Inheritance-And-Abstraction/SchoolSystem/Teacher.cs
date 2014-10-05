namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Human, IComment
    {
        public IList<Discipline> Disciplines { get; set; }

        public Teacher(string name)
            : base(name)
        {
            this.Name = name;
            this.Disciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (Discipline discipline in Disciplines)
            {
                if (Disciplines.Count > 0)
                {
                    sb.Append("\nDiscipline: " + discipline.DisciplineName + " \nNumber of lectures: " + discipline.NumberOfLectures
                    + "\nNumber of exercises: " + discipline.NumberOfExercises + "\n----------------------------");
                }
            }
            return sb.ToString();
        }

        public void AddComment(string text)
        {
            Console.WriteLine("Teacher comment: " + text);
        }
    }
}
