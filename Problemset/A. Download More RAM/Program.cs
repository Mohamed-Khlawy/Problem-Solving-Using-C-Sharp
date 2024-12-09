namespace A._Download_More_RAM
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1629/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_pieces_of_RAM = n_k[0];

                int your_currently_RAM = n_k[1];

                List<int> decreasing_RAM =
                    Console.ReadLine()!.Split().Select(int.Parse).ToList();


                List<int> increasing_RAM =
                    Console.ReadLine()!.Split().Select(int.Parse).ToList();

                bool RAM_changed = false;

                int previous_RAM = your_currently_RAM;

                do
                {
                    RAM_changed = false;

                    previous_RAM = your_currently_RAM;

                    for (int i = 0; i < decreasing_RAM.Count; i++)
                    {
                        if (your_currently_RAM >= decreasing_RAM[i])
                        {
                            your_currently_RAM += increasing_RAM[i];

                            decreasing_RAM.RemoveAt(i);
                            increasing_RAM.RemoveAt(i);

                            i--;
                        }
                    }

                    if (your_currently_RAM != previous_RAM)
                    {
                        RAM_changed = true;
                    }
                }
                while (RAM_changed);

                //Console.Write("******************************************* ");

                Console.WriteLine(your_currently_RAM);
            }
        }
    }
}
