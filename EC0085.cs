using System;
using System.Globalization;

class EC0085
{
    static void Main(String [] args)
    {
        
        let a = 3;
        let b;
        let c;

        b = ++a;
        c = a++;
        b = b * 3;
        a = a * 2;

        console.log("a =", a);
        console.log("b =", b);
        console.log("c =", c);

    }
}