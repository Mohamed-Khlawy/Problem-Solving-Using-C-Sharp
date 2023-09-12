namespace V._Frequency_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] N_M = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int sizeOfNumbersArray = N_M[0]; //N
            int sizeOfFrequencyArray = N_M[1];  //M
            int[] frequencyArray = new int[sizeOfFrequencyArray + 1];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                frequencyArray[numbersArray[i]]++;
            }

            for (int i = 1; i < frequencyArray.Length; i++)
            {
                Console.WriteLine(frequencyArray[i]);
            }
        }
    }
}