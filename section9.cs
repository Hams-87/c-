using System;
namespace section9;
public  class person{
    private string _name;
    private int _age;
    
    public string Name{
        get{
            return _name;
        }
        set{
            if(value == null || value =="" ||  value.Length>=32){
            throw new Exception("Invalid Name");
        }
            _name=value;
        }

    }
    
    public person(string name,int age){

        if(age<=0||age>128){
            throw new Exception("Invaild age");
        }
        Name=name;
        _age=age;

    }
    public int GetAge()=>_age;
    public  virtual void Print(){
        Console.WriteLine(
            $"my name is{Name} my age{_age}");
    }
}
public class Student : person{
    private int _year;
    private float _gpa;
    public int Year{
        get{
            return _year;
        }
        set{
            if(value<=0 || value>5){
            throw new Exception("Invaild year");
           

        }
         _year=value;
        }
    }
      public float Getgpa()=>_gpa;
    public Student (string name , int age, int year ,float gpa):base(name,age){
        
        if(gpa<=0 || gpa>4){
            throw new Exception("Invaild gpa");

        }
        Year=year;
        _gpa=gpa;

    }
     
    public override void Print(){
        Console.WriteLine(
            $"my name is{Name} my age{GetAge()},and gpa is {Getgpa()}");
    }
}
public class Staff: person{
    private double _salary;
    public double GetSalary()=>_salary;
    private int _joinyear;
    public int Joinyear{
        get{
            return _joinyear;
        }
        set{
            if(value<=21){
            throw new Exception("Invaild joinyear");
        }
        _joinyear=value;


        }
    }
    public Staff(string name,int age,double salary,int joinyear):base(name,age){
        if(salary<=0 || salary>120000){
            throw new Exception("Invaild salary");

        }
        if(joinyear<=21){
            throw new Exception("Invaild joinyear");

        }
        _salary=salary;
        Joinyear=joinyear;

    }
    public  override void Print(){
        Console.WriteLine(
            $"my name is{Name} my age{GetAge()},and my salary is {_salary}");
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
       try{
       var student=new Student(name,age,year,gpa);
       database.AddStudent(student);
       student.Year=0;
       }
       catch(Exception a){
        Console.WriteLine(a.Message);

       }
       
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
       try{
       var staff=new Staff(name2,age2,salary,joinyear);
       database.AddStaff(staff);
       staff.Joinyear=0;
       }
       catch(Exception b){
          Console.WriteLine(b.Message);
        }
        break;
        case 3:
           database.PrintAll();
            break;
        case 4:
         Console.Write("name: ");
         var name3=Console.ReadLine();
         Console.Write("age: ");
         var age3=Convert.ToInt32(Console.ReadLine());
         try{
         var person=new person(name3,age3);
         database.Addperson(person);
         person.Name=null;
         }

         catch(Exception c){
            Console.WriteLine(c.Message);
        
         }break;

         
         
        default:
             return;
        }

       }
       

       }}

