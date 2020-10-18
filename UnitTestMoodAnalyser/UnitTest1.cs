using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserProblem;
namespace UnitTestMoodAnalyser
{
    [TestClass]
    public class UnitTestMoodAnalyser
    {
        [TestMethod]
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

        [TestMethod]
        public void AnalyzeNullExceptionHandling()
        {
            //Arrange
            string msg = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);
            //Act => Assert
            Assert.ThrowsException<MoodException>(() => moodAnalyser.AnalyseMood());
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
            catch (MoodException exception)
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
            Assert.ThrowsException<MoodException>(() => moodAnalyser.AnalyseMood());
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
            catch (MoodException exception)
            {
                actualMsg = exception.Message;
            }
            //Assert
            Assert.AreEqual(expectedMsg, actualMsg);
        }

        [TestMethod]
        public void MoodAnalysisBuilder_ShouldReturnMoodAnalysisObject()
        {
            //Arrange
            string className = "MoodAnalyser";
            object expectedInstance = new MoodAnalyser();
            //Add
            object actualInstance = MoodAnalyserBuilder.BuildMoodAnalysis(className);
            //Assert
            expectedInstance.Equals(actualInstance);
        }

        [TestMethod]
        public void TestMoodAnalysisBuilder_WrongClassName_ThrowClassNotFoundException()
        {
            //Arrange
            string className = "MoodAnalyserWrongName";
            string constructorName = className;
            string expected = "Class not found";
            string actual;

            //Add
            try
            {
                object actualInstance = MoodAnalyserBuilder.BuildMoodAnalysis(className, constructorName);
                actual = actualInstance.ToString();
            }
            catch (MoodAnalyserCustomException e)
            {
                actual = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMoodAnalysisBuilder_WrongConstructorName_ThrowConstructorNotFoundException()
        {
            //Arrange
            string className = "MoodAnalyser";
            string constructorName = "Wrong" + className;
            string expected = "Constructor Not Found";
            string actual;

            //Add
            try
            {
                object actualInstance = MoodAnalyserBuilder.BuildMoodAnalysis(className, constructorName);
                actual = actualInstance.ToString();
            }
            catch (MoodAnalyserCustomException e)
            {
                actual = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestParameterizedMoodAnalysisBuilder_ShouldReturnMoodAnalysisObject()
        {
            //Arrange
            string className = "MoodAnalyser";
            string constructorName = className;
            string message = "he is sad";
            object expectedInstance = new MoodAnalyser(message);

            //Add
            object actualInstance = MoodAnalyserBuilder.BuildMoodAnalysis(className, constructorName, message);

            //Assert
            expectedInstance.Equals(actualInstance);
        }
    }
}
