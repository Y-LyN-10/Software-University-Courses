namespace Animals
{
    using System;
    
    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age)
            : base(name, age,Gender.Female)
        {
        } 

        public override string ProduceSound()
        {
            return "Meow!";
        }

        public void MeltYourHeart()
        {
            Console.WriteLine("Take me home! I'm soooo cute!");
        }

        public override string ToString()
        {
            return "I'm a kiiten " + base.ToString();
        }
    }
}
