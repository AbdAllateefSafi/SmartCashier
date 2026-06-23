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

        // 1. User Input
        Console.Write("Enter Product Name: ");
        string Name = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        int quan = int.Parse(Console.ReadLine());

        Console.Write("Enter Unit Price: $");
        decimal unPrice = decimal.Parse(Console.ReadLine());

        // 2. Business Logic
        decimal totPrice = quan * unPrice;
        decimal discount;
        decimal netTot;

        // 3. if/else للخصم
        if (totPrice > 100)
        {
            discount = totPrice * 0.10m;
        }
        else
        {
            discount = 0;
        }

        netTot = totPrice - discount;

        // 4. Output
        Console.WriteLine($"اسم المنتج    => {Name}");
        Console.WriteLine($"الكمية   => {quan}");
        Console.WriteLine($"وحدة السعر => ${unPrice:F2}");
        Console.WriteLine($"السعر الكلي      => ${totPrice:F2}");
        Console.WriteLine($"الخصم   => ${discount:F2}");
        Console.WriteLine($"السعر الجديد بعد الخصم  => ${netTot:F2}");
    }
}
      

