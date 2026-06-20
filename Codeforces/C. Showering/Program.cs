namespace C._Showering
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1999/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_s_m = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_tasks = n_s_m[0];
                int shower_time = n_s_m[1];
                int total_minutes = n_s_m[2];

                List<int> free_intervals = new List<int>();

                int end_of_previous_task = 0;

                for (int i = 0; i < number_of_tasks; i++)
                {
                    List<int> task_interval = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                    int start = task_interval[0];
                    int end = task_interval[1];

                    if (i == 0 && i != number_of_tasks - 1)
                    {
                        int free_interval = start - 0;
                        free_intervals.Add(free_interval);
                        end_of_previous_task = end;
                    }

                    else if (i == number_of_tasks - 1)
                    {
                        int free_interval1 = start - end_of_previous_task;
                        free_intervals.Add(free_interval1);

                        int free_interval2 = total_minutes - end;
                        free_intervals.Add(free_interval2);
                    }

                    else
                    {
                        int free_interval = start - end_of_previous_task;
                        free_intervals.Add(free_interval);
                        end_of_previous_task = end;
                    }
                }

                if (free_intervals.Where(interval => interval >= shower_time).Any())
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
