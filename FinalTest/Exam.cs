using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    internal class Exam
    {
        public static void Test()
        {
            string[] Test = { "Sun", "Mon", "Tue",
      "Wed", "Thursday", "Friday", "Saturday" };
            
             int sum = 0;
                      

            for (int i = 0; i < Test.Length; i++)
            {


                if (Test[i].Length <= 3)

                    sum++;
                                           
            }
            string[] result = new string[sum];


            for (int i = 0; i < Test.Length; i++)
            {


                if (Test[i].Length <= 3)

                    result[i] = Test[i];

            }

            for (int i = 0; i < sum; i++)
            {
                Console.WriteLine(result[i] + "   ");

            }

        }

    }
}


