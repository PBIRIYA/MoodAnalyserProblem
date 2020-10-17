using System;
using System.ComponentModel.DataAnnotations;

namespace MoodAnalyserProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Program");
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> UC2_HandleNullException
            MoodAnalyser analyser = new MoodAnalyser();
            Console.WriteLine("your current mood : ");
            string message = Console.ReadLine();
            string mood = analyser.AnalyseMood(message);
            Console.WriteLine(mood);
<<<<<<< HEAD
=======
>>>>>>> UC1_CreateAbility
=======
>>>>>>> UC2_HandleNullException
=======
           
>>>>>>> UC3_CustomException
=======
>>>>>>> UC2_HandleNullException
=======
>>>>>>> UC3_CustomException
        }
    }
}