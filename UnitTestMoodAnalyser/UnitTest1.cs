using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace UnitTestMoodAnalyser
{
    [TestClass]
    public class TestMoodAnalyser
    {
        [TestMethod]
        public void AnalyzeSadMood()
        {
            //Arrange
            string msg = "I am in Sad Mood";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(msg);
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
                actualMsg = exception.Message;
            }
            //Assert
            Assert.AreEqual(expectedMsg, actualMsg);
        }
    }
}