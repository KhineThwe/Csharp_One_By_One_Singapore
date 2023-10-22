using System;


public class multipleObject
{
    public class Employee{
        public string department;
    }
    public static void Main(string[] args){
        //emp1 object
        Employee emp1 = new Employee();

        emp1.department = "IT Department";
        Console.WriteLine("Emp1: " + emp1.department);

        //create second emp2 obj
        Employee emp2 = new Employee();
        emp2.department = "Marketing Department";
        Console.WriteLine("Emp2: " + emp2.department);

    }
}