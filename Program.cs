using System;
class Program
{
    static void Main()
    {

        //console.write("enter your name: ");
        //string name = console.readline();
        //console.write("enter your specialty: ");
        //string specialty = console.readline();
        //console.write("enter your age: ");
        //int age = int.parse(console.readline());
        //console.writeline($"welcome {name}, your specialty is {specialty} and you are {age} years old.");

    
        
            Console.Write("Enter Product Name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            int quan = int.Parse(Console.ReadLine());

            Console.WriteLine("Select Currency:");
            Console.WriteLine("1. Dollar $");
            Console.WriteLine("2. Shekel ₪");
            Console.Write("Enter choice (1/2): ");
            int currencyChoice = int.Parse(Console.ReadLine());

            string currencySymbol;
            switch (currencyChoice)
            {
                case 1: currencySymbol = "$"; break;
                case 2: currencySymbol = "₪"; break;
                default: currencySymbol = "$"; break;
            }

            Console.Write("Enter Unit Price: ");
            decimal unPrice = decimal.Parse(Console.ReadLine());

            decimal totPrice = quan * unPrice;
            decimal discount;
            decimal netTot;

            if (totPrice > 100)
            {
                discount = totPrice * 0.10m;
            }
            else
            {
                discount = 0;
            }

            netTot = totPrice - discount;

            Console.WriteLine($"Product    => {Name}");
            Console.WriteLine($"Quantity   => {quan}");
            Console.WriteLine($"Unit Price => {currencySymbol}{unPrice:F2}");
            Console.WriteLine($"Total      => {currencySymbol}{totPrice:F2}");
            Console.WriteLine($"Discount   => {currencySymbol}{discount:F2}");
            Console.WriteLine($"Net Total  => {currencySymbol}{netTot:F2}");
        }
    } 
