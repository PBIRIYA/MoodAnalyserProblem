using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyzerCustomerException : Exception
    {
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

        }
    }
}