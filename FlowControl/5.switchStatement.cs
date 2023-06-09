using System;

public class switchStatement
{
    public static void Main(string[] args){
          char ch;
          Console.WriteLine("Enter an alphabet: ");
          ch = Convert.ToChar(Console.ReadLine());
          switch(Char.ToLower(ch)){
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Vowel");
                break;
            default:
               Console.WriteLine("Not a vowel");
               break;
          }
          
    }
}