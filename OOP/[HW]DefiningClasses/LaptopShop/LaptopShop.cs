using System;
using System.Collections.Generic;

namespace LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            var laptops = new List<Laptop>();

            var acerAspire = new Laptop(
                "VN7-591G", // Model
                "Acer Aspire", // Manufacturer
                "Intel Core i7-4710HQ", // Processor
                "NVIDIA GeForce GTX 860M", // Graphics card
                "8 cells", // Battery
                4, // Battery life in hours
                15.6, // Screen size
                1959 // Price in leva
            );

            Laptop lenovo = new Laptop(
                "IdeaPad G510",
                "Lenovo",
                "Intel Core i5-4200M",
                "AMD Radeon R5 M230",
                "6 cells", 
                5,
                15.6,
                1049.90m
            );

            Laptop toshiba = new Laptop(
                "Satellite L50-B-16C ",
                "Toshiba",
                "Intel Core i7-4710HQ",
                "NVIDIA GeForce GTX 860M",
                "4 cells", 
                4,
                15.6,
                1959
            );

            Laptop hp = new Laptop("HP 250 G2", 699);

            laptops = new List<Laptop>() { acerAspire, lenovo, toshiba, hp };  

            foreach (var laptop in laptops)
            {
                Console.WriteLine(laptop.ToString());
                Console.WriteLine();
            }
        }
    }
}
