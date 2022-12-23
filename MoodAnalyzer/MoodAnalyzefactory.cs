using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyzer;

namespace MoodAnalyzer
{
    public class MoodAnalyzefactory
    {
        public static object CreateParameterizedConstrucor(string ClassName, string ConstructorName, string analyze)
        {

            Type type = typeof(Mood);
            if (type.Name.Equals(ClassName) || type.FullName.Equals(ClassName))
            {
                if (type.Name.Equals(ConstructorName))
                {
                    ConstructorInfo info = type.GetConstructor(new[] { typeof(string) });
                    object instance = info.Invoke(new object[] { "Happy" });
                    return instance;
                }
                else
                {
                    throw new MoodException(MoodException.NullMoodErrors.NO_SUCH_METHOD, "Constructure is not found");
                }
            }
            else
            {
                throw new MoodException(MoodException.NullMoodErrors.NO_SUCH_CLASS, "Class not found");
            }
        }

        public static object CreateParameterizedConstrucor(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}