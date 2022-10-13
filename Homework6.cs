namespace Homework6;
class Professor
{
    public string profName;
    public string classTeach;
    private double salary;
    
    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }
    
    public double GetSalary()
    {
        return salary;
    }
}

class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;
    
    public void SetStudentGrade(double newGrade)
    {
        studentGrade = newGrade;
    }
    
    public double GetStudentGrade()
    {
        return studentGrade;
    }
}


class Program 
{
    static void Main() 
    {
        Professor prof1 = new Professor();
        prof1.profName = "Alice";
        prof1.classTeach = "Java";
        prof1.SetSalary(9000.0);
        
        Professor prof2 = new Professor();
        prof2.profName = "Bob";
        prof2.classTeach = "Math";
        prof2.SetSalary(8000.0);
        
        Student stud1 = new Student();
        stud1.studentName = "Lisa";
        stud1.classEnroll = "Java";
        stud1.SetStudentGrade(90.0);
        
        Student stud2 = new Student();
        stud2.studentName = "Tom";
        stud2.classEnroll = "Math";
        stud2.SetStudentGrade(80.0);
        
        
        Console.WriteLine("Professor " + prof1.profName + " teaches " + prof1.classTeach + ", and the salary is: " + prof1.GetSalary());
        Console.WriteLine("Professor " + prof2.profName + " teaches " + prof2.classTeach + ", and the salary is: " + prof2.GetSalary());
        Console.WriteLine("Student " + stud1.studentName + " enrolls " + stud1.classEnroll + ", and the grade is: " + stud1.GetStudentGrade());
        Console.WriteLine("Student " + stud1.studentName + " enrolls " + stud1.classEnroll + ", and the grade is: " + stud2.GetStudentGrade());
        
        Console.WriteLine("The salary difference between " + prof1.profName + " and " + prof1.profName + " is: " + (prof1.GetSalary() - prof2.GetSalary()));
        Console.WriteLine("The total grade of " + stud1.studentName + " and " + stud2.studentName + " is: " + (stud1.GetStudentGrade() + stud2.GetStudentGrade()));
        
    }
}