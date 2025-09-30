using System;

class Node {
 
    public int Data;
    public Node Next;
    public Node Prev;
    


  public Node(int data) {
  
    Data = data;
    Next = null;
    Prev = null;
  
  }
 
}


class DoublyLinkedList {
  
  private Node head;
  public DoublyLinkedList() {
    head = null;
  }
  
  public void AddLast(int data) {
    Node newNode = new Node(data);
    if (head == null) {
      head = newNode;
    }
    else{
      Node current = head;
      while (current.Next != null) {
        current = current.Next;
      }
      current.Next = newNode;
      newNode.Prev = current;
    }
  }
  
  public void PrintForward() {
    Node current = head;
    while (current != null) {
      Console.Write(current.Data + "<-->");
      current = current.Next;
    }
    Console.WriteLine("null");
  }
  
  public void PrintBackward() {
    if (head == null) return;
    Node current = head;
    while (current.Next != null) {
      current = current.Next;
    }
    while (current != null) {
      Console.Write(current.Data + "<-->");
      current = current.Prev;
    }
    Console.WriteLine("null");
  }
}


class Program {
  static void Main(string[] args) {
    DoublyLinkedList dll = new DoublyLinkedList();
    dll.AddLast(10);
    dll.AddLast(20);
    dll.AddLast(30);
    dll.AddLast(40);
    Console.Write("แสดงข้อมูลจากหน้าไปหลัง: ");
    dll.PrintForward();
    Console.Write("แสดงข้อมูลจากหลังไปหน้า: ");
    dll.PrintBackward();
  }
}