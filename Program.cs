using System;

namespace PingPong {

  public class Program
  {
    public static void Main() 
    {
      Console.WriteLine("Enter the number");
      string number = Console.ReadLine();
      int intNumber = int.Parse(number);
      for(int index = 0; index <= intNumber; index++)
      {
        if (index % 15 == 0)
        {
          Console.WriteLine("Ping-Pong");
        }
        else if (index % 5 == 0)
        {
          Console.WriteLine("Ping");
        }
        else if (index % 3 == 0)
        {
          Console.WriteLine("Pong");
        }
        else 
        {
          Console.WriteLine(index);
        }
      }
    }
  } 
}