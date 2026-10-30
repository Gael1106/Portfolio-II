using System;
namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sesion 13: iteradores
           double recorrido = 0;
            double zancada = 0;
            int numero_hidratacion = 0;
            int recorrido_hidratacion = 2000;

            while (recorrido < 21000)
            {
                recorrido += 0.63;
                zancada += 1;

                if (recorrido >= recorrido_hidratacion)
                {
                    numero_hidratacion += 1;
                    recorrido_hidratacion += 2000;
                    Console.WriteLine($"recorrifo: {recorrido} m\nhidratacion {numero_hidratacion}");
                }
            }

            Console.WriteLine($"Total de zancadas necesarias: {zancada}");
            Console.WriteLine("Recorrido completado: 21 km");

            // sesion 14: ciclo for 141026
            // Ciclo 1. Ccilo for
            /* 
            for (inicializacion; expresion; iterador)
            {
                // bloque de instrucciones;
            }
            */
            // Ejemplo: Secuencia 35-41
            for (int m = 35; m <= 41; m += 1)
            {
                Console.WriteLine($"m: {m}");
            } 
            // 1. Definir un ciclo for para la siguientesecuencia: -33, -34, -35, -36, -37, -38, -39
            Console.WriteLine($"Ciclo 1: descendente");
            for (int n = -33; n >= -39; n -= 1)
            {
                Console.WriteLine($"n: {n *-1}");
            }
            Console.WriteLine("Ciclo 2: ascendente");
            for (int a = 9; a <= 15; a += 1)
            {
                 if (a != 13)
                {
                Console.WriteLine($"a: {a}");
                }                

            }
            for (int x = 539; x <= 88; x ++)
            // Incluir las instrucciones para omitir la impresion de 13
        } // Termino funcion pricipal
    }// Termino clase principal

} // Termino espacio de nombres

