namespace SchoolSystem
{
    using System;

    public abstract class Human
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Human(string name)
        {
            this.Name = name;
        }
    }
}
