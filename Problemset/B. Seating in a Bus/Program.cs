namespace B._Seating_in_a_Bus
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2000/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number_of_seats = int.Parse(Console.ReadLine()!);

                List<int> seats = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                bool[] occupied_seats = new bool[number_of_seats + 2];

                occupied_seats[seats[0]] = true;

                bool follow_recommendations = true;

                for (int i = 1; i < seats.Count; i++)
                {
                    if (!occupied_seats[seats[i] - 1] && !occupied_seats[seats[i] + 1])
                    {
                        follow_recommendations = false;
                        break;
                    }

                    else
                    {
                        occupied_seats[seats[i]] = true;
                    }
                }

                if (follow_recommendations)
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
