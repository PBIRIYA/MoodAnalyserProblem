using Microsoft.VisualStudio.TestTools.UnitTesting;
<<<<<<< HEAD
using MoodAnalyserProblem;
<<<<<<< HEAD


namespace UnitTestProject1
=======
using System;
using MoodAnalyserProblem;
namespace UnitTestMoodAnalyser
>>>>>>> UC2_HandleNullException
{
    [TestClass]
    public class MoodAnalyser
    {
<<<<<<< HEAD
        [TestMethod]
        public void GivenMood_ReturnSad()
        {
            string expected = "SAD";
            string message = "I am Sad now";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);

=======
        public MoodAnalyser(string msg)
        {
>>>>>>> UC2_HandleNullException
        }

        [TestMethod]
<<<<<<< HEAD
        public void GivenMood_ReturnHappy()
        {

            string expected = "HAPPY";
            string message = "I am in any mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);


        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Given_ShouldThrowEmptyValue()
        {
            try
            {
                string message = "";
                MoodAnalyzerCustomerException moodAnalyzer = new MoodAnalyzerCustomerException(message);
                string mood = moodAnalyzer.AnalyseMood();


            }
            catch (MoodAnalyzerCustomerException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }

        }
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyzerCustomerException moodAnalyse = new MoodAnalyzerCustomerException(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyzerCustomerException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
=======
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

<<<<<<< HEAD
>>>>>>> UC1_CreateAbility
=======
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
>>>>>>> UC1_CreateAbility
            }
        }
=======
        public void AnalyzeSadMood()
        {
            //Arrange
            string msg = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);
            string expectedMood = "SAD";
            //Act
            string actualMood = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expectedMood, actualMood);
        }

        [TestMethod]
        public void AnalyzeHappyMood()
        {
            //Arrange
            string msg = "I am in Any Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);
            string expectedMood = "HAPPY";
            //Act
            string actualMood = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expectedMood, actualMood);
        }
    }
>>>>>>> UC2_HandleNullException
}
