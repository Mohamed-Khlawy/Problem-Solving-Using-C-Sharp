using System.Data.Common;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Problemset_MainFolder
{
    internal class Program
    {
        //public static double IsItBiggerThanOrEqual6(ref double numberOfFriends)
        //{
        //    if (numberOfFriends < 6)
        //    {
        //        numberOfFriends = 6;
        //    }

        //    return numberOfFriends;
        //}

        public static double NowItIsDivisible(ref double numberOfFriends, double[] slicesSizesOptions,
            double[] slicesTimesOptions, ref double minTime)
        {
            double sizeOption1 = numberOfFriends / slicesSizesOptions[0];
            double sizeOption2 = numberOfFriends / slicesSizesOptions[1];
            double sizeOption3 = numberOfFriends / slicesSizesOptions[2];

            sizeOption1 *= slicesTimesOptions[0];
            sizeOption2 *= slicesTimesOptions[1];
            sizeOption3 *= slicesTimesOptions[2];

            minTime = Math.Min(sizeOption1, Math.Min(sizeOption2, sizeOption3));

            return minTime;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                double numberOfFriends = double.Parse(Console.ReadLine()!);

                double[] slicesSizesOptions = new double[3] { 6, 8, 10 };

                double[] slicesTimesOptions = new double [3] { 15, 20, 25 };

                double minTime = 0;

                if (numberOfFriends < 6) // Less than 6, deal with it as 6
                {
                    //numberOfFriends = 6;

                    minTime = 1 * slicesTimesOptions[0];
                }

                else // Bigger than or equal to 6
                {
                    double sixCounter = Math.Floor(numberOfFriends / 6);

                    double slicesWithSixOnly = sixCounter * 6;

                    double remainingSlices = numberOfFriends - slicesWithSixOnly;

                    switch (remainingSlices)
                    {
                        case 0:
                            // No need to change any 6, it can be solved with 6 only
                            minTime = sixCounter * slicesTimesOptions[0];
                            break;
                        
                        case 1:
                        case 2:
                            // Delete one 6 and replace it with one 8
                            sixCounter--;
                            minTime =
                                (sixCounter * slicesTimesOptions[0]) + (1 * slicesTimesOptions[1]);
                            break;

                        case 3:
                        case 4:
                            // Delete one 6 and replace it with one 10
                            sixCounter--;
                            minTime =
                                (sixCounter * slicesTimesOptions[0]) + (1 * slicesTimesOptions[2]);
                            break;

                        case 5:
                            // Add another 6
                            sixCounter++;
                            minTime = (sixCounter * slicesTimesOptions[0]);
                            break;
                    }
                }

                //Console.Write("************************************* ");

                Console.WriteLine(minTime);
            }
        }
    }
}