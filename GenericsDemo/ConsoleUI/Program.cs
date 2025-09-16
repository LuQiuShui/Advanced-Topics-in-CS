using System;
using DemoLibrary;
using System.Text.Json;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            DemonstrateTextFileStorage();

            Console.WriteLine();
            Console.Write("Press enter to shut down...");
            Console.ReadLine();
        }

        private static List<T> JsonToList<T>(string jsonfile) where T : class
        {
            string json = File.ReadAllText(jsonfile);
            return JsonSerializer.Deserialize<List<T>>(json);
        }

        private static void DemonstrateTextFileStorage()
        {
            string peopleFile = "people.csv";
            string logFile = "logs.csv";

            string peopleJson = "people.json";
            string logJson = "logs.json";

            List<Person> people = JsonToList<Person>(peopleJson);
            List<LogEntry> logs = JsonToList<LogEntry>(logJson);

            GenericTextFileProcessor.SaveToTextFile<Person>(people, peopleFile);
            GenericTextFileProcessor.SaveToTextFile<LogEntry>(logs, logFile);

            var newPeople = GenericTextFileProcessor.LoadFromTextFile<Person>(peopleFile);

            foreach (var p in newPeople)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
            }

            var newLogs = GenericTextFileProcessor.LoadFromTextFile<LogEntry>(logFile);

            foreach (var log in newLogs)
            {
                Console.WriteLine($"{log.ErrorCode}: {log.Message} at {log.TimeOfEvent.ToShortTimeString()}");
            }
        }
    }
}