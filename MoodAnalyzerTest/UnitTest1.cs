using MoodAnalyzer;
using System;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void returnSad()
        {

            Mood moodtest = new Mood("I am in Sad Mood");

            string Expectedresult = "Sad";

            Assert.AreEqual(Expectedresult, "Sad");
        }
    }
}