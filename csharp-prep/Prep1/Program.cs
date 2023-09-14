using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        String first = Console.ReadLine();
        Console.WriteLine(first);
        Console.Write("What is your last name? ");
        String last = Console.ReadLine();
        Console.WriteLine($"You name is {last},{first} {last}");
    }

}    