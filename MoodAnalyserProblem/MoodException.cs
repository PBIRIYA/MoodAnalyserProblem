using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodException : Exception
    {
        string _message;
        public MoodException(string message) : base(message)
        {
            this._message = message;
        }
        public override string Message { get => _message; }
    }
}

