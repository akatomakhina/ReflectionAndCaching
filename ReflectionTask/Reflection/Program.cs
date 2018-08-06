using Reflection.Cakes;
using Reflection.Cakes.Cream;
using Reflection.Cakes.Layers;
using System;
using System.Collections.Generic;

namespace Reflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10;
            int b = 20;
            int c = 10;
            string stringA = "Aaa";
            string stringB = "Bbb";
            string stringC = "Aaa";*/
            ChocolateCream chocoOne = new ChocolateCream("100 milliliters", "250 grams", "3 tablespoons", "300 grams", "120 grams");
            ChocolateCream chocoTwo = new ChocolateCream("100 milliliters", "250 grams", "3 tablespoons", "300 grams", "120 grams");
            ChocolateCream chocoThree = new ChocolateCream("120 milliliters", "300 grams", "1,5 tablespoons", "300 grams", "120 grams");
            SourcreamCream sourCreamOne = new SourcreamCream("500 grams of 25% sour cream", "250 grams");
            SourcreamCream sourCreamTwo = new SourcreamCream("500 grams of 25% sour cream", "250 grams");
            SourcreamCream sourCreamThree = new SourcreamCream("800 grams of 20% sour cream", "250 grams");
            Shortbread shortbreadOne = new Shortbread("2 glasses", "70 grams", "150 grams", 3, "5 grams");
            Shortbread shortbreadTwo = new Shortbread("300 grams", "70 grams", "150 grams", 3, "5 grams");
            Shortbread shortbreadThree = new Shortbread("3 glasses", "100 grams", "200 grams", 4, "5 grams");
            CakeWithCherry cakeWithCherryOne = new CakeWithCherry(sourCreamOne, shortbreadOne, "300 grams");
            CakeWithCherry cakeWithCherryTwo = new CakeWithCherry(sourCreamTwo, shortbreadOne, "450 grams");
            CakeWithCherry cakeWithCherryThree = new CakeWithCherry(sourCreamThree, shortbreadOne, "500 grams");
            CakeWithCherry cakeWithCherryFour = new CakeWithCherry(sourCreamOne, shortbreadTwo, "500 grams");
            CakeWithCherry cakeWithCherryFive = new CakeWithCherry(sourCreamOne, shortbreadTwo, "300 grams");
            CakeWithCherry cakeWithCherrySix = new CakeWithCherry(sourCreamOne, shortbreadThree, "350 grams");
            CakeWithCherry cakeWithCherrySeven = new CakeWithCherry(sourCreamOne, shortbreadThree, "450 grams");

            List<CakeWithCherry> cakesListOne = new List<CakeWithCherry>();
            Bakery bakeryOne = new Bakery(cakesListOne);
            List<CakeWithCherry> cakesListTwo = new List<CakeWithCherry>();
            Bakery bakeryTwo = new Bakery(cakesListTwo);
            List<CakeWithCherry> cakesListThree = new List<CakeWithCherry>();
            Bakery bakeryThree = new Bakery(cakesListThree);

            bakeryOne.Add(cakeWithCherryOne);
            bakeryOne.Add(cakeWithCherryTwo);
            bakeryOne.Add(cakeWithCherryThree);
            bakeryOne.Add(cakeWithCherryFour);
            bakeryTwo.Add(cakeWithCherryFive);
            bakeryTwo.Add(cakeWithCherrySix);
            bakeryTwo.Add(cakeWithCherrySeven);
            bakeryThree.Add(cakeWithCherryOne);
            bakeryThree.Add(cakeWithCherryTwo);
            bakeryThree.Add(cakeWithCherryThree);
            bakeryThree.Add(cakeWithCherryFour);

            Console.WriteLine(ReflectionComparer.ReflectionWithComparer(bakeryOne, bakeryThree));
            Console.ReadLine();
        }
    }
}
