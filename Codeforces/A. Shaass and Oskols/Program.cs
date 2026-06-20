namespace A._Shaass_and_Oskols
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/294/A
        static void Main(string[] args)
        {
            int numberOfWires = int.Parse(Console.ReadLine()!);

            int[] inputWires = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Dictionary<int, int> wires = new Dictionary<int, int>();

            for (int i = 0; i < numberOfWires; i++)
            {
                wires[i] = inputWires[i];
            }

            int numberOfShots = int.Parse(Console.ReadLine()!);

            if (numberOfWires == 1)
            {
                /// In case we have only one wire.
                if (numberOfShots == 0)
                {
                    Console.WriteLine(wires[0]);
                    return;
                }

                int[] shot = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                Console.WriteLine(0);
                return;
            }

            if (numberOfShots > 0)
            {
                for (int i = 0; i < numberOfShots; i++)
                {
                    int[] shot = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                    int wireIndex = shot[0] - 1; // Convert to 0-based index
                    int birdIndex = shot[1];

                    if (wireIndex == 0)
                    {
                        /// We will skip the birds on the left of the bird Index.
                        wires[wireIndex + 1] += wires[wireIndex] - birdIndex;
                        wires[wireIndex] = 0;
                    }

                    else if (wireIndex == numberOfWires - 1)
                    {
                        /// We will skip the birds on the right of the bird Index.
                        wires[wireIndex - 1] += birdIndex - 1;
                        wires[wireIndex] = 0;
                    }

                    else
                    {
                        wires[wireIndex + 1] += wires[wireIndex] - birdIndex;
                        wires[wireIndex - 1] += birdIndex - 1;
                        wires[wireIndex] = 0;
                    }
                }
            }

            //Console.WriteLine("***********************************");

            for (int i = 0; i < numberOfWires; i++)
            {
                Console.WriteLine(wires[i]);
            }

            //Console.WriteLine("***********************************");
        }
    }
}
