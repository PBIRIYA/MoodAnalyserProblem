using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMoodAnalyser
{
    [TestClass]
    public class MoodAnalyser
    {
        [TestMethod]
        public void Test1Case1()
        {
            //Arrage
            MoodAnalyser analyser = new MoodAnalyser();
            //Act
            string result1 = analyser.analyseMood("I am in Sad Mood");
            //Assert
            Assert.AreEqual("SAD", result1);
        }
    }
}