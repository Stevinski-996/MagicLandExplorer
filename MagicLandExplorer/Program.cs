using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MagicLandExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("Data/data.json");
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            bool exit = false;

while (!exit)
{
    Console.WriteLine("Magic Land Explorer");
    Console.WriteLine("1- Show filtered destinations (duration < 100 minutes)");
    Console.WriteLine("2- Show destination with the longest duration");
    Console.WriteLine("3- Sort destinations by name");
    Console.WriteLine("4- Show top 3 longest-duration destinations");
    Console.WriteLine("5- Exit");
    Console.Write("Choose an option: ");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            FilterDestinations.SortedDestinations(categories);
            break;
        case "2":
            LongestDuration.LongestDure(categories);
            break;
        case "3":
            SortByName.NameSort(categories);
            break;
        case "4":
            Top3Duration.TopDurations(categories);
            break;
        case "5":
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}
        }
    }
}