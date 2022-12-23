using MoodAnalyzer;
using System;

namespace MoodAlalyzer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyzer");

            string analyze = Console.ReadLine();

          // Mood Moodanalyze = new("I am in any mood");
            Mood Moodanalyze = new Mood(analyze);
            Console.WriteLine(Moodanalyze.AnalyzeMood());            
            Console.WriteLine(Moodanalyze.AnalyzeMood3());

        }
    }
}