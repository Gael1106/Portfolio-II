using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesion 12: Instruccion while 30/09/26
            // Sintaxis: while
            // inicializacion;
            // while (expresion)
            // {
            //    bloque de instrucciones;
            //    iterador;
            // }
            // Iterar; repetir
            // Ejemplo 1: Ciclo ascendente (rango de 1-3)
            // m: variable de control
            int m = 1; // inicializacion
            while (m <= 3) // expresion 
            {
                // bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1; // iterador
            }
            // Ejercitacion
            // 1. Definir un ciclo para imprimir tu nombre 5 veces
            // Nota: para la expreesion, utilizar el operador <.
            // ciclo ascendete
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine("Tu nombre: Gael mendez.");
                n += 1;
            }
            // b. ciclo descendente
            int d = 3;
            while (d >= 1)
            {
                Console.WriteLine($"d: {d}");
                d -= 1;
            }
            // c. Incremento de: 3, 6, 9, 12, 15, 18
            int i = 3;
            while (i <= 18)
            {
                Console.WriteLine($"i: {i}");
                i += 3;
            }
            // d. Definir un ciclo para imprimir 331 8 veces
            // nota. Para la solucion, define un ciclo descendente con decrementos de 2 unidades
            int x = 16;
            while (x > 0)
            {
                Console.WriteLine("331");
                x -= 2;
            }
            // Actividad 1: Ciclo infinito ascendente 
            // 1. Definir un ciclo infinito ascendente
            // 2. definir un ciclo infinito descendente
            // Nota: para la solucion, utilizar el operador de diferencia
            // 1.
            int y = 12;
            while( y != 0)
            {
                y += 50;
            }
            //2. 
            int z = -14;
            while(z != 0)
            {
                z -= 50;
            }
        }
    }
}