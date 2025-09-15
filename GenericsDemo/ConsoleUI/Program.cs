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

        private static void JsonToList(List<Person> people,List<LogEntry> logs,string peopleJson, string logJson)
        {
            using JsonDocument doc = new JsonDocument();
        }

        private static void DemonstrateTextFileStorage()
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            string peopleFile = "people.csv";
            string logFile = "logs.csv";

            string peopleJson = "people.json";
            string logJson = "logs.json";

            JsonToList(people, logs, peopleJson, logJson);

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