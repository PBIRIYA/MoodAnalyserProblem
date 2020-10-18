using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Net.Http;
namespace MoodAnalyserProblem
{
    public class MoodAnalyserBuilder
    {
        public static object BuildMoodAnalysis(string className)
        {
            Type typeRef;
            try
            {
                typeRef = Type.GetType("MoodAnalyzerProgram." + className);
            }
            catch (Exception)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");
            }
            ConstructorInfo constructorInfo = typeRef.GetConstructor(Type.EmptyTypes);
            object instance = constructorInfo.Invoke(null);
            return instance;
        }
    }
}