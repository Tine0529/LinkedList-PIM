🧩 Data Structure Practice — Linked List in C#

โปรเจกต์นี้เป็นการฝึกเขียน โครงสร้างข้อมูลแบบ Linked List ในภาษา C#
โดยประกอบด้วย 3 โปรแกรม ได้แก่ Singly Linked List, Doubly Linked List และ Circular Linked List
ซึ่งแสดงให้เห็นถึงการทำงานของการเชื่อมโยงข้อมูลในรูปแบบต่าง ๆ

1️⃣ Singly Linked List

ไฟล์: LinkedList.cs
สิ่งที่ทำ:
สร้างคลาส Node ที่เก็บข้อมูล (Data) และตัวชี้ (Next) ไปยังโหนดถัดไป
สร้างคลาส LinkedList เพื่อ
เพิ่มข้อมูลที่ท้ายลิสต์ (AddLast)
แสดงข้อมูลทั้งหมดในลิสต์ (PrintList)
ทดสอบใน Main() โดยเพิ่มข้อมูลและแสดงผล

2️⃣ Doubly Linked List

ไฟล์: DoublyLinkedList.cs
สิ่งที่ทำ:
เพิ่มโครงสร้างให้ Node มีทั้งตัวชี้ Next และ Prev
สร้างคลาส DoublyLinkedList เพื่อ
เพิ่มข้อมูลที่ท้ายลิสต์ (AddLast)
แสดงข้อมูลจากหน้าไปหลัง (PrintForward)
แสดงข้อมูลจากหลังไปหน้า (PrintBackward)
ทดสอบใน Main() ด้วยการแสดงข้อมูลทั้งสองทิศทาง

3️⃣ Circular Linked List

ไฟล์: CircularLinkedList.cs
สิ่งที่ทำ:
พัฒนา Node ให้เชื่อมโยงกลับไปยัง head เมื่อถึงโหนดสุดท้าย
สร้างคลาส CircularLinkedList เพื่อ
เพิ่มข้อมูล (AddLast)
แสดงข้อมูลวนลูปกลับไปที่หัว (PrintList)
ทดสอบใน Main() ด้วยการเพิ่มข้อมูลหลายค่าและพิมพ์ผล
