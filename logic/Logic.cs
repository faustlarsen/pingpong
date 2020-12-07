using System;
using PingPong;

public class Logic
{
    public string UserInput{get; set;}
    
    public Logic(string userInput)
    {
      UserInput = userInput;
    }
    public string GetUserInput()
    {
      return UserInput;
    }
    
    public void SetUserInput(string userInput)
    {
      int intUserInput = int.Parse(userInput);
      for (int i = 1; i <= intUserInput; i++)
      if (i % 15 == 0)
      {
      UserInput = "Ping Pong";
      }
      else if ( i % 3 == 0)
      {
      UserInput = "Ping";
      }
      else if (i % 5 == 0)
      {
      UserInput = "Pong";
      }
      else
      { 
      UserInput = Convert.ToString(i);
      } 
    }  
}