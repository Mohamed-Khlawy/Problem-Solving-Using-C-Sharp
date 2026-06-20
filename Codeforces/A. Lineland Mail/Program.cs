namespace A._Lineland_Mail
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/567/A
        static void Main(string[] args)
        {
            int number_of_cities = int.Parse(Console.ReadLine()!);

            List<int> cities = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            List<string> min_max = new List<string>();

            for (int i = 0; i < number_of_cities; i++)
            {
                if (i == 0)
                {
                    int min = cities[i + 1] - cities[i];
                    int max = cities[cities.Count - 1] - cities[i];

                    min_max.Add(min.ToString() + " " + max.ToString());
                }

                else if (i == cities.Count - 1)
                {
                    int min = cities[i] - cities[i - 1];
                    int max = cities[i] - cities[0];

                    min_max.Add(min.ToString() + " " + max.ToString());
                }

                else
                {
                    int min = Math.Min(cities[i + 1] - cities[i], cities[i] - cities[i - 1]);
                    int max = Math.Max(cities[cities.Count - 1] - cities[i], cities[i] - cities[0]);

                    min_max.Add(min.ToString() + " " + max.ToString());
                }
            }

            for (int i = 0; i < number_of_cities; i++)
            {
                Console.WriteLine(min_max[i]);
            }
        }
    }
}
