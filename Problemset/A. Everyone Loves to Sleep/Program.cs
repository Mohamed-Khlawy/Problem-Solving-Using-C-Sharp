namespace A._Everyone_Loves_to_Sleep
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1714/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_H_M = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_timers = n_H_M[0]; // n
                int hours_now = n_H_M[1] == 0 ? 24 : n_H_M[1]; // H
                int minutes_now = n_H_M[2]; // M

                int min_sleep_time = int.MaxValue;

                int time_now_in_minutes = 0;

                if (hours_now <= 12)
                {
                    time_now_in_minutes = (hours_now * 60) + minutes_now;
                }

                else if (hours_now > 12 && hours_now != 24)
                {
                    time_now_in_minutes = (12 * 60) + ((hours_now % 12) * 60) + minutes_now;
                }

                else if (hours_now == 24)
                {
                    time_now_in_minutes = (12 * 60) + (12 * 60) + minutes_now;
                }


                for (int i = 0; i < number_of_timers; i++)
                {
                    List<int> timer = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                    int timer_hours = timer[0] == 0 ? 24 : timer[0];
                    int timer_minutes = timer[1];

                    int sleep_time_with_this_timer = 0;

                    int timer_time_in_minutes = 0;

                    if (timer_hours <= 12)
                    {
                        timer_time_in_minutes = (timer_hours * 60) + timer_minutes;
                    }

                    else if (timer_hours > 12 && timer_hours != 24)
                    {
                        timer_time_in_minutes = (12 * 60) + ((timer_hours % 12) * 60) + timer_minutes;
                    }

                    else if (timer_hours == 24)
                    {
                        timer_time_in_minutes = (12 * 60) + (12 * 60) + timer_minutes;
                    }



                    if (timer_time_in_minutes < time_now_in_minutes)
                    {
                        timer_time_in_minutes += 1440;
                    }

                    sleep_time_with_this_timer = timer_time_in_minutes - time_now_in_minutes;

                    if (min_sleep_time > sleep_time_with_this_timer)
                    {
                        min_sleep_time = sleep_time_with_this_timer;
                    }
                }

                int sleep_minutes = min_sleep_time % 60;

                int sleep_hours = (min_sleep_time - sleep_minutes) / 60;

                //Console.Write("********************************************** ");

                Console.WriteLine(sleep_hours + " " + sleep_minutes);
            }
        }
    }
}
