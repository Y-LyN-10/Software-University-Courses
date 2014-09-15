using System;
using System.Collections.Generic;

namespace _1.LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            var laptops = new List<Laptop>();

            Battery acerBattery = new Battery("8 cells", 4); // Battery life in hours
            Laptop acerAspire = new Laptop(
                "VN7-591G", // Model
                "Acer Aspire", // Manufacturer
                "Intel Core i7-4710HQ", // Processor
                "NVIDIA GeForce GTX 860M", // Graphics card
                acerBattery, // Battery
                15.6, // Screen size
                1959 // Price in leva
            );

            Battery lenovoBattery = new Battery("6 cells", 5);
            Laptop lenovo = new Laptop(
                "IdeaPad G510", 
                "Lenovo", 
                "Intel Core i5-4200M",
                "AMD Radeon R5 M230", 
                lenovoBattery, 
                15.6, 
                1049.90m
            );

            Battery toshibaBattery = new Battery("4 cells", 4);
            Laptop toshiba = new Laptop(
                "Satellite L50-B-16C ", 
                "Toshiba", 
                "Intel Core i7-4710HQ", 
                "NVIDIA GeForce GTX 860M", 
                acerBattery, 
                15.6, 
                1959
            );

            laptops = new List<Laptop>() { acerAspire, lenovo, toshiba };

            foreach (var laptop in laptops)
            {
                Console.WriteLine(laptop.ToString());
                Console.WriteLine();
            }

            //TODO: Write Unit Tests
        }
    }
}
