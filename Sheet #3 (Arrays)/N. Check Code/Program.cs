namespace N._Check_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A_B = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            string code = Console.ReadLine()!;
            int A = A_B[0];
            int B = A_B[1];
            int digitsCounter = 0;
            bool flag = false;

            if (A + B + 1 != code.Length)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = 0; i < code.Length; i++)
            {
                if (i != A)
                {
                    if (!char.IsDigit(code[i]))
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        digitsCounter++;
                    }
                }
                else if (i == A)
                {
                    if (code[i] != '-')
                    {
                        flag = true;
                        break;
                    }
                }
            }

            if (flag)
            {
                Console.WriteLine("No");
            }
            else if (!flag && digitsCounter == A + B)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}