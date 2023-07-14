using System;

public class differentClass
{
    class Employee{
        public string Name;
        public int Age;

        public string Work(string work){
            return "Work: " + work;
        }
    }
    class EmployeeDrive{
         public static void Main(string[] args){
            Employee emp = new Employee();

            emp.Name = "KZT";
            emp.Age = 25;

            string work = emp.Work("Coding");
            Console.WriteLine(emp.Name + ":" + emp.Age + ":" + work);
        }
    }
}