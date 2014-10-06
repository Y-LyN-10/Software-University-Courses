namespace Animals
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "Rrrebet";
        }

        public void Transform()
        {
            if (this.Gender == Gender.Male)
            {
                Console.WriteLine("Kiss me, I am Prince!");
            }
            if (this.Gender == Gender.Female)
            {
                Console.WriteLine("Kiss me, I am Princess!");
            }
            
        }

        public override string ToString()
        {
            return "I'm a frog " + base.ToString();
        }
    }
}
