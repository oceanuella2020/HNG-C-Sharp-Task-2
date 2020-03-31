using System;
using System.Collections.Generic;



namespace HNG_C_Sharp_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string choice;
            int number;
            int price;
            

            string[] fruits = new string[] { "orange", "banana", "cashew", "pawpaw", "pineapple", "grape", "apple" };

            List<string> vegetable = new List<string>();
            vegetable.Add("onion");
            vegetable.Add("carrot");
            vegetable.Add("spinach");
            vegetable.Add("eggplant");
            vegetable.Add("lettuce");


            Console.WriteLine("Good day. Welcome to Ocean's farm. We Grow the Freshest and Healthiest Fruits in Nigeria.");
            Console.WriteLine("We have "+fruits.Length +" fruits and  "+vegetable.Count+ " Vegetables available.");
            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);
            Console.WriteLine(fruits[3]);
            Console.WriteLine(fruits[4]);
            Console.WriteLine(fruits[5]);
            Console.WriteLine(fruits[6]);
            Console.WriteLine(vegetable[0]);
            Console.WriteLine(vegetable[1]);
            Console.WriteLine(vegetable[2]);
            Console.WriteLine(vegetable[3]);
            Console.WriteLine(vegetable[4]);

            Console.WriteLine("Which of this fruits or vegetables would you like. We sell them in kilograms and at an affordable price.");
            choice=Console.ReadLine();

            if (choice == fruits[0])
            {
                price = 150;
                Console.WriteLine("How many kg do you want?");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("That will be # " + (price*number).ToString()+ " . Have a great Day ahead.");
            }
            else if (choice == fruits[1])
            {
                price= 100;
                Console.WriteLine("How many kg do you want?");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("That will be #" + (price * number).ToString() + " . Have a nice Day ahead.");
            }
            else if (choice == fruits[2])
            {
                price = 100;
                Console.WriteLine("How many kg do you want?");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("That will be #" + (price * number).ToString() + " . Have a great Day ahead.");
            }
            else if (choice == fruits[3])
            {
                price = 150;
                Console.WriteLine("How many kg do you want?");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("That will be #" + (price * number).ToString() + " . Have a awesome Day ahead.");
            }
            else if (choice == fruits[4])
            {
                price = 250;
                Console.WriteLine("How many kg do you want?");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("That will be #" + (price * number).ToString() + " . Have a blessed Day ahead.");
            }
            else if (choice == fruits[5])
            {
                price = 50;
                Console.WriteLine("How many kg do you want?");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("That will be #" + (price * number).ToString() + " . Have a awesome Day ahead.");
            }
            else if (choice == fruits[6])
            {
                price = 400;
                Console.WriteLine("How many kg do you want?");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("That will be #" + (price * number).ToString() + " . Have a nice Day ahead.");
            }
            else if (choice == vegetable[0])
            {
                price = 150;
                Console.WriteLine("How many kg do you want?");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("That will be #" + (price * number).ToString() + " . Have a glorious Day ahead.");
            }
            else if (choice == vegetable[1])
            {
                price = 250;
                Console.WriteLine("How many kg do you want?");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("That will be #" + (price * number).ToString() + " . Have a great Day ahead.");
            }
            else if (choice == vegetable[2])
            {
                price = 150;
                Console.WriteLine("How many kg do you want?");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("That will be #" + (price * number).ToString() + " . Have a blessed Day ahead.");
            }
            else if (choice == vegetable[3])
            {
                price = 100;
                Console.WriteLine("How many kg do you want?");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("That will be #" + (price * number).ToString() + " . Have a awesome Day ahead.");
            }
            else if (choice == vegetable[4])
            {
                price = 50;
                Console.WriteLine("How many kg do you want?");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("That will be #" + (price * number).ToString() + " . Have a good Day ahead.");
            }
            else
            {
                Console.WriteLine("We don't have that in stock for now. You can check back some other time.");
                Console.WriteLine("Thank You for coming.");
            }

            Console.ReadKey();

        }
    }
}
