namespace Animals
{
    using System;
    
    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age)
            : base(name, age,Gender.Female)
        {
        }

        public override string ProduceSound()
        {
            return "purr";
        }

        public void Piss()
        {
            Console.WriteLine("I'll piss all over your carpet!");
        }

        public override string ToString()
        {
            return "I'm a tomcat " + base.ToString();
        }
    }
}
