namespace A._Cards
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1220/A
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);

            string word = Console.ReadLine()!;

            List<int> digits = new List<int>();

            // Step 1: Count number of (n) to know how many ones in the string
            int number_of_n = word.Where(c => c == 'n').Count();

            // Step 2: Count number of (z) to know how many zeros in the string
            int number_of_z = word.Where(c => c == 'z').Count();

            // Step 3: Add in the list all ones first then all zeros to get max number
            for (int i = 0; i < number_of_n; i++)
            {
                digits.Add(1);
            }

            for (int i = 0; i < number_of_z; i++)
            {
                digits.Add(0);
            }

            //Console.Write("******************************************** ");

            for (int i = 0; i < digits.Count; i++)
            {
                if (i == digits.Count - 1)
                {
                    Console.WriteLine(digits[i]);
                }

                else
                {
                    Console.Write(digits[i] + " ");
                }
            }
        }
    }
}
