using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodException : Exception
    {
        NullMoodErrors error;

        public MoodException(NullMoodErrors error, string analyze)
        {
            super(analyze);
            this.error = error;
        }

        private void super(string analyze)
        {
            throw new NotImplementedException();
        }

        public enum NullMoodErrors
        {
            NULLMOOD, EMPTYMOOD,
            NO_SUCH_CLASS, NO_SUCH_FIELD,
            NO_SUCH_METHOD, OBJECT_CREATION_ISSUE
        }
    }
}
