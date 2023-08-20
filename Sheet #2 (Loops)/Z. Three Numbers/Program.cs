namespace Z._Three_Numbers
{
    internal class Program
    {
        // This problem was hard on me
        static void Main(string[] args)
        {
            string k_s = Console.ReadLine()!;
            string[] inputs = k_s.Split(' ');

            int k = int.Parse(inputs[0]);
            int s = int.Parse(inputs[1]);

            int count = 0;

            for (int x = 0; x <= k; x++)
            {
                for(int y = 0; y <= k; y++)
                {
                    int z = s - (x + y);

                    if (x + y + z == s && z >= 0 && z <= k)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}