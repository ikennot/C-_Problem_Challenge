public class LinkedListPrac {

    // Inner Node class
    private class Node {
        int data;
        Node next;

        Node(int data) {
            this.data = data;
            this.next = null;
        }
    }

    // Head and tail references for the LinkedList
    private Node head = null;
    private Node tail = null;

    // Add a new node to the linked list
    public void add(int data) {
        Node newNode = new Node(data);

        if (head == null) { // First node in the list
            head = newNode;
            tail = newNode;
        } else {
            tail.next = newNode; // Link the new node
            tail = newNode;      // Update the tail reference
        }
    }

    // Display the linked list
    public void disp() {
        if (head == null) {
            System.out.println("LinkedList is Empty");
            return;
        }

        Node curr = head;
        while (curr != null) {
            System.out.print(curr.data + " ");
            curr = curr.next;
        }
        System.out.println(); // Print a newline after the list
    }

    // Main method
    public static void main(String[] args) {
        LinkedListPrac l1 = new LinkedListPrac();

        l1.add(1);
        l1.add(2);
        l1.add(3);

        l1.disp(); // Correctly call disp method
    }
}
