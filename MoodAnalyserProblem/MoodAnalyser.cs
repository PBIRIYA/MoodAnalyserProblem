using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using MoodAnalyserProblem;
namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string mood;
        string message;
        enum Errors
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
                throw new MoodException(Errors.NULL.ToString());
            else if (message.Length == 0)
                throw new MoodException(Errors.EMPTY.ToString());
            try
            {
                mood = regexExp.IsMatch(this.message) ? "SAD" : "HAPPY";
            }
            catch (MoodAnalyserCustomException e)
            {
                throw new MoodException(Errors.OTHERS.ToString() + " " + e.Message);
            }
            return mood;
        }
    }
}
