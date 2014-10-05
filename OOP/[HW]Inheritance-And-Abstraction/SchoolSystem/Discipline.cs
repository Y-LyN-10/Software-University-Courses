namespace SchoolSystem
{
    using System;

    public class Discipline : IComment
    {

        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;

        public string DisciplineName
        {
            get { return this.disciplineName;}
            set {this.disciplineName = value;}
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures;}
            set {this.numberOfLectures = value;}
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises;}
            set { this.numberOfExercises = value;}
        }

        public Discipline(string disciplineName, int numberOfLectures, int numberOfExercises)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public void AddComment(string text)
        {
            Console.WriteLine("Discipline comment: " + text);
        }
    }
}
