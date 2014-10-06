namespace Animals
{
    using System;
    using System.Linq;

    class TestAnimals
    {
        static void Main()
        {
            // Attention! - No animals were harmed during these tests

            Console.Title = "Animals";

            var dog = new Dog("Gosho", 3, Gender.Male);
            Console.WriteLine(dog);
            dog.FetchStick();
            Console.Write(Environment.NewLine);

            var frog = new Frog("Masha", 16, Gender.Female);
            Console.WriteLine(frog);
            frog.Transform();
            Console.Write(Environment.NewLine);

            var kitty = new Kitten("Maca", 0);
            Console.WriteLine(kitty);
            kitty.MeltYourHeart();
            Console.Write(Environment.NewLine);

            var tomcat = new Tomcat("Tom", 4);
            Console.WriteLine(tomcat);
            tomcat.Piss();
            Console.Write(Environment.NewLine);

            var animals = new Animal[]
            {
                new Dog("Freya", 1, Gender.Female),
                new Dog("Sharo", 4, Gender.Male),
                new Frog("Penka", 20, Gender.Female),
                new Frog("Fred", 32, Gender.Male),
                new Kitten("Merlin", 1),
                new Kitten("Shusia", 0),
                new Tomcat("Felix",6),
                new Tomcat("Silvester", 5),
            };

            var averageAge = from an in animals 
                group an by new
                {
                    GroupName = an.GetType().Name
                } 
                into gender select new
                {
                    gender.Key.GroupName,
                    AvarageAge = gender.Average(an => an.Age)
                };

            foreach (var animal in averageAge)
            {
                Console.WriteLine(String.Format("Group: {0}, AvarageAge: {1:0.00}.", animal.GroupName, animal.AvarageAge));
            }

            // And what does the Fox say? Oh, no foxes here...
        }
    }
}
