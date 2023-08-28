namespace V._Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            int first = int.Parse(elements[0]);
            int second = int.Parse(elements[2]);

            switch (elements[1])
            {
                case ">":
                    if (first > second)
                    {
                        Console.WriteLine("Right");
                    }
                    else
                    {
                        Console.WriteLine("Wrong");
                    }
                    break;
                case "<":
                    if (first < second)
                    {
                        Console.WriteLine("Right");
                    }
                    else
                    {
                        Console.WriteLine("Wrong");
                    }
                    break;
                case "=":
                    if (first == second)
                    {
                        Console.WriteLine("Right");
                    }
                    else
                    {
                        Console.WriteLine("Wrong");
                    }
                    break;
            }
        }
    }
}