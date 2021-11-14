using System;

string room = "highroad";

while (room != "end")
{
  if (room == "highroad")
  {
    Console.WriteLine("You are now on the High Road. In front of you is a small sideroad, leading to the Low Road.");

    Console.WriteLine("Where do you want to go?");
    string where = Console.ReadLine();

    if (where == "down")
    {
      room = "lowroad";
    }
    else
    {
      Console.WriteLine("I'm sorry, what?");
    }
  }
  else if (room == "lowroad")
  {
    Console.WriteLine("You are now on the Low Road. In front of you is a small stairway, leading up to the High Road.");

    Console.WriteLine("Where do you want to go?");
    string where = Console.ReadLine();

    if (where == "up")
    {
      room = "highroad";
    }
    else
    {
      Console.WriteLine("I'm sorry, what?");
    }
  }
}