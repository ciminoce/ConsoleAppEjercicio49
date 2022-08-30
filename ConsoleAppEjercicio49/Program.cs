using System;
using System.Threading.Channels;

namespace ConsoleAppEjercicio49
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int contador = 1; contador <=5; contador++)
            {
                Console.Write("Ingrese un número cualquiera:");
                var nroIngresado= int.Parse(Console.ReadLine());
                //suma = suma + nroIngresado;
                suma += nroIngresado;
            }

            Console.WriteLine($"La suma de los nros ingresados es {suma}");
            Console.ReadLine();
        }
    }
}
