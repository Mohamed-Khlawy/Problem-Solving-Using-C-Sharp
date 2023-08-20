using System.Numerics;

namespace X._Convert_To_Decimal_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTests = int.Parse(Console.ReadLine()!);

            while(numberOfTests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);

                string binary = Convert.ToString(number, 2);  // To convert decimal to binary with base 2

                string onesInBinary = "";  // To get the ones in binary repersentation

                for (int i = 0; i < binary.Length; i++)
                {
                    if (binary[i] == '1')
                    {
                        onesInBinary += binary[i];
                    }
                }

                //To convert binary to decimal with base 2
                int decimalValue = Convert.ToInt32(onesInBinary, 2);

                Console.WriteLine(decimalValue);
            }
        }
    }
}