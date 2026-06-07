namespace Merge_Two_Sorted_Lists
{
    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class Program
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode(); /// dummy node to simplify edge cases
            ListNode current = dummy; /// pointer to build the merged list

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1; /// attach list1 node
                    list1 = list1.next!; /// move list1 pointer
                }
                else
                {
                    current.next = list2; /// attach list2 node
                    list2 = list2.next!; /// move list2 pointer
                }

                current = current.next; /// move current pointer
            }

            current.next = list1 ?? list2; /// attach remaining nodes

            return dummy.next!; /// return head of merged list
        }
        static ListNode BuildList(List<int> values)
        {
            ListNode dummy = new ListNode(); /// dummy node to simplify edge cases
            ListNode current = dummy; /// pointer to build the list
            foreach (int val in values)
            {
                current.next = new ListNode(val); /// create new node and attach
                current = current.next; /// move current pointer
            }
            return dummy.next!; /// return head of the list
        }
        static void Main(string[] args)
        {
            ListNode list1 = BuildList(Console.ReadLine()!.Split(',').Select(int.Parse).ToList());
            ListNode list2 = BuildList(Console.ReadLine()!.Split(',').Select(int.Parse).ToList());

            Program program = new Program();

            ListNode mergedList = program.MergeTwoLists(list1, list2);

            // Print merged list
            while (mergedList != null)
            {
                Console.Write(mergedList.val + " ");
                mergedList = mergedList.next!;
            }
        }
    }
}
