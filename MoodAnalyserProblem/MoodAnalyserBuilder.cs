using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Net.Http;
namespace MoodAnalyserProblem
{
    public class MoodAnalyserBuilder
    {
        public static object BuildMoodAnalysis(string className, string Constructor, string message)
        {
            Type typeRef;
            typeRef = Type.GetType("MoodAnalyzerProgram." + className);
            if (typeRef == null)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
            if (Constructor != className)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor Not Found");
            }
            ConstructorInfo constructor1 = typeRef.GetConstructor(Type.EmptyTypes);
            object instance = constructor1.Invoke(null);
            return instance;
        }
        public static object BuildMoodAnalysis(string className, string Constructor)
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
            ConstructorInfo constructor1 = type.GetConstructor(new Type[] { typeof(string) });
            object parameters = new object();
            object instance = constructor1.Invoke((object[])parameters);
            return instance;
        }
        public static string InvokeMoodAnalysis(string methodName, string message)
        {
            Type typeRef = Type.GetType("MoodAnalyzerProgram.MoodAnalyser");
            object instance = BuildMoodAnalysis("MoodAnalyzerProgram.MoodAnalyser", "MoodAnalyser", message);

            MethodInfo methodInfo = typeRef.GetMethod(methodName);
            if (methodName == null)
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "No such method found");
            object mood = methodInfo.Invoke(instance, null);
            return mood.ToString();
        }
    }
}