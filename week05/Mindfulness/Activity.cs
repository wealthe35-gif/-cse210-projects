using System;
using System.Collections.Generic;
using System.Threading;
public class Activity
{
  private string _name;
  private string _description;
  private int _duration;

  public Activity(string name, string description, int duration)
  {
    _name = name;
    _description = description;
    _duration = duration;
  }

  public string GetName()
  {
    return _name;
  }

  public string GetDescription()
  {
    return _description;
  }

  public int GetDuration()
  {
    return _duration;
  }

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to {_name}");
    Console.WriteLine(_description);

    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());
  }

  public void DisplayEndingMessage()
{
  Console.WriteLine("Well done!");
  Console.WriteLine($"You have completed {_name}.");
  Console.WriteLine($"You spent {_duration} seconds on this activity.");
}

public void ShowSpinner(int seconds)
{
  List<string> animation = new List<string>();
  animation.Add("|");
  animation.Add("/");
  animation.Add("-");
  animation.Add("\\");

  DateTime startTime = DateTime.Now;

  while ((DateTime.Now - startTime).TotalSeconds < seconds)
  {
    foreach (string s in animation)
    {
      Console.Write(s);
      Thread.Sleep(250);
      Console.Write("\b");
    }
  }
}

public void ShowCountDown(int seconds)
{
  for (int i = seconds; i > 0; i--)
  {
    Console.Write(i);
    Thread.Sleep(1000);
    Console.Write("\b \b");
  }
}

}