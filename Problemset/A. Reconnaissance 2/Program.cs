namespace A._Reconnaissance_2
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/34/A
        static void Main(string[] args)
        {
            int number_of_soliders = int.Parse(Console.ReadLine()!);

            List<int> soliders_heights = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            soliders_heights.Add(soliders_heights[0]);

            int min_height = int.MaxValue;

            int solider_1_index = 0;
            int solider_2_index = 0;

            for (int i = 1; i < soliders_heights.Count; i++)
            {
                int current_difference = Math.Abs(soliders_heights[i] - soliders_heights[i - 1]);

                if (current_difference < min_height)
                {
                    min_height = current_difference;
                    solider_1_index = i - 1;
                    solider_2_index = i;
                }
            }

            solider_1_index++;

            if (solider_2_index == soliders_heights.Count - 1)
            {
                solider_2_index = 1;
            }

            else
            {
                solider_2_index++;
            }

            Console.WriteLine(solider_1_index + " " + solider_2_index);
        }
    }
}
