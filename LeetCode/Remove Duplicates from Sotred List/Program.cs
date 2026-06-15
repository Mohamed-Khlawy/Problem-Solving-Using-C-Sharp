namespace Remove_Duplicates_from_Sotred_List
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
        public ListNode? DeleteDuplicates(ListNode head)
        {
            if (head == null) return null; // Check if the list is empty

            ListNode current = head; // Start from the head of the list

            while (current != null && current.next != null)
            {
                if (current.val == current.next.val)
                {
                    current.next = current.next.next; // Skip the duplicate node
                }
                else
                {
                    current = current.next; // Move to the next node
                }
            }

            return head; // Return the modified list
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            // Example usage:
            ListNode head = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));

            ListNode? result = p.DeleteDuplicates(head);

            // Print the result
            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
        }
    }
}
