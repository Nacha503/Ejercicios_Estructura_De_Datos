using System;
using System.Collections.Generic;

namespace Ejercicio_6
{
    class Program
    {
        //        Write a program that removes from a given sequence all numbers
        //that appear an odd count of times.
        //Example: array = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}
         static List<int> numeros = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

        static void Main(string[] args)
        {

            Console.WriteLine("Ejercicio 6");

            numeros = Eliminar(numeros);

           
            //numeros = BuscarElementosUnicos(numeros);

            foreach (var item in numeros)
            {
                Console.WriteLine(item.ToString());
            }


            Console.ReadKey();

        }

        private static List<int> Eliminar(List<int> numeros)
        {
            int apariciones;
            List<int> numerosConRepeticionesPares = new List<int>(numeros);


            foreach (var item in numeros)
            {
                apariciones = Contar(item);

                if (apariciones % 2 != 0)
                    numerosConRepeticionesPares.Remove(item);
            }

            return numerosConRepeticionesPares;
            
        }

        private static int Contar(int valor)
        {
            int coicidencias = 0;

            foreach (var item in numeros)
            {
                if (valor == item)
                    coicidencias++;
            }

            return coicidencias;

        }

        //private static List<int> BuscarElementosUnicos(List<int> numeros)
        //{
        //    List<int> elementosUnicos = new List<int>();
        //    List<int> elementosYaBuscados = new List<int>();
        //    int apariciones = 0;

        //    foreach (var item in numeros)
        //    {
        //        foreach (var item2 in numeros)
        //        {
        //            if (item == item2)
        //                apariciones++;
        //        }

        //        if ((apariciones % 2) == 0)
        //            elementosUnicos.Add(item);

        //        apariciones = 0;
        //    }

        //    return elementosUnicos;

        //}



    }
}
