using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;

namespace Homework9;

class Program
{
    public static void Main (string[] args) 
    {
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");
        
        foreach(Student stu in Student.studentList){
            stu.PrintInfo();
        }
        
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if(gradebook.Contains("Tom")==false){
            gradebook.Add("Tom", 3.3);
        }
        var avg_gpa = gradebook.Values.Average();
        
        Console.WriteLine($"The average GPA is: {avg_gpa}");
        if(gradebook.Values>avg_gpa){
            Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
        }
    }
}

class Student
{
    public int studentID { get; set; }
    public string studentName { get; set; }
    public void PrintInfo(){
        
    }
    public Student(int inputID, string inputName){
        studentID = inputID;
        studentName = inputName;
        studentList.Add(this);
    }
    public static List<Student> studentList = new List<Student>();
}