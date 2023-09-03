using System;

public class nestedIfStatement
{
    public static void Main(string[] args){
        Console.Write("Enter the first string: ");
        string firstString = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string secondString = Console.ReadLine();

        bool areEqualCaseSensitive = firstString.Equals(secondString);
        bool areEqualCaseInSensitive = firstString.Equals(secondString, StringComparison.OrdinalIgnoreCase);
        
        if(areEqualCaseSensitive==false){
            Console.WriteLine("Case sensitive works.They are not equal!");
        }
       
        // Console.WriteLine("Case-insensitive comparison: " + areEqualCaseInSensitive);
         if(areEqualCaseInSensitive==true){
            Console.WriteLine("Case sensitive doesn't work.They are equal!");
        }


         
    }
}
//Compare hw