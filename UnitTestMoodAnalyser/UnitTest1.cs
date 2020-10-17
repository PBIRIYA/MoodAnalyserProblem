using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserProblem;
namespace UnitTestMoodAnalyser
{
    [TestClass]
    public class UnitTestMoodAnalyser
    {
        [TestMethod]
        public void when_pass_I_am_Sad_should_return_Sad()
        {
<<<<<<< HEAD
            //Arrange
            string msg = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);
            string expectedMood = "SAD";
<<<<<<< HEAD
=======
            //Arrage
            MoodAnalyser analyser = new MoodAnalyser();
>>>>>>> UC2_HandleNullException
            //Act
            string result1 = analyser.AnalyseMood("I am in Sad Mood");
=======
            //Act
            string actualMood = moodAnalyser.AnalyseMood();
>>>>>>> UC3_CustomException
            //Assert
            Assert.AreEqual("SAD", result1);
        }

        [TestMethod]
        public void when_pass_I_am_Happy_should_return_happy()
        {
<<<<<<< HEAD
            //Arrange
            string msg = "I am in Any Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);
            string expectedMood = "HAPPY";
<<<<<<< HEAD
=======
            //Arrage
            MoodAnalyser analyser = new MoodAnalyser();
>>>>>>> UC2_HandleNullException
            //Act
            string result2 = analyser.AnalyseMood("I am in Any Mood");
=======
            //Act
            string actualMood = moodAnalyser.AnalyseMood();
>>>>>>> UC3_CustomException
            //Assert
            Assert.AreEqual("HAPPY", result2);
        }

        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_NullException()
        {
            try
            {
                string msg = null;
                MoodAnalyser analyser = new MoodAnalyser();
                string mood = analyser.AnalyseMood(msg);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Value cannot be null", e.Message);
            }
        }

        [TestMethod]
        public void AnalyzeNullExceptionHandling()
        {
            //Arrange
            string msg = null;
<<<<<<< HEAD
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(msg);
=======
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);
>>>>>>> UC3_CustomException
            //Act => Assert
            Assert.ThrowsException<MoodAnalyserCustomException>(() => moodAnalyser.AnalyseMood());
        }

        [TestMethod]
        public void AnalyzeNullExceptionMessage()
        {
            //Arrange
            string msg = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);
            string expectedMsg = "NULL";
            string actualMsg = "";
            //Act
            try
            {
                actualMsg = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException exception)
            {
                actualMsg = exception.Message;
            }
            //Assert
            Assert.AreEqual(expectedMsg, actualMsg);
        }

        [TestMethod]
        public void AnalyzeEmptyExceptionHandling()
        {
            //Arrange
            string msg = "";
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);
            //Act => Assert
            Assert.ThrowsException<MoodAnalyserCustomException>(() => moodAnalyser.AnalyseMood());
        }

        [TestMethod]
        public void AnalyzeEmptyExceptionMessage()
        {
            //Arrange
            string msg = "";
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);
            string expectedMsg = "EMPTY";
            string actualMsg = "";
            //Act
            try
            {
                actualMsg = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException exception)
            {
                actualMsg = exception.Message;
            }
            Assert.AreEqual(expectedMsg, actualMsg);
        }
    }
}
