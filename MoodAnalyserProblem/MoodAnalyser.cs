using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using MoodAnalyserProblem;
namespace MoodAnalyserProblem
{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public class MoodAnalyzerCustomerException : Exception
    {
<<<<<<< HEAD
        public enum ExceptionType
=======
    public class MoodAnalyzer
=======
    public class MoodAnalyser
>>>>>>> UC3_CustomException
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
            if (message == null)
                throw new MoodAnalyserCustomException(Errors.NULL.ToString());
            else if (message.Length == 0)
                throw new MoodAnalyserCustomException(Errors.EMPTY.ToString());
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
            catch (MoodAnalyserCustomException e)
            {
                throw new MoodAnalyserCustomException(Errors.OTHERS.ToString() + " " + e.Message);
            }
<<<<<<< HEAD

=======
    public class MoodAnalyser
=======
    public class MoodAnalyser : Exception
>>>>>>> UC2_HandleNullException
    {
        string msg;
        public string analyseMood()
        {
            if (msg == "I am in Sad Mood")
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
        string pattern = "(^.*Sad.*$)|(^.*sad.*$)|(^.*SAD.*$)";
        public string AnalyseMood(string message)
        {
            if (message != null)
            {
                bool match = Regex.IsMatch(message, pattern);
                if (match)
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            else
            {
                return "Value cannot be null";
            }
<<<<<<< HEAD
            return mood;
>>>>>>> UC2_HandleNullException
=======
            return mood;
>>>>>>> UC3_CustomException
=======
>>>>>>> UC2_HandleNullException
        }
    }
}