using System;
using System.Collections.Generic;

class Sphinx
{
  public static Dictionary<int, string> questions = new Dictionary<int, string>() { {0, "What has a head, a tail, is brown, and has no legs?"}, {1, "The more you take, the more you leave behind. What am I?"}, {2, "What room do ghosts avoid?"} };
  public static Dictionary<int, string> answers = new Dictionary<int, string>() { {0, "a penny"}, {1, "footsteps"}, {2, "the living room"} };
  public static int index = 0;
  
  static void Main()
  {
    RandomNumber();
    Console.WriteLine(questions[index]);
    string userInput = Console.ReadLine().ToLower();

    if(userInput == answers[index])
    {
      Console.WriteLine("The sphinx have been defeated!");
    }
    else
    {
      Console.WriteLine("You have been defeated");
    }
  }

  static void RandomNumber()
  {
    Random random = new Random();
    index = random.Next(0, 3);
  }
}