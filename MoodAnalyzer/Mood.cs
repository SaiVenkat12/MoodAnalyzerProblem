using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Mood
    {
        public string AnalyseMood(string mood)
        {
            if (mood.Contains("Sad"))
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
