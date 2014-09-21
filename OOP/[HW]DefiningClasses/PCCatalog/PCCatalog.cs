using System;
using System.Collections.Generic;

namespace PCCatalog
{
    public class PCCatalog
    {
        static void Main()
        {
            var pc = new Computer("Dell");

            var computers = new List<Computer> {pc};

            var components = new List<Component>
            {
                new Component("Motherboard", "Asus", 200M),
                new Component("Processor", "Intel Core i7-4710HQ", 300M),
                new Component("RAM", "Kingston 2 X 4GB", 150M),
                new Component("Video card", "NVIDIA GeForce GTX 860M", 210M),
                new Component("HDD", "Toshiba 1TB", 120M)
            };

            foreach (var component in components)
            {
                pc.AddComponent(component);
            }
          
            // If there are more than one computer, of course:
            // computers.Sort();

            foreach (var computer in computers)
            {
                Console.WriteLine(computer.GetDescription());
            }
            
            // Test computer's ToString() method
            foreach (var computer in computers)
            {
                Console.WriteLine(computer);
            }
        }
    }
}
