using System;
using System.Collections;
using System.Collections.Generic;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    class Person
    {
        protected string name;
        protected int age;

        public Person()
        {
            name = "nul";
            age = 0;
        }

        public Person(string _Na, int Age)
        {
            name = _Na;
            age = Age;
        }

        public int GetAge() { return age; }
        public void SetAge(int _Age) { age = _Age; }
        public string GetName() { return name; }
        public void SetName(string Pname) { name = Pname; }
    }

    class Student : Person
    {
        
        protected int id;
        protected float grade;
        protected ArrayList subjects;

        public Student()
        {
            id = 0;
            grade = 0f;
            subjects = new ArrayList();
        }

        public Student(int Id, float Grade, string Pname, int Age) : base(Pname, Age)
        {
            id = Id;
            grade = Grade;
            subjects = new ArrayList();
        }

        public Student(int _Id)
        {
            id = _Id;
            grade = 0.0f;
            subjects = new ArrayList();
        }

        // Getters
        public int GetId() { return id; }
        public float GetGrade() { return grade; }
        public ArrayList GetSubjects() { return subjects; }

        // Setters
        public void SetId(int _Id) { id = _Id; }
        public void SetGrade(float _grade) { grade = _grade; }

        public void AddSubject(string subject)
        {
            subjects.Add(subject);
        }

        public void DisplaySubjects()
        {
            Console.WriteLine("Subjects:");
            foreach (string subject in subjects)
            {
                Console.WriteLine($"- {subject}");
            }
        }

        public static void FillStudentData(Student student)
        {
            if (student.GetId() == 0)
            {
                Console.Write("Enter student ID: ");
                student.SetId(int.Parse(Console.ReadLine()));
            }
            else
            {
                Console.WriteLine($"Id is already given and it is: {student.GetId()}");
            }

            Console.Write("Enter student Name: ");
            student.SetName(Console.ReadLine());

            Console.Write("Enter student Grade: ");
            student.SetGrade(float.Parse(Console.ReadLine()));

            Console.Write("Enter student age: ");
            student.SetAge(int.Parse(Console.ReadLine()));

            Console.Write("Enter number of subjects: ");
            int numSubjects = int.Parse(Console.ReadLine());
            for (int i = 0; i < numSubjects; i++)
            {
                Console.Write($"Enter subject {i + 1}: ");
                student.AddSubject(Console.ReadLine());
            }
        }

        public static void DisplayStudentData(Student student)
        {
            Console.WriteLine($"Student ID: {student.GetId()}");
            Console.WriteLine($"Student Name: {student.GetName()}");
            Console.WriteLine($"Student Grade: {student.GetGrade()}");
            Console.WriteLine($"Student Age: {student.GetAge()}");
            student.DisplaySubjects();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, students!");

            
            List<Student> students = new List<Student>();

            // Add students 
            Student studentOne = new Student();
            Student studentTwo = new Student(2, 95.5f, "ehab", 22);
            Student studentThree = new Student(3);
            Student studentFour = new Student();

            students.Add(studentOne);
            students.Add(studentTwo);
            students.Add(studentThree);
            students.Add(studentFour);


            Student.FillStudentData(studentFour);
            Student.FillStudentData(studentThree);


            foreach (Student student in students)
            {
                Student.DisplayStudentData(student);
                Console.WriteLine();
            }

            Console.WriteLine("Enter first number:");
            Calc.x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            Calc.y = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose operation: 1 for Add, 2 for Subtract, 3 for Multiply");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    MyDel addDel = new MyDel(Calc.Add);
                    Calc.Chose(addDel);
                    break;
                case 2:
                    MyDel subDel = new MyDel(Calc.Sub);
                    Calc.Chose(subDel);
                    break;
                case 3:
                    MyDel multDel = new MyDel(Calc.Mult);
                    Calc.Chose(multDel);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        public delegate int MyDel();  

        public class Calc
        {
            public static int x { get; set; }
            public static int y { get; set; }

            
            public static int Add()
            {
                return x + y;
            }

            public static int Sub()
            {
                return x - y;
            }

            public static int Mult()
            {
                return x * y;
            }

            public static void Chose(MyDel m)
            {
                int result = m(); 
                Console.WriteLine("Result: " + result);
            }
        }
        }
}
