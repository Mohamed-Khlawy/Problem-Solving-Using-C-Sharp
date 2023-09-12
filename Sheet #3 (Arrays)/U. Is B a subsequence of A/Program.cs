namespace U._Is_B_a_subsequence_of_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] N_M = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int[] firstArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int sizeOfFirstArray = N_M[0];
            int sizeOfSecondArray = N_M[1];

            int indexForSecondArray = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (indexForSecondArray < secondArray.Length &&
                    secondArray[indexForSecondArray] == firstArray[i])
                {
                    indexForSecondArray++;
                }
                else if (indexForSecondArray == secondArray.Length)
                {
                    break;
                }
            }

            if (indexForSecondArray == secondArray.Length)
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