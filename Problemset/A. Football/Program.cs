namespace A._Football
{
    internal class Program
    {
        // Problem Link: https://codeforces.com/problemset/problem/43/A
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine()!);
            //Define dictionary store the team name with it's number of goals
            Dictionary<string, int> teamGoals = new Dictionary<string, int>();

            while (numberOfLines-- > 0)
            {
                string teamName = Console.ReadLine()!;
                //This team name doesn't exist in the dictionary, so we add it
                //with one goal as first goal
                if (!teamGoals.ContainsKey(teamName))
                {
                    teamGoals.Add(teamName, 1);
                }
                //This team already exist so we increment it's number of goals by one
                else
                {
                    teamGoals[teamName]++;
                }
            }

            //To iterate on which key in dictionary has highest value, so it will be the winner
            string winnerKey = "";
            int winnerValue = int.MinValue;

            foreach (var kvp in teamGoals)
            {
                if (kvp.Value > winnerValue)
                {
                    winnerKey = kvp.Key;
                    winnerValue = kvp.Value;
                }
            }

            Console.WriteLine(winnerKey);
        }
    }
}