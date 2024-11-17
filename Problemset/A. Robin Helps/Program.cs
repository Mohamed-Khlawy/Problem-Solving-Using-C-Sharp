namespace A._Robin_Helps
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2014/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_people = n_k[0];
                int threshold = n_k[1];

                List<int> gold_with_people = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                long robin_hood = 0;
                long people_will_get_from_robin_hood = 0;

                for (int i = 0; i < gold_with_people.Count; i++)
                {
                    if (gold_with_people[i] >= threshold)
                    {
                        robin_hood += gold_with_people[i];
                    }

                    else if (gold_with_people[i] == 0 && robin_hood > 0)
                    {
                        people_will_get_from_robin_hood++;
                        robin_hood--;
                    }
                }

                //Console.Write("******************************************* ");

                Console.WriteLine(people_will_get_from_robin_hood);
            }
        }
    }
}
