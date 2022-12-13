using System;
namespace section9;
public abstract class person{
    public string Name;
    public int Age;
    public person(string name,int age){
        Name=name;
        Age=age;

    }
    public abstract void Print();
}
public class Student : person{
    public int Year;
    public float Gpa;

    public Student (string name , int age, int year ,float gpa):base(name,age){
        Year=year;
        Gpa=gpa;

    }
    public override void Print(){
        Console.WriteLine(
            $"my name is{Name} my age{Age},and gpa is {Gpa}");
    }
}
public class Staff: person{
    double Salary;
    int Joinyear;
    public Staff(string name,int age,double salary,int joinyear):base(name,age){
        Salary=salary;
        Joinyear=joinyear;

    }
    public override void Print(){
        Console.WriteLine(
            $"my name is{Name} my age{Age},and my salary is {Salary}");
    }

}
public class Database{
    private int _currentindex;
    public person[]people=new person [50];
    public void addStudent(Student student){
        people[_currentindex++]=student;
    }
}
public class program{
    private static void Main(){
       var database=new Database();
       Console.Write("name: ");
       var name=Console.ReadLine();
       Console.Write("age: ");
       var age=Convert.ToInt32(Console.ReadLine());
       Console.Write("Year: ");
       var year =Convert.ToInt32(Console.ReadLine());
       Console.Write("GPA: ");
       var gpa=Convert.ToSingle(Console.ReadLine());
       Console.Write("salary: ");
       var salary=Convert.ToDouble(Console.ReadLine());
       Console.Write("joinyear: ");
       var joinyear=Convert.ToInt32(Console.ReadLine());
       int n=Convert.ToInt32(Console.ReadLine());
       if(n==1){
        var student=new Student(name,age,year,gpa);
       }
       else if(n==2){
        var staff=new Staff(name,age,salary,joinyear);
       }
      
       }


    }
}