namespace C._Clock_Conversion
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1950/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {

                int[] hh_mm = Console.ReadLine()!.Split(':').Select(int.Parse).ToArray();

                string hours = "";
                string minutes = "";
                string time = "";

                // Minutes Hnadling
                if (hh_mm[1] < 10)
                {
                    minutes = "0" + hh_mm[1].ToString();
                }
                else
                {
                    minutes = hh_mm[1].ToString();
                }

                // Hours and Time Handling

                // Hour = 0 ==> 12 AM
                if (hh_mm[0] == 0)
                {
                    hours = "12";
                    time = "AM";
                }

                // Hour = 12 ==> 12 PM
                else if (hh_mm[0] == 12)
                {
                    hours = hh_mm[0].ToString();
                    time = "PM";
                }

                // Hour < 12 ==> ... AM
                else if (hh_mm[0] < 12)
                {
                    if (hh_mm[0] < 10)
                    {
                        hours = "0" + hh_mm[0].ToString();
                    }

                    else
                    {
                        hours = hh_mm[0].ToString();
                    }

                    time = "AM";
                }

                // Hour > 12 ==> ... PM
                else
                {
                    hh_mm[0] = hh_mm[0] - 12;

                    if (hh_mm[0] < 10)
                    {
                        hours = "0" + hh_mm[0].ToString();
                    }

                    else
                    {
                        hours = hh_mm[0].ToString();
                    }

                    time = "PM";
                }

                Console.WriteLine(hours + ":" + minutes + " " + time);
            }
        }
    }
}
