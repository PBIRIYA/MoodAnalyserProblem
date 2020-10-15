using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
<<<<<<< HEAD


namespace UnitTestProject1
{
    [TestClass]
    public class MoodAnalyser
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
}
