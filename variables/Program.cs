using System;


namespace variables
{

    class Program
    {

        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 5;
            int suma = num1 + num2;

            double d1=3.2;
            double d2=1.345;
            double sumadeci= d1 + d2;

            
            double sumamix_2= num1 + d1;

            num1=25;

            float f1= 3.5f;
            float f2 = 4.5f;

            Console.WriteLine("La suma de "+num1+" mas "+num2+" da como resultado "+suma);
            Console.WriteLine("La suma de "+d1+" mas "+d2+" da como resultado "+sumadeci);
            Console.WriteLine("La suma de "+num1+" mas "+d1+" da como resultado "+sumamix_2);
            Console.WriteLine("La suma de"+ f1+" mas "+f2+ "da como resultado "+ (f1 + f2));
            Console.Read();



        }
    }
 


}
