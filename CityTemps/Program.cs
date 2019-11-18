using System;
using static System.Console;

namespace CityTemps
{
    class Program
    {
        static void Main(string[] args)
        {
            string city1;
            string city2;
            string city3;

            double minTemp1;
            double minTemp2;
            double minTemp3;

            double maxTemp1;
            double maxTemp2;
            double maxTemp3;

            WriteLine("Name of City:");
            city1 = ReadLine();
            WriteLine("MIN temp");
            minTemp1 = Convert.ToDouble(ReadLine());
            WriteLine("MAX temp");
            maxTemp1 = Convert.ToDouble(ReadLine());

            WriteLine("Name of City:");
            city2 = ReadLine();
            WriteLine("MIN temp");
            minTemp2 = Convert.ToDouble(ReadLine());
            WriteLine("MAX temp");
            maxTemp2 = Convert.ToDouble(ReadLine());

            WriteLine("Name of City:");
            city3 = ReadLine();
            WriteLine("MIN temp");
            minTemp3 = Convert.ToDouble(ReadLine());
            WriteLine("MAX temp");
            maxTemp3 = Convert.ToDouble(ReadLine());

            double avgTemp1 = (maxTemp1 + minTemp1) / 2;
            double avgTemp2 = (maxTemp2 + minTemp2) / 2;
            double avgTemp3 = (maxTemp3 + minTemp3) / 2;

            
            if (avgTemp1 < 50)
            {
                WriteLine("{0} has avg temp of {1} and it is chilly", city1, avgTemp1);
            } else
            {
                WriteLine("{0} has avg temp of {1} and it is definetly a temperature", city1, avgTemp1);
            }
            if (avgTemp2 < 50)
            {
                WriteLine("{0} has avg temp of {1} and it is chilly", city2, avgTemp2);
            }
            else
            {
                WriteLine("{0} has avg temp of {1} and it is definetly a temperature", city2, avgTemp2);
            }
            if (avgTemp3 < 50)
            {
                WriteLine("{0} has avg temp of {1} and it is chilly", city3, avgTemp3);
            }
            else
            {
                WriteLine("{0} has avg temp of {1} and it is definetly a temperature", city3, avgTemp3);
            }
        }
    }
}
