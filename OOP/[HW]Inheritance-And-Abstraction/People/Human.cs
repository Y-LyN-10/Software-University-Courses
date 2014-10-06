namespace People
{
    abstract public class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
        }

        public string FirstName
        {
            get { return this.firstName; }

            private set
            {
                Validation.CheckForNullOrEmpty(value, "firstName");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            private set
            {
                Validation.CheckForNullOrEmpty(value, "LastName");
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.firstName, this.lastName);
        }
    }
}

