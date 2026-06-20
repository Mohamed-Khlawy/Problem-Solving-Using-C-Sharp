namespace B._Symmetric_Encoding
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1974/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<char> ciphertext = Console.ReadLine()!
                                       .Select(c => char.Parse(c.ToString()))
                                       .ToList();

                List<char> ciphertext_copy = new List<char>(ciphertext);

                List<char> plaintext = new List<char>();


                // Step 1 ==> Sort the ciphertext_copy in alphabetical order
                ciphertext_copy.Sort();


                // Step 2 ==> Get the unique chars from the ciphertext
                HashSet<char> unique = new HashSet<char>(ciphertext_copy);


                // Step 3 ==> Convert the Hashset again to List to get the indices
                List<char> unique_list = new List<char>(unique);


                int unique_size = unique_list.Count - 1;

                // Step 4 ==> Get the symmetric char from the unique list,
                // for each char in ciphertext
                for (int i = 0; i < ciphertext.Count; i++)
                {
                    int char_index_in_unique = unique_list.IndexOf(ciphertext[i]);

                    int symmetric_index = unique_size - char_index_in_unique;

                    plaintext.Add(unique_list[symmetric_index]);
                }

                //Console.Write("********************************** ");


                // Step 5 ==> Print the Plaintext
                for (int i = 0; i < plaintext.Count; i++)
                {
                    Console.Write(plaintext[i]);
                }

                Console.WriteLine();
            }
        }
    }
}
