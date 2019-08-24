using System;

namespace Ciclo_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine(("Escribe los numeros de X a Y para comenzar la numeracion ");
            Console.WriteLine("Desde donde arrancamos el ciclo(X):");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Desde donde arrancamos el ciclo (Y):  ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("De cuanto en cuanto quieres que avance: ");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                for (int i = x; i > y; i -= z)

                {
                    Console.WriteLine("i = " + i);
                }
            }

            else
            {
                for (int i = x; i < y; i += z)

                {
                    Console.WriteLine("i = " + i);
                }
            }

        }
    }
}
