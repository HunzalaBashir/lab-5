using System;

public enum Department
{
    Science,
    Arts,
    Commerce,
    Engineering,
    Medicine
}

public class Person
{
    private string name;

    public Person() => name = null;

    public Person(string name) => this.name = name;

    public string Name
    {
        get => name;
        set => name = value;
    }
}

public class Student : Person
{
    private string regNo;
    private int age;
    private Department program;

    public Student() : base()
    {
        regNo = null;
        age = 0;
        program = default;
    }

    public Student(string name, string regNo, int age, Department program) : base(name)
    {
        this.regNo = regNo;
        Age = age; // Using property for validation
        this.program = program;
    }

    public string RegNo
    {
        get => regNo;
        set => regNo = value;
    }

    public int Age
    {
        get => age;
        set
        {
            if (value < 0)
                throw new ArgumentException("Age cannot be negative.");
            age = value;
        }
    }

    public Department Program
    {
        get => program;
        set => program = value;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name = "Evelyn";
        student1.RegNo = "S345";
        student1.Age = 19;
        student1.Program = Department.Arts;

        Student student2 = new Student("Frank", "S678", 24, Department.Engineering);

        Console.WriteLine("Student 1:");
        PrintStudentDetails(student1);

        Console.WriteLine("\nStudent 2:");
        PrintStudentDetails(student2);
    }

    public static void PrintStudentDetails(Student student)
    {
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Registration Number: {student.RegNo}");
        Console.WriteLine($"Age: {student.Age}");
        Console.WriteLine($"Program: {student.Program}");
    }
}