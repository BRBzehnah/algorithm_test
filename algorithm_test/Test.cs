using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_test
{
    internal class Test
    {
        delegate void AlgorithmInTesting(int multiplicity, char operators);


        static double ConvertorToSeconds(double value)
        {
            return value / 1000;
        }

        static long[] Testing(int multiplicity, AlgorithmInTesting algorithmInTesting)
        {
            var timer = new Stopwatch();
            char[] operators = { '+', '-', '*', '/' };
            long[] listOfTime = new long[40];
            int index = new();
            for (int i = 0; i < operators.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    timer.Restart();
                    algorithmInTesting(multiplicity, operators[i]);
                    timer.Stop();
                    listOfTime[index] = timer.ElapsedMilliseconds;
                    index++;
                }
            }
            return listOfTime; 
        }


        static public double Linear(int multiplicity)
        {
            return ConvertorToSeconds(Testing(multiplicity, Algorithm.Linear).Average());
        }

        static public double Jump(int multiplicity)
        {
            return ConvertorToSeconds(Testing(multiplicity, Algorithm.Jump).Average());
        }

        static public double BinarySearch(int multiplicity)
        {
            return ConvertorToSeconds(Testing(multiplicity, Algorithm.BinarySearch).Average());
        }

        static public double DevideAndConquer(int multiplicity)
        {
            return ConvertorToSeconds(Testing(multiplicity, Algorithm.DevideAndConquer).Average());
        }
    }
}
