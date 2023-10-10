namespace Q._Reverse_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine()!.Split();

            for (int i = 0; i < sentence.Length; i++)
            {
                char[] chars = sentence[i].ToCharArray();

                Array.Reverse(chars);

                sentence[i] = new string(chars);

                if (i != sentence.Length - 1)
                {
                    Console.Write(sentence[i] + " ");
                }

                else
                {
                    Console.Write(sentence[i]);
                }
            }
        }
    }
}