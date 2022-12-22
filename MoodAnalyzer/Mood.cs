using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyzer;

namespace MoodAnalyzer
{
    public class Mood
    {
        public string analyze;
        public Mood(string analyze)
        {
            this.analyze= analyze;

        }
        public string AnalyzeMood()
        {
            if (this.analyze.Contains("Sad"))
            {
                Console.WriteLine("Sad");
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }

    }
}
