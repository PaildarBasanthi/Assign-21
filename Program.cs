using System;
using System.Collections.Generic;
using System.Threading;

namespace KidsLearningSystem
{
    class Program
    {
        // Lists
        static List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Grapes", "Mango", "Strawberry", "Watermelon", "Pineapple", "Cherry", "Peach" };
        static List<string> days = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        static List<string> months = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        // Dictionary
        static Dictionary<string, string> wordMeanings = new Dictionary<string, string>
        {
            { "happy", "feeling or showing pleasure or contentment" },
            { "sad", "feeling or showing sorrow" },
            { "angry", "feeling or showing strong annoyance, displeasure, or hostility" },
            { "friendly", "kind and pleasant" },
            { "brave", "ready to face and endure danger or pain" }
        };

        static void DisplayDays()
        {
            foreach (var day in days)
            {
                Console.WriteLine($"Today is {day}");
                Thread.Sleep(14000);
            }
        }

        static void DisplayMonths()
        {
            Thread.Sleep(5000);
            foreach (var month in months)
            {
                Console.WriteLine($"Current month is {month}");
               Thread.Sleep(2000);
            }
        }

        static void DisplayFruitsAndWords()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\nList of Fruits:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
                 Thread.Sleep(1000);
            }

            Console.WriteLine("\nDictionary of Words and Meanings:");
            foreach (var word in wordMeanings)
            {
                Console.WriteLine($"{word.Key}: {word.Value}");
                Thread.Sleep(1000);
            }
        }

        static void Main()
        {
            Console.WriteLine("-----------------Welcome to Learning----------------------");

            Thread threadDays = new Thread(DisplayDays);
            Thread threadMonths = new Thread(DisplayMonths);
            Thread threadFruitsAndWords = new Thread(DisplayFruitsAndWords);

            threadDays.Start();
            threadMonths.Start();
            threadFruitsAndWords.Start();
        }
    }
}

