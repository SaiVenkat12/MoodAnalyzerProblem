using MoodAnalyzer;
using System;
namespace MoodAlalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mood moodAnalyser = new Mood();
            moodAnalyser.AnalyseMood("I am in Sad Mood");
        }
    }
}