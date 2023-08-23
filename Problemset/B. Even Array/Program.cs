namespace B._Even_Array
{
    internal class Program
    {
        // Problem Link: https://codeforces.com/problemset/problem/1367/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int arrayLength = int.Parse(Console.ReadLine()!);
                string arrayNumbers = Console.ReadLine()!;
                string[] split_arrayNumbers = arrayNumbers.Split(' ');

                int[] array = new int[arrayLength];
                List<int> swapsArray = new List<int>();

                int evenCounter = 0;
                int oddCounter = 0;

                for (int i = 0; i < arrayLength; i++)
                {
                    array[i] = int.Parse(split_arrayNumbers[i]);
                    if (array[i] % 2 != i % 2)
                    {
                        swapsArray.Add(array[i]);
                    }
                }

                for (int i = 0; i < swapsArray.Count; i++)
                {
                    if (swapsArray[i] % 2 == 0)
                    {
                        evenCounter++;
                    }
                    else
                    {
                        oddCounter++;
                    }
                }

                if (evenCounter == oddCounter)
                {
                    Console.WriteLine(evenCounter);//or odd counter, they will be same in this case
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}