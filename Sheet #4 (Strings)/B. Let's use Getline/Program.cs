namespace B._Let_s_use_Getline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine()!;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != '\\')
                {
                    Console.Write(sentence[i]);
                }
                else
                {
                    break;
                }
            }
        }
    }
}