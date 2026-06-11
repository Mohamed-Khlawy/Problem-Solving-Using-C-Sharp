namespace Add_Binary
{
    internal class Program
    {
        public string AddBinary(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;

            var result = new Stack<char>();

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;

                if (i >= 0) sum += a[i--] - '0'; /// Convert char to int
                if (j >= 0) sum += b[j--] - '0'; /// Convert char to int

                result.Push((char)('0' + sum % 2)); /// Push the last digit of the sum
                carry = sum / 2; /// Update carry for the next iteration
            }

            return string.Concat(result); /// Convert the stack to a string
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine()!;
            string b = Console.ReadLine()!;

            Program program = new Program();

            Console.WriteLine(program.AddBinary(a, b));
        }
    }
}
