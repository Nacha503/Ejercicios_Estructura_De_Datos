using System;
using System.Collections.Generic;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lEnteros = new List<int>();
            int valor;
            bool continuar = true;

            do
            {
                try
                {
                    valor = Convert.ToInt32(Console.ReadLine());
                    lEnteros.Add(valor);

                }
                catch (Exception)
                {
                    continuar = false;
                    //throw new Exception("no se puede almacenar el valor");

                }

            } while (continuar);


            lEnteros.Sort();

            Console.WriteLine("Elementos ordenados:");

            foreach (var item in lEnteros)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();


        }
    }
}
