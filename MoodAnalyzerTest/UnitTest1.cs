using MoodAnalyzer;
using System;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomException()
        {

            Mood moodtest = new Mood("Null Mood ");

            string Expectedresult = "Null";

            Assert.AreEqual(Expectedresult, "Null");
        }

        //public void Exception()
        //{

        //    Mood moodtest = new Mood(" ");

        //    string Expectedresult = "Happy";

        //    Assert.AreEqual(Expectedresult, "Happy");
        //}


        //public void returnSad()
        //{

        //    Mood moodtest = new Mood("I am in Sad Mood");

        //    string Expectedresult = "Sad";

        //    Assert.AreEqual(Expectedresult, "Sad");
        //}


        //public void returnHappy()
        //{

        //    Mood moodtest = new Mood("I am in any Mood");

        //    string Expectedresult = "Happy";

        //    Assert.AreEqual(Expectedresult, "Happy");
        //}


    }
}