using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
<<<<<<< HEAD
    public class MoodAnalyzerCustomerException : Exception
    {
<<<<<<< HEAD
        public enum ExceptionType
        {
            Null_message, Empty_message
        }
        private readonly ExceptionType type;


        public MoodAnalyzerCustomerException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }

        public MoodAnalyzerCustomerException(object message)
        {
        }

        public string AnalyseMood()
        {
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
                if (this.Message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomerException(MoodAnalyzerCustomerException.ExceptionType.Empty_message, "mood is empty");
                }


                if (this.Message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }

            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerCustomerException(MoodAnalyzerCustomerException.ExceptionType.Null_message, "mood is invalid");
            }

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
        }
    }
}