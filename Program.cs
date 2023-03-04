// See https://aka.ms/new-console-template for more information
using Day21Reflection;

namespace Day21Reflections
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                AnalyzeMood mood = MoodAnalyzerFactory.CreateMoodAnalyzer();
                Console.WriteLine(mood.Analyze(""));
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
