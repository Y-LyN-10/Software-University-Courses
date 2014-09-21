using System;
using System.Text;

namespace Persons
{
    public class Person
    {
        private string _name;
        private int _age;
        private string _email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public string Name
        {
            get { return this._name; }
            private set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException();
                    }
                    if (value.Length < 2 || value.Length > 20)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    this._name = value;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Name can't be null or empty", ex);
                    throw;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Name should have at least 2 letters and can't be more than 20 letters", ex);
                    throw;
                }
            }
        }

        public int Age
        {
            get { return this._age; }
            set
            {
                try
                {
                    if (value < 0 || value > 100)
                    {
                        throw new ArgumentException();
                    }
                    this._age = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Age can't be less than 0 or greater than 100", ex);
                    throw;
                }
            }
        }

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                try
                {
                    if (!(IsValidEmail(value)))
                    {
                        throw new ArgumentException();
                    }
                    this._email = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Email address is not valid", ex);
                    throw;
                }
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                if (string.IsNullOrEmpty(email))
                {
                    return true; // Null is acceptable for this task
                }
                return false;
            }
        }

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
            var person = new Person("Joe", 25, "joe@gmail.com");

            Console.WriteLine(person.ToString());
        }
    }
}