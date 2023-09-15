using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        

    
    Random randomGenerator = new Random();
    int magicnumber = randomGenerator.Next (1,101);
    
    int guess = -1;

    while (guess != magicnumber)
    {
          Console.Write("What is your guess");
          guess = int.Parse(Console.ReadLine());
        if (magicnumber > guess)
        {
          Console.Write("Higher");
        }
        else if (magicnumber < guess)
        {
          Console.Write("lower");
        }
        else 
        {
          Console.WriteLine("You guessed it!");
        }
    }
  }
}  