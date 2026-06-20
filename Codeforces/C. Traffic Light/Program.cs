namespace C._Traffic_Light
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1744/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<string> input = Console.ReadLine()!.Split().ToList();
                //List<string> input = [.. Console.ReadLine()!.Split()]; ==> 
                // Result to a Compilation Error with .Net 6 on Codeforces

                int size = int.Parse(input[0]);
                char current_light = input[1][0];

                string lights = Console.ReadLine()!;

                string doubled_lights = lights + lights;

                //Console.Write("*********************************** ");

                if (current_light == 'g')
                {
                    Console.WriteLine(0);
                }

                else
                {
                    int max_time = 0;

                    for (int i = 0; i < size; i++)
                    {
                        if (doubled_lights[i] == current_light)
                        {
                            for (int j = i + 1; j < i + size; j++)
                            {
                                if (doubled_lights[j] == 'g')
                                {
                                    max_time = Math.Max(max_time, j - i);
                                    i = j;
                                    break;
                                }
                            }
                        }
                    }

                    Console.WriteLine(max_time);
                }
            }
        }
    }
}
