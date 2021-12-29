using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a madlib game
      Author: Douglas Peterson
      */


      // Let the user know that the program is starting:


      // Give the Mad Lib a title:
      string title = "Mad Lib";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("\nEnter a Name:");
      string name = Console.ReadLine();
      Console.WriteLine("Enter an Adjective:");
      string adjectiveOne= Console.ReadLine(); 
 

 Console.WriteLine("Enter another Adjective:");
string adjectiveTwo = Console.ReadLine(); 

Console.WriteLine("Enter another Adjective:");
string adjectiveThree = Console.ReadLine(); 

Console.WriteLine("Enter A Verb:");
string verb = Console.ReadLine(); 

Console.WriteLine("Enter A Noun:");
string nounOne = Console.ReadLine(); 

Console.WriteLine("Enter A second Noun:");
 
 Console.WriteLine("Enter An Animal:");
string animal = Console.ReadLine();
Console.WriteLine("Enter A food:");
string food = Console.ReadLine();
Console.WriteLine("Enter A fruit:");
string fruit  = Console.ReadLine();
Console.WriteLine("Enter A Super Hero:");
string superHero = Console.ReadLine();
Console.WriteLine("Enter A country:");
string country = Console.ReadLine();
Console.WriteLine("Enter A dessert:");
string dessert  = Console.ReadLine();
Console.WriteLine("Enter A year:");
string year  = Console.ReadLine();



string nounTwo = Console.ReadLine(); 
      string story = $"This morning {name} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree} Concerned, {name} texted {superHero}, who flew {name} to {country} and dropped {dessert} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";

Console.WriteLine(story);
      // Print the story:

    }
  }
}
