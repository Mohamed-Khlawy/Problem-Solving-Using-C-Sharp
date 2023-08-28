using System.Numerics;

namespace O._Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string x = ".";
            char[] chars = { '+', '-', '*', '/' };
            char op = '.';
            bool flag = false;
            BigInteger result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (s[i] == chars[j])
                    {
                        op = chars[j];
                        x = s.Replace(chars[j], ' ');
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            string[] elements = x.Split(' ');
            BigInteger first = BigInteger.Parse(elements[0]);
            BigInteger second = BigInteger.Parse(elements[1]);

            switch (op)
            {
                case '+':
                    result = first + second;
                    break;
                case '-':
                    result = first - second;
                    break;
                case '*':
                    result = first * second;
                    break;
                case '/':
                    result = first / second;
                    break;
            }
            Console.WriteLine(result);
        }
    }
}