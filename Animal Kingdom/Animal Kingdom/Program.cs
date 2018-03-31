/*
 * Author: Nicholas MercuryQ
 * Purpose: This application demonstrates C# OOP inheritance concepts
 * Date Created: 3/21/2018
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Animal_Kingdom
{
    class Program
    {
        static void Main()
        {
            // Making a new fox object
            Fox ArticFox = new Fox();
            ArticFox.setAnimal("Artic Fox");
            ArticFox.setAge(2);
            ArticFox.setFood("Rabbits!");
            ArticFox.setLocation("Alaska");

            // Making a new tiger object
            Tiger BangalTiger = new Tiger();
            BangalTiger.setAnimal("Bangal Tiger");
            BangalTiger.setAge(5);
            BangalTiger.setFood("MEAT!");
            BangalTiger.setLocation("Asia");

            // Making a new bat object
            Bat EFBat = new Bat();
            EFBat.setAnimal("Egyptian Fruit Bat");
            EFBat.setAge(3);
            EFBat.setFood("Yummy fruit!");
            EFBat.setLocation("Africa");
           
            Console.WriteLine("Animal Kingdom Information");
            Console.WriteLine("--------------------------");

            // Print fox object
            Console.WriteLine(ArticFox.getFoxType());
            Console.WriteLine("Age: " + ArticFox.getAge() + " years old");
            Console.WriteLine(ArticFox.getFoxLoc());
            Console.WriteLine(ArticFox.getFoxFood());
            Console.WriteLine("--------------------------");

            // Print tiger object
            Console.WriteLine(BangalTiger.getTigerType());
            Console.WriteLine("Age: " + BangalTiger.getAge() + " years old");
            Console.WriteLine(BangalTiger.getTigerLoc());
            Console.WriteLine(BangalTiger.getTigerFood());
            Console.WriteLine("--------------------------");

            // Print bat object
            Console.WriteLine(EFBat.getBatType());
            Console.WriteLine("Age: " + EFBat.getAge() + " years old");
            Console.WriteLine(EFBat.getBatLoc());
            Console.WriteLine(EFBat.getBatFood());
            Console.WriteLine("--------------------------");

            // Exit app
            Console.WriteLine("Press any Key to end program!");
            Console.ReadKey();
            

        }
    }
}
