using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
namespace UnitTestMoodAnalyser
{
    [TestClass]
    public class TestMoodAnalyser
    {
        [TestMethod]
        public void when_pass_I_am_Sad_should_return_Sad()
        {
<<<<<<< HEAD
            //Arrange
            string msg = "I am in Sad Mood";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(msg);
            string expectedMood = "SAD";
=======
            //Arrage
            MoodAnalyser analyser = new MoodAnalyser();
>>>>>>> UC2_HandleNullException
            //Act
            string result1 = analyser.AnalyseMood("I am in Sad Mood");
            //Assert
            Assert.AreEqual("SAD", result1);
        }

        [TestMethod]
        public void when_pass_I_am_Happy_should_return_happy()
        {
<<<<<<< HEAD
            //Arrange
            string msg = "I am in Any Mood";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(msg);
            string expectedMood = "HAPPY";
=======
            //Arrage
            MoodAnalyser analyser = new MoodAnalyser();
>>>>>>> UC2_HandleNullException
            //Act
            string result2 = analyser.AnalyseMood("I am in Any Mood");
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
            Assert.AreEqual(expectedMsg, actualMsg);
        }
    }
}
