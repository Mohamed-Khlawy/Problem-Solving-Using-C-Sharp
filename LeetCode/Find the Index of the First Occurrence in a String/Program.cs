namespace Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal class Program
    {
        public int StrStr(string haystack, string needle)
        {
            int firstNeedleOccurrence = haystack.IndexOf(needle);

            return firstNeedleOccurrence;
        }
        static void Main(string[] args)
        {
            string haystack = Console.ReadLine()!;

            string needle = Console.ReadLine()!;

            Program pr = new Program();

            int firstNeedleOccurrence = pr.StrStr(haystack, needle);

            Console.WriteLine(firstNeedleOccurrence);
        }
    }
}
