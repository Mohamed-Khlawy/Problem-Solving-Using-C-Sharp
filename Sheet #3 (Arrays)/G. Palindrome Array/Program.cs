namespace G._Palindrome_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int left = 0;
            int right = numbersArray.Length - 1;
            bool palindrome = true;

            while (left < right)
            {
                if (numbersArray[left] != numbersArray[right])
                {
                    palindrome = false;
                    break;
                }
                left++;
                right--;
            }

            if (palindrome)
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