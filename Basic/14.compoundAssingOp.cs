/*
Compound Assignment Operators
------------------------------------
+=
-=
*=
/=
%=
&=
|=
^=
<<=
>>=
=>     Lambda operator
*/
using System;
using Internal;

public class compoundAssignment
{
    public static void Main(string[] args){
        int number = 10;

        number +=5;
        Console.WriteLine(number);

        number -=3;
        Console.WriteLine(number);

        number *=2;
        Console.WriteLine(number);

        number /=3;
        Console.WriteLine(number);

        number %=3;
        Console.WriteLine(number);

        number &=5;
        Console.WriteLine(number);

        number |=5;
        Console.WriteLine(number);

        number ^=12;
        Console.WriteLine(number);

        number <<=2;
        Console.WriteLine(number);

        number >>=3;
        Console.WriteLine(number);
        
    }

}