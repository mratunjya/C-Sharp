using System;

namespace _2.__Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string aFriend;
            aFriend = "Mratunjya";
            Console.WriteLine(aFriend);

            Console.WriteLine("Hello " + aFriend);

            aFriend = "Harsh";
            Console.WriteLine($"Hello {aFriend}");



            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");



            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");



            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);



            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));



            songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));



            var name = "Mratunjya";
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }
    }
}