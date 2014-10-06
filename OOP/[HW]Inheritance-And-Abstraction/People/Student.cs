namespace People
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }

            private set
            {
                Validation.ChekForValidFacultyNumber(value, "facultyNumber");

                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " - " + this.FacultyNumber;
        }
    }
}

