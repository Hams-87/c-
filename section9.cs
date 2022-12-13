using System;
namespace section9;
public  class person{
    public string Name;
    public int Age;
    public person(string name,int age){
        Name=name;
        Age=age;

    }
    public  virtual void Print(){
        Console.WriteLine(
            $"my name is{Name} my age{Age}");
    }
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
    public  override void Print(){
        Console.WriteLine(
            $"my name is{Name} my age{Age},and my salary is {Salary}");
    }

}
public class Database{
    private int _currentindex;
    public person[]people=new person [50];
    public void AddStudent(Student student){
        people[_currentindex++]=student;
    }
    public void AddStaff(Staff staff){
        people[_currentindex++]=staff;
    }
    public void PrintAll(){
        for(int i=0;i<_currentindex;i++){
            people[i].Print();}
    }
    public void Addperson(person person){
        people[_currentindex++]=person;
    }
}
public class program{
    private static void Main(){
       var database=new Database();
       while(true){
        Console.Write("1)add student,2)add staff,3) show all,4)add non student ,non staff");
        int n=Convert.ToInt32(Console.ReadLine());
        switch(n){
        case 1:
        Console.Write("name: ");
       var name=Console.ReadLine();
       Console.Write("age: ");
       var age=Convert.ToInt32(Console.ReadLine());
       Console.Write("Year: ");
       var year =Convert.ToInt32(Console.ReadLine());
       Console.Write("GPA: ");
       var gpa=Convert.ToSingle(Console.ReadLine());
       var student=new Student(name,age,year,gpa);
       database.AddStudent(student);
       
            break;
        case 2:
        Console.Write("name: ");
       var name2=Console.ReadLine();
       Console.Write("age: ");
       var age2=Convert.ToInt32(Console.ReadLine());
       Console.Write("salary: ");
       var salary=Convert.ToDouble(Console.ReadLine());
       Console.Write("joinyear: ");
       var joinyear=Convert.ToInt32(Console.ReadLine());
       var staff=new Staff(name2,age2,salary,joinyear);
       database.AddStaff(staff);
        break;
        case 3:
           database.PrintAll();
            break;
        case 4:
         Console.Write("name: ");
         var name3=Console.ReadLine();
         Console.Write("age: ");
         var age3=Convert.ToInt32(Console.ReadLine());
         var person=new person(name3,age3);
         database.Addperson(person);
         break;
         default:
             return;
        }

       }
       

       }
     


    }
