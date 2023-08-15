using System;

namespace CsharpString
{
    class Test{
    public static void Main(string[] args){
        //string
        string s1 = "A string is more ";
        string s2 = "than the sum of its chars.";

// Concatenate s1 and s2. This actually creates a new
// string object and stores it in s1, releasing the
// reference to the original object.
        s1 += s2;//s1 = s1+ s2

        Console.WriteLine(s1.ToUpper());
        Console.WriteLine(s2.ToLower());
// Output: A string is more than the sum of its chars.

       string x = "10";
       string y = "20";
       string z = x + y ;
       Console.WriteLine(z);

       //string interpolation
       string firstName = "Neural";
       string lastName = "Tech";
       string fullName = $"My full name is :{firstName} {lastName}";
       Console.WriteLine(fullName);
    }
    }
    
}