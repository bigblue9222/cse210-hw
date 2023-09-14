using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        String letter = "";
        if (percent >= 90)
        { 
            letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }    
        else if (percent >= 70)
        {    
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "f";
        }        

        Console.WriteLine($"Your grade is: {letter}");   
        
        if (percent >= 70)
        {
           Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }    
    }
}