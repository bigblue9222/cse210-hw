using System;



class Program
{
    static void Main(string[] args)
    {
    List<int> numbers = new List<int>();
    int userNumnber = -2;
    while (userNumnber != 0)
    {
      Console.Write("Enter a number (0 to quit): ");
      string userResponse = Console.ReadLine();
      userNumnber = int.Parse(userResponse);
      if (userNumnber !=0)
      {
         numbers.Add(userNumnber);
      }
    }   
    int sum = 0;
    foreach (int number in numbers)
    {
      sum += number;
    }
    Console.WriteLine($"The sum is: {sum}");
    int max = numbers[0];
    foreach (int number in numbers)
    {
      if (number> max)
      {
         max = number;
      }
    }
    Console.WriteLine($"The max is:{max}");     
    }           
}
