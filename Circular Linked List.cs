using System;

class Node {
  
      public int Data;
      public Node Next;
    
    public Node(int data) {
     
      Data = data;
      Next = null;
    }
}


class CircularLinkedList {
  
      private Node head;
    
    public CircularLinkedList() {
      
      head = null;  
    }
    
    public void AddLast(int data) {
      
      Node newNode = new Node(data);
      
      if(head == null) {
        head = newNode;
        head.Next = head;
      } 
      else {
          Node current = head;
       
        while(current != head) {
          current = current.Next;
        }
        
          current = newNode;
          newNode.Next = head;
      }
    }
    
  public void PrintList() {
    
    if(head == null) {
      Console.Write("List ว่าง: ");
      return;
    }
      Node current = head;
     
      do{
        Console.Write(current.Data + "-->");
        current = current.Next;
      }
      
      while(current != head);
      Console.Write("(กลับมาทำงานในส่วน Head)");
      
  }
}

class Program {
  static void Main(string[] args) {
    
    CircularLinkedList cll = new CircularLinkedList();
    cll.AddLast(10);
    cll.AddLast(20);
    cll.AddLast(30);
    cll.AddLast(40);
    cll.AddLast(50);
    Console.Write("Circular Linked List: ");
    cll.PrintList();
  }
}