namespace SchoolSystem
{
    using System;

    public class Student : Human, IComment
    {
        private int idNumber;

        public int IdNumber
        {
            get { return this.idNumber; }
            set { this.idNumber = value;}
        }

        public Student(string name, int idNumber)
            : base(name)
        {
            this.IdNumber = idNumber;
        }


        public void AddComment(string text)
        {
            Console.WriteLine("Student comment: " + text);
        }
    }
}
