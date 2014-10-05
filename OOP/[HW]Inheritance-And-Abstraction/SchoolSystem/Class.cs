namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Class : IComment
    {
        private string textIdentifier;

        protected IList<Teacher> Teachers { get; private set; }
        protected IList<Student> Students { get; private set; }

        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            set { this.textIdentifier = value;}
        }

        public Class(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void AddComment(string text)
        {
            Console.WriteLine("Comment: " + text);
        }

        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            foreach (Teacher teacher in Teachers)
            {
                if (Teachers.Count > 0)
                {
                    strBuild.Append("Teacher: " + teacher.Name + teacher.ToString());
                }
            }
            foreach (Student student in Students)
            {
                if (Students.Count > 0)
                {
                    strBuild.AppendLine();
                    strBuild.Append("Student: " + student.Name + " | Id: " + student.IdNumber);
                }
            }
            return strBuild.ToString();
        }
    }
}
