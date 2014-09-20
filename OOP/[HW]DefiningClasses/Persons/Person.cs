using System;
using System.Text;

namespace Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email) 
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null)
        {
        }

        public string Name { get; private set; }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Age can't be less than 0 or greater than 100");
                }
                this.age = value;
            }
        }

        public string Email { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Name: {1}{0}Age:{2}{0}", Environment.NewLine, this.Name, this.Age);

            if (!(string.IsNullOrEmpty(this.Email)))
            {
                sb.AppendFormat("Email:{0}", this.Email);
            }

            return sb.ToString();
        }
    }

    class Program
    {
        public static void Main()
        {
            var person = new Person("Gosho", 30, "gosho@gmail.com");

            Console.WriteLine(person.ToString());
        }
    }
}