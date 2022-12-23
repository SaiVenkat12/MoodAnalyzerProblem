using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyzer.MoodException;

namespace MoodAnalyzer
{
    public class Mood
    {
        public string analyze;
        public Mood(string analyze)
        {
            this.analyze = analyze;

        }


        public string AnalyzeMood()
        {
            try
            {
                if (analyze.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (ArgumentNullException n)
            {
                return "happy";
            }

        }

            public string AnalyzeMood3()
            {
                try
                {
                    if (this.analyze.ToLower().Contains("sad"))
                    {
                        return "Sad";
                    }
                    else if (analyze.Contains(" "))
                    {
                        throw new MoodException(NullMoodErrors.EMPTYMOOD, "The String is Null!");
                    }
                    else
                    {
                        return "Happy";
                    }
                }
                catch (Exception e)
                {
                    throw new MoodException(NullMoodErrors.NULLMOOD, "Enter something!");
                }

            }
    }
}
