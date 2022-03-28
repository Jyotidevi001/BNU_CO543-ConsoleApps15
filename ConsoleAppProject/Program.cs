using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Jyoti  20/03/2022
    /// </summary>
    public static class Program
    {
        public static DistanceConverter DistanceConverter
        {
            get => default;
            set
            {
            }
        }

        public static void Main(string[] args)
        {
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine();
                Console.WriteLine(" =================================================");
                Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
                Console.WriteLine("                     by Jyoti                     ");
                Console.WriteLine(" =================================================");
                Console.WriteLine();

                //Distance Converter = new distance converter();
                //Converter.ConvertDistance();

                //BMI calculate = new BMI();
                //Calculator.Run();

                //StudentGrades grades = new StudentGrades();
                //grades.Run();

              

                string[] choices =
                {
                "App01 Distance Converter",
                "App02 BMI Calculator",
                "App03 Students Grades",
                "APP04 News App"

                };
                Console.WriteLine("Please Choose Your App\n ");

                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1:
                        DistanceConverter app01 = new DistanceConverter();
                        app01.Run();
                        break;
                    case 2:
                        BMI calculator = new BMI();
                        calculator.Run();
                        break;
                    case 3:
                        StudentGrades app03 = new StudentGrades();
                        app03.Run();
                        break;
                    case 4:
                        NewsApp app04 = new NewsApp(); app04.Run();
                        break;



                }

            }
        }
    }
}
