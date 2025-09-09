using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definimos dos numeros para comparar.
            int miNumero1 = 100;
            int miNumero2 = 50;

            Console.WriteLine("Vamos a comparar dos números:");
            Console.WriteLine("Mi primer número es: {miNumero1}");
            Console.WriteLine("Mi segundo número es: {miNumero2}\n");

            // Comprobamos si el primer numero es menor que el segundo numero
            if (miNumero1 < miNumero2)
            {
                Console.WriteLine("¿El primer número es menor que el segundo numero? Sí, verdadero.");
            }
            else
            {
                Console.WriteLine("¿El primer número es menor que el segundo numero? No, es falso.");
            }

            // Comprobamos si el primer numero es mayor que el segundo numero
            if (miNumero1 > miNumero2)
            {
                Console.WriteLine("¿El primer número es mayor que el segundo numero? Sí, verdadero.");
            }
            else
            {
                Console.WriteLine("¿El primer número es mayor que el segundo numero? No, es falso.");
            }

            // Comprobamos si son iguales
            if (miNumero1 == miNumero2)
            {
                Console.WriteLine("¿Los numeros son iguales? Sí, verdadero.");
            }
            else
            {
                Console.WriteLine("¿Los numero son iguales? No, es falso.");
            }

            // Comprobamos si son diferentes
            if (miNumero1 != miNumero2)
            {
                Console.WriteLine("¿Los numeros son diferentes? Sí, verdadero.");
            }
            else
            {
                Console.WriteLine("¿Los numero son diferentes? No, es falso.");
            }

            // Comprobamos si el primero es menor o igual
            if (miNumero1 <= miNumero2)
            {
                Console.WriteLine("¿El primer número es menor o igual que el segundo numero? Sí, verdadero.");
            }
            else
            {
                Console.WriteLine("¿El primer número es menor o igual que el segundo numero? No, es falso.");
            }

            // Comprobamos si el primero es mayor o igual
            if (miNumero1 >= miNumero2)
            {
                Console.WriteLine("¿El primer número es mayor o igual que el segundo numero? Sí, verdadero.");
            }
            else
            {
                Console.WriteLine("¿El primer número es mayor o igual que el segundo numero? No, es falso.");
            }

            Console.ReadKey(); // Para que la consola no se cierre de repente
        }
    }
}
