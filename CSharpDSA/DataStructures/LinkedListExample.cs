namespace CSharpDSA.DataStructures
{
    public class SinglyLinkedList
    {
        public int data;
        public SinglyLinkedList? next;

        public SinglyLinkedList(int data)
        {
            this.data = data;
            next = null;
        }
    }
    public class DoublyLinkedList
    {
        public int data;
        public DoublyLinkedList? next;
        public DoublyLinkedList? prev;

        public DoublyLinkedList(int data)
        {
            this.data = data;
            next = null;
            prev = null;
        }
    }
    internal static class LinkedListExample
    {
        static LinkedListExample()
        {
            Console.WriteLine("Welcome to LinkedList Section");
        }
        public static void Run()
        {
            //LinkedLists are used to store data in a linear order
            Console.WriteLine("Press Program No...[Press1 for normal array implementation]");
            int program = int.Parse(Console.ReadLine());
            switch (program)
            {
                case 1:
                    L1_SinglyLinkedList();
                    break;
                case 2:
                    L2_DoublyLinkedList();
                    break;
                case 3:
                    L3_CircularLinkedList();
                    break;
                case 4:
                    L4_CircularDoublyLinkedList();
                    break;

            }
        }

        private static void L1_SinglyLinkedList()
        {
            //Allows traversal in only one direction
            SinglyLinkedList? customLinkednode = new SinglyLinkedList(10);
            customLinkednode.next = new SinglyLinkedList(20);
            customLinkednode.next.next = new SinglyLinkedList(30);
            customLinkednode.next.next.next = new SinglyLinkedList(40);

            Console.WriteLine("LinkedList Elements are:");
            while (customLinkednode != null)
            {
                Console.WriteLine(customLinkednode.data);
                customLinkednode = customLinkednode.next;
            }

        }
        private static void L2_DoublyLinkedList()
        {
            //Allows traversal in both directions
            DoublyLinkedList? customLinkednode = new DoublyLinkedList(10);
            customLinkednode.next = new DoublyLinkedList(20);

            customLinkednode.next.next = new DoublyLinkedList(30);
            customLinkednode.next.next.prev = customLinkednode.next;

            customLinkednode.next.next.next = new DoublyLinkedList(40);
            customLinkednode.next.next.next.prev = customLinkednode.next.next;

            Console.WriteLine("LinkedList Elements are:");
            while (customLinkednode != null)
            {
                Console.WriteLine(customLinkednode.data);
                customLinkednode = customLinkednode.next;
            }


        }
        private static void L3_CircularLinkedList()
        {
            //Last node points to the first node
            SinglyLinkedList customLinkednode = new SinglyLinkedList(10);
            customLinkednode.next = new SinglyLinkedList(20);
            customLinkednode.next.next = new SinglyLinkedList(30);
            customLinkednode.next.next.next = customLinkednode;

            Console.WriteLine("LinkedList Elements are:");
            do
            {
                Console.WriteLine(customLinkednode?.data);
                customLinkednode = customLinkednode?.next;
            }
            while (customLinkednode?.data != 10);

        }
        private static void L4_CircularDoublyLinkedList()
        {
            //Last node points to the first node and first node points to the last node
            DoublyLinkedList? customLinkednode = new DoublyLinkedList(10);
            customLinkednode.next = new DoublyLinkedList(20);

            customLinkednode.next.next = new DoublyLinkedList(30);
            customLinkednode.next.next.prev = customLinkednode.next;

            customLinkednode.next.next.next = new DoublyLinkedList(40);
            customLinkednode.next.next.next.prev = customLinkednode.next.next;

            customLinkednode.next.next.next.next = customLinkednode;
            customLinkednode.prev = customLinkednode.next.next.next;

            Console.WriteLine("LinkedList Elements are:");
            do
            {
                Console.WriteLine(customLinkednode?.data);
                customLinkednode = customLinkednode?.next;
            }
            while (customLinkednode?.data != 10);
        }

    }
}