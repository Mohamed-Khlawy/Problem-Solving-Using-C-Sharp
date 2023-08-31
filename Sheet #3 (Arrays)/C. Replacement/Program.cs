namespace C._Replacement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = numbersArray[i] switch
                {
                    > 0 => 1,
                    < 0 => 2,
                    _ => 0,
                };

                //switch (numbersArray[i])  // Another way for switch statements
                //{
                //    case > 0:
                //        numbersArray[i] = 1;
                //        break;
                //    case < 0:
                //        numbersArray[i] = 2;
                //        break;
                //    default:
                //        numbersArray[i] = 0;
                //        break;
                //}
            }

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write(numbersArray[i] + " ");
            }
        }
    }
}