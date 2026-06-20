namespace A._GamingForces
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1792/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfMonsters = int.Parse(Console.ReadLine()!);

                List<int> monstersHealth = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                monstersHealth.Sort();

                int health1Counter = monstersHealth.Where(health => health == 1).Count();

                int numberOfSpells = 0;

                if (health1Counter % 2 == 0) // Even Number
                {
                    int half1Counter = health1Counter / 2;

                    numberOfSpells += half1Counter + (numberOfMonsters - health1Counter);
                }

                else // Odd Number
                {
                    int half1Counter = (health1Counter - 1) / 2;

                    numberOfSpells += half1Counter + (numberOfMonsters - health1Counter + 1);
                }

                //Console.Write("************************************ ");

                Console.WriteLine(numberOfSpells);
            }
        }
    }
}
