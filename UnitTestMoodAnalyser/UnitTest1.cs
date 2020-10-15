using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
namespace UnitTestMoodAnalyser
{
    [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void GivenMood_ReturnSad()
            {
            //Arrange
            string expected = "SAD";
            string message = "I am Sad now";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string mood = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, mood);
            }

            [TestMethod]
            public void AnalyzeHappyMood()
            {
            //Arrange
            string message = "I am in Any Mood";
            string expectedMood = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string actualMood = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expectedMood, actualMood);
            }
        }
}
