using System;
using Internal;

//Variable Scope
//Class Level Scope -- global variable
//Method Level Scope -- local variable
//Block Level Scope
public class classLevel
{
    public string str = "Class Level";
    //Class Level Variable

    public void method(){
        //method level variable 
      string me = "method level";
       Console.WriteLine(me);
       }

    public void display(){
        Console.WriteLine(str);
        int i;
        for (i = 0; i <= 3;i++){
            Console.WriteLine(i);
        }
        Console.WriteLine("New i: "+(i + 4));

    }

    public static void Main(string[] args){
        classLevel p = new classLevel();
        p.display();
        p.method();
    }
}