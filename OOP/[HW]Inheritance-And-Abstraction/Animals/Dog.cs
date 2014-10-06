namespace Animals
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "Bark";
        }
        
        public void FetchStick()
        {
            Console.WriteLine("Throw me a stick and I'll fetch it for you.");
        }

        public override string ToString()
        {
            return "I'm a dog " + base.ToString();
        }
    }
}
