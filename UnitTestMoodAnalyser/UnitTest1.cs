using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserProblem;
namespace UnitTestMoodAnalyser
{
    [TestClass]
    public class UnitTestMoodAnalyser
    {
        [TestMethod]
        public void GivenMood_ReturnSad()
        {
            string expected = "SAD";
            string message = "I am Sad now";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
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
