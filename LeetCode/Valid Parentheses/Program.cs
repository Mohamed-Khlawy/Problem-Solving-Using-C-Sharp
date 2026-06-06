namespace Valid_Parentheses
{
    // Problem Link: https://leetcode.com/problems/valid-parentheses/description/
    internal class Program
    {
        public bool IsValid(string input)
        {
            Dictionary<char, char> parentheses = new()
            {
                {')', '(' },
                {'}', '{' },
                {']', '[' }
            };

            Stack<char> stack = new();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[') /// Opening parentheses pushed to stack.
                {
                    stack.Push(ch);
                }

                else /// Closing parentheses, check if stack is empty or top of it matches the current closing parentheses.
                {
                    if (stack.Count == 0 || stack.Pop() != parentheses[ch])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0; /// If stack is empty, all parentheses are valid.
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;

            Program pr = new();

            Console.WriteLine(pr.IsValid(input));
        }
    }
}
