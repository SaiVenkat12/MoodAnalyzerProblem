using MoodAnalyzer;
using System;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void returnproperobject()
        {
            try
            {

                Mood analyze = new Mood("should return mood analysis object");
                string input = null;
                object expected = new Mood(input);
                object obj = MoodAnalyzefactory.CreateParameterizedConstrucor("Mood", "Mood", "Sad");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //public void parameterconstructor()
        //{
        //    try
        //    {

        //        Mood analyze = new Mood("should return mood analysis object");
        //        string input = null;
        //        object expected = new Mood(input);
        //        object obj = MoodAnalyzefactory.CreateParameterizedConstrucor("Mood", "Mood");
        //        expected.Equals(obj);
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //}

        //public void returnobject()
        //{
        //    try
        //    {
        //        object expected = new Mood();
        //        object obj = MoodAnalyzerFactory.CreateMoodAnalyze("Mood", "Mood");
        //        expected.Equals(obj);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }


        //}

        //public void CustomException()
        //{
        //try 
        //{
        // string analyze = null;
        //Mood Moodanalyze = new Mood();
        //string mood = Moodanalyze.AnalyzeMood("");
        //}                 
        //catch (Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        //}


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