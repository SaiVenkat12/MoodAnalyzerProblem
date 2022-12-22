using MoodAnalyzer;
using System;

namespace MoodAlalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am in a Sad Mood");

            string analyze = Console.ReadLine();
            Mood Moodanalyze = new Mood(analyze);
            Console.WriteLine(Moodanalyze.AnalyzeMood());
        }
    }
}