/* Tania Garcia*/

using System;

class Ejercicio3
{
    public static void Main(string[] args)
    {
        double n = 9.75;
        int n1 = 7;

        //CONVERSION DE DOUBLE A INT
        int doubleint = Convert.ToInt32(n);

        //CONVERSION DE INT A DOUBLE
        double con = Convert.ToDouble(n1);

        Console.WriteLine("Valor original double: " + n);
        Console.WriteLine("Double convertido a int :" + doubleint);
        Console.WriteLine("Valor original int: " + n1);
        Console.WriteLine("Int convertido a double: " + con);

    }


}
