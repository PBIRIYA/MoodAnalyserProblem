﻿using System;
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
        }
    }
}
