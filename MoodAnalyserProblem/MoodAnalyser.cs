using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace MoodAnalyserProblem
{
<<<<<<< HEAD
<<<<<<< HEAD
    public class MoodAnalyzerCustomerException : Exception
    {
<<<<<<< HEAD
        public enum ExceptionType
=======
    public class MoodAnalyzer
    {
        string mood;
        string message;
        enum Errors
>>>>>>> UC3_CustomException
        {
            NULL,
            EMPTY,
            OTHERS
        }
        public MoodAnalyzer()
        {
            mood = "";
        }
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            string regexStr = "^(.*[ ])*[sSaAdD]{3}([ ].*)*";
            Regex regexExp = new Regex(regexStr);

            if (message == null)
                throw new MoodAnalysisException(Errors.NULL.ToString());
            else if (message.Length == 0)
                throw new MoodAnalysisException(Errors.EMPTY.ToString());
            try
=======
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (this.message.Contains("Sad"))
>>>>>>> UC1_CreateAbility
            {
                mood = regexExp.IsMatch(this.message) ? "SAD" : "HAPPY";
            }
            catch (MoodAnalysisException e)
            {
                throw new MoodAnalysisException(Errors.OTHERS.ToString() + " " + e.Message);
            }
<<<<<<< HEAD

=======
    public class MoodAnalyser
    {
        string mood;
        string message;
        public MoodAnalyser()
        {
            mood = "";
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            string regexStr = "^(.*[ ])*[sSaAdD]{3}([ ].*)*";
            Regex regexExp = new Regex(regexStr);
            try
            {
                mood = regexExp.IsMatch(this.message) ? "SAD" : "HAPPY";
            }
            catch (Exception ex)
            {
                return "HAPPY";
            }
            return mood;
>>>>>>> UC2_HandleNullException
=======
            return mood;
>>>>>>> UC3_CustomException
        }
    }
}