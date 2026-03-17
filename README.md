นาย อัครพล สร้อยเสนา 683450198-9

# Grade Calculation System (C#)

## 📌 Description
ระบบคำนวณเกรดสำหรับหลักสูตรวิทยาการคอมพิวเตอร์และสารสนเทศ  
สามารถสร้างรายวิชา เพิ่มนักศึกษา และคำนวณผลลัพธ์ต่าง ๆ ได้

---

## 🧱 Class Diagram (อธิบาย)

### 1. Person (Abstract Class)
- name : string
- id : string
- ShowInfo() : abstract

### 2. Student : Person
- score : double
- grade : string
- GetScore()
- GetGrade()
- ShowInfo() (Override)

### 3. Course
- courseName : string
- courseCode : string
- students : List<Student>
- AddStudent()
- ShowAllStudents()
- ShowStatistics()

### 4. Program
- Main() → ควบคุมการทำงานของระบบ

---

## 🎯 OOP Concepts

- Encapsulation: ใช้ private + getter
- Inheritance: Student สืบทอดจาก Person
- Polymorphism: override ShowInfo()
- Abstraction: ใช้ abstract class Person

---

## 📊 Features
- เพิ่มรายวิชา
- เพิ่มนักศึกษา
- คำนวณเกรดอัตโนมัติ
- แสดงคะแนนสูงสุด ต่ำสุด และค่าเฉลี่ย
- แสดงรายชื่อนักศึกษา
- เมนูใช้งานต่อเนื่อง




