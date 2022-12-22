using MoodAnalyzer;
using System;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            Mood moodtest = new Mood();
            string Expectedresult = "Sad";
            //act
            string Actualresult = moodtest.AnalyseMood("Sad");

            //assert
            Assert.AreEqual(Expectedresult, Actualresult);
        }
    }
}