using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { -20, 15, -10, 17, 22, 35, 50, 75, 100, 3, 99, 58 };
        var positiveTwoDigits = numbers.Where(n => n >= 10 && n <= 99).OrderBy(n => n).ToList();

        Console.WriteLine(string.Join(", ", positiveTwoDigits));

        Console.WriteLine("Натиснiть будь-яку клавiшу для виходу...");
        Console.ReadLine();
    }
}
