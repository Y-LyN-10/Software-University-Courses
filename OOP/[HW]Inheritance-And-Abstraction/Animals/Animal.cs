namespace Animals
{
    using System;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Gender gender;

        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                Validation.CheckForNullOrEmpty(value, "Name");

                this.name = value;
            }
        }

        public int Age 
        {
            get { return this.age; }

            private set
            {
                Validation.CheckForNegative(value, "Age");

                this.age = value;
            }
        }

        public Gender Gender 
        {
            get { return this.gender; }
            private set { this.gender = value; }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return String.Format("{0}, I'm {1} years old, I'm {2} and I can {3}",
                 this.name, this.age, this.gender, this.ProduceSound());
        }
    }
}
