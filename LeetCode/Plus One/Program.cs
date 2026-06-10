namespace Plus_One
{
    internal class Program
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;

                    return digits;
                }
                else /// digits[i] == 9
                {
                    digits[i] = 0;
                }
            }

            int[] newDigits = new int[digits.Length + 1];

            newDigits[0] = 1;

            return newDigits;
        }
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine()!.Split(',').Select(int.Parse).ToArray();

            Program program = new Program();

            Console.WriteLine(string.Join(',', program.PlusOne(digits)));
        }
    }
}
