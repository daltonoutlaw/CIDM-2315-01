//main branch
namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor prof1 = new Professor();
        prof1.profName="Alice";
        prof1.classTeach="Java"; 

        Professor prof2 = new Professor();
        prof2.profName="Bob";
        prof2.classTeach="Math";

        Student stu1 = new Student();
        stu1.studentName="Lisa";
        stu1.classEnroll="Java";

        Student stu2 = new Student();
        stu2.studentName="Tom";
        stu2.classEnroll="Math";

        prof1.SetSalary(9000);
        Console.WriteLine($"Professor {prof1.profName} teaches {prof1.classTeach}, and the salary is: "+prof1.GetSalary());
        prof2.SetSalary(8000);
        Console.WriteLine($"Professor {prof2.profName} teaches {prof2.classTeach}, and the salary is: "+prof2.GetSalary());
        stu1.SetGrade(90);
        Console.WriteLine($"Student {stu1.studentName} enrolls {stu1.classEnroll}, and the grade is: "+stu1.GetGrade());
        stu2.SetGrade(80);
        Console.WriteLine($"Student {stu2.studentName} enrolls {stu2.classEnroll}, and the grade is: "+stu2.GetGrade());
        Console.WriteLine($"The salary difference between {prof1.profName} and {prof2.profName} is: "+(prof1.GetSalary()-prof2.GetSalary()));
        Console.WriteLine($"The total grade of {stu1.studentName} and {stu2.studentName} is: "+(stu1.GetGrade()+stu2.GetGrade()));
    }
}

//Professor class
class Professor
{
    public string profName;
    public string classTeach;
    private double salary;

    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary(){
        return salary;
    }
}

//Student class
class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }

    public double GetGrade(){
        return studentGrade;
    }
}


