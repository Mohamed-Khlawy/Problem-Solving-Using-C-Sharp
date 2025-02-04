namespace B._Sum_of_Digits
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/102/B
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()!
                              .Select(digit => int.Parse(digit.ToString()))
                              .ToList();

            long minSpells = 0;

            while (number.Count > 1)
            {
                minSpells++;

                string newNumber = number.Sum().ToString();

                number = newNumber.Select(digit => int.Parse(digit.ToString())).ToList();
            }

            //Console.Write("****************** ");

            Console.WriteLine(minSpells);
        }
    }
}
