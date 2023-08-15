using System;

namespace CsharpString{
    class Test{
        public static void Main(string [] args){
              //create string
              string str1 = "C# Programming";
              string str2 = "Python";
              string str3 = "C# Programming";

              Console.WriteLine("str1 length"+str1.Length);
              Console.WriteLine("str2 length"+str2.Length);

              //Concat() method
              //join two strings
              string joinedString = string.Concat(str1,str2);
              Console.WriteLine("Joined String: "+joinedString);

              //comparison between two strings //Equals() method
              Boolean result = str1.Equals(str3);
              Console.WriteLine("string 1 and string 3 are equal: "+result);
        }
    }
}