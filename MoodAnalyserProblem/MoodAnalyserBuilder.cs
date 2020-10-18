using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Net.Http;
namespace MoodAnalyserProblem
{
    public class MoodAnalyserBuilder : Exception 
    {
        public static object BuildMoodAnalysis(string className, string Constructor, string message)
        {
            Type type = typeof(MoodAnalyserBuilder);
            if (type == null)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
            if (Constructor != className)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor Not Found");
            }
            ConstructorInfo constructor1 = type.GetConstructor(Type.EmptyTypes);
            object instance = constructor1.Invoke(null);
            return instance;
        }
    }
}