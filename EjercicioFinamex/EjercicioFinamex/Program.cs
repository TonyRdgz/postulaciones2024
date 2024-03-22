using System;

namespace EjercicioFinamex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declara un ciclo de enteros hasta 100
            for (int num=0; num <= 100; num++) {

                //Se declara la primera condición de nuestro programa, para cuando si el entero "num" es multiplo de 3 o 5, imprima: "FizzBuzz"
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                //Se declara la tercera condición, para cuando si el entero "num" es multiplo de 3, imprima: "Fizz"
                else if (num % 3 == 0) {
                    Console.WriteLine("Fizz");

                }
                //Se declara la segunda condición, para cuando si el entero "num" es multiplo de 5, imprima: "Buzz"
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                //Se declara la cuarta condición o default, para cuando si el entero "num" NO es multiplo de 3 ni 5, imprima: num
                else
                {
                    Console.WriteLine(num);
                }
            }

        }
    }
}
