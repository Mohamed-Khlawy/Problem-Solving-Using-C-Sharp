namespace I._Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine()!;
            char[] chars = number.ToCharArray();

            Array.Reverse(chars);

            bool foundNonZero = false;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '0' && !foundNonZero)
                {
                    chars[i] = '.';
                }
                else if (chars[i] != '0')
                {
                    break;
                }
            }
            string reversed = "";
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != '.')
                {
                    reversed += chars[i];
                }
            }
            Console.WriteLine(reversed);
            if (reversed == number)
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