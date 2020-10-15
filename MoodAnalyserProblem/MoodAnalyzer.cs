using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyzer
    {
        public string message { get; set; }

        public MoodAnalyzer()
        {

        }
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string CheckMood(string message = null)
        {
            var Message = message;
            try
            {
                Message = Message.ToLower();
                if (Message == "I am sad")
                {
                    return "SAd";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
            }
        }
    }
}
