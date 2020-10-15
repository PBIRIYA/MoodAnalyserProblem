using Microsoft.VisualStudio.TestTools.UnitTesting;
<<<<<<< HEAD
using MoodAnalyserProblem;
<<<<<<< HEAD

<<<<<<< HEAD

namespace UnitTestProject1
=======
using System;
using MoodAnalyserProblem;
namespace UnitTestMoodAnalyser
>>>>>>> UC2_HandleNullException
=======
namespace UnitTestMoodAnalyser
>>>>>>> UC3_CustomException
{
    [TestClass]
<<<<<<< HEAD
    public class TestMoodAnalyser
    {
<<<<<<< HEAD
        [TestMethod]
        public void AnalyzeSadMood()
        {
            //Arrange
            string msg = "I am in Sad Mood";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(msg);
            string expectedMood = "SAD";

            //Act
            string actualMood = moodAnalyser.AnalyseMood();

<<<<<<< HEAD
=======
        public MoodAnalyser(string msg)
        {
>>>>>>> UC2_HandleNullException
        }

        [TestMethod]
<<<<<<< HEAD
        public void GivenMood_ReturnHappy()
=======
            //Assert
            Assert.AreEqual(expectedMood, actualMood);
        }

        [TestMethod]
        public void AnalyzeHappyMood()
>>>>>>> UC3_CustomException
        {
            //Arrange
            string msg = "I am in Any Mood";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(msg);
            string expectedMood = "HAPPY";

            //Act
            string actualMood = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expectedMood, actualMood);
        }

        [TestMethod]
        public void AnalyzeNullExceptionHandling()
        {
            //Arrange
            string msg = null;
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(msg);

            //Act => Assert
            Assert.ThrowsException<MoodAnalysisException>(() => moodAnalyser.AnalyseMood());
        }

=======
    public class UnitTestMoodAnalyser
    {
>>>>>>> UC2_HandleNullException
        [TestMethod]
        public void AnalyzeNullExceptionMessage()
        {
            //Arrange
            string msg = null;
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(msg);
            string expectedMsg = "NULL";
            string actualMsg = "";

            //Act
            try
            {
                actualMsg = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalysisException exception)
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
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(msg);

            //Act => Assert
            Assert.ThrowsException<MoodAnalysisException>(() => moodAnalyser.AnalyseMood());
        }

        [TestMethod]
        public void AnalyzeEmptyExceptionMessage()
        {
            //Arrange
            string msg = "";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(msg);
            string expectedMsg = "EMPTY";
            string actualMsg = "";
            //Act
            try
            {
                actualMsg = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalysisException exception)
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
=======
                actualMsg = exception.Message;
            }
            //Assert
            Assert.AreEqual(expectedMsg, actualMsg);
>>>>>>> UC3_CustomException
        }
    }
>>>>>>> UC2_HandleNullException
}
