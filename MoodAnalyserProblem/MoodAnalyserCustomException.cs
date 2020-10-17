using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserCustomException : Exception
    {
        string _message;
        public MoodAnalyserCustomException(string message) : base(message)
        {
            this._message = message;
        }
        public override string Message { get => _message; }
    }
}
