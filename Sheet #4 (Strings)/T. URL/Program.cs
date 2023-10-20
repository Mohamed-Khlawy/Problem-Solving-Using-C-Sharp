namespace T._URL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //http://www.cleartrip.com/signin/service?username=test&pwd=test&profile=developer&role=ELITE&key=manager
            string url = Console.ReadLine()!;

            url = url.Substring(url.IndexOf('?') + 1);

            for (int i = 0; i < url.Length; i++)
            {
                if (url[i] == '=')
                {
                    Console.Write(": ");
                    continue;
                }
                if (url[i] == '&')
                {
                    Console.WriteLine();
                    continue;
                }

                Console.Write(url[i]);
            }
        }
    }
}