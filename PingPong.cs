using System;

class PingPong
{

  static void Main()
  {
    Console.WriteLine("Enter a number:");
    string stringUserNumber = Console.ReadLine();
    int userNumber = int.Parse(stringUserNumber);
    for (int index = 1; index <= userNumber; index++)
    {
      if ((index % 3 == 0) && (index %5 ==0))
      {
        Console.WriteLine("Ping Pong");
      }
      else if (index % 5 == 0)
      {
        Console.WriteLine("Pong!");
      }
      else if (index % 3 == 0)
      {
        Console.WriteLine("Ping!");
      }
      else
      {
        Console.WriteLine(index);
      }
    }
  }
}