﻿using System;
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
            Type type = typeof(MoodAnalyserCustomException);
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
        public static object BuildMoodAnalysis(string className, string Constructor)
        {
            Type type = typeof(MoodAnalyserCustomException);
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
    }
}