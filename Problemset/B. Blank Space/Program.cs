namespace B._Blank_Space
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1829/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);
                int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                List<int> lengthsOfZero = new List<int>();
                int zeroCounter = 0;

                for (int i = 0; i < numbersArray.Length; i++)
                {
                    if (numbersArray[i] == 0)
                    {
                        zeroCounter++;
                    }
                    else if (numbersArray[i] == 1)
                    {
                        lengthsOfZero.Add(zeroCounter);
                        zeroCounter = 0;
                    }
                }

                if (zeroCounter != 0)
                {
                    lengthsOfZero.Add(zeroCounter);
                }

                lengthsOfZero.Sort();

                Console.WriteLine(lengthsOfZero[lengthsOfZero.Count - 1]);
            }
        }
    }
}