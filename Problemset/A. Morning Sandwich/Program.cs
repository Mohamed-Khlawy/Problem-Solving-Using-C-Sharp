namespace A._Morning_Sandwich
{
    internal class Program
    {
        // Probelm Link : https://codeforces.com/problemset/problem/1849/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> gradients = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int bread = gradients[0];
                int cheese = gradients[1];
                int harm = gradients[2];

                int total_cheese_and_harm = cheese + harm;

                //Console.Write("********************************************* ");

                if (total_cheese_and_harm + 1 <= bread)
                {
                    Console.WriteLine(total_cheese_and_harm * 2 + 1);
                }

                else
                {
                    Console.WriteLine(bread * 2 - 1);
                }
            }
        }
    }
}
