using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzeFactory
    {
        public static object CreateMoodAnalyze(string ClassName, string ConstructorName)
        {
            string pattern = @"." + ConstructorName + "$";
            Match result = Regex.Match(pattern, ClassName);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type MoodAnalyzeType = executing.GetType(ClassName);
                    return Activator.CreateInstance(MoodAnalyzeType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodException(MoodException.NullMoodErrors.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodException(MoodException.NullMoodErrors.NO_SUCH_METHOD, "Class Not Found");
            }
        }
    }
}