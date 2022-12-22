using MoodAnalyzer;
using System;

namespace MoodAlalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyzer");

            string analyze = Console.ReadLine();


           Mood Moodanalyze = new Mood("I am in Sad Mood");
            Console.WriteLine(Moodanalyze.AnalyzeMood());
        }
    }
}