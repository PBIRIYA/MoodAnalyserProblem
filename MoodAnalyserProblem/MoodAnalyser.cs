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
        string _mood;
        string _message;
        public MoodAnalyser()
        {
            _mood = "";
        }
        public MoodAnalyser(string message)
        {
            this._message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this._message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this._message.ToLower().Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}