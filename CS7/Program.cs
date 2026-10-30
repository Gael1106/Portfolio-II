using System;
//Espacio de nombres
namespace CS7
{
    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            // Bloque de funcion
            // Sesion 15: Funcion 151026
            /*
            Funcion: bloque de instrucciones que realiza una tarea especifica, que se ejecuta, unicamente cuando es invocado.
            Sintaxis: definicion de funcion
            tipo_dato_devuelto identificador_funcion(parametros(variable))
            {
                bloque de instrucciones
            }
            Nota 1: Los parametros se definen incluyendo tipo de dato.
            Nota 2: Los parametros van separados por comas.
            Sintaxis: invocacion funcion
            identificador_funcion(argumentos);
            Argumentos: El valor del parametro que se envia a la funcion.
            */
            // Ejemplo 1: funcion vacia sin parametro
            void Saludar() //void. No devuelve ningun valor
            {
                string salon = "Exactas 331";
                Console.WriteLine($"Hola, {salon}!");
            }
            // Invocacion
            Saludar();
            // Ejercitacion
            // 1. definir a invocar una funcion para imprimir: nombre, clave, salon
            void alumno()
            {
                string nombre = "Gael Mendez";
                string clave = "331-23";
                string salon = "Exactas 331";
                Console.WriteLine($"Nombre: {nombre}\nClave: {clave}\nSalon: {salon}");
            }
            // Invocacion
            //2. Definir e invocar una funcion sin parametros para desplegar el horario
            // Sesion 16: Funcion con parametros 
            // return: palabra reservada para terminar una funcion y devolver un valor.
            // Ejemplo 1: Doble
            // Definicion de funcion
            int CalcularDoble(int numero)
            {
                int resultado = 2 * numero;
                return resultado;
            }
            // Invocacion
            int devolucion;
            devolucion = CalcularDoble(9);
            Console.WriteLine($"Devolucion: {devolucion}");
            // Ejercitacion
            // 1. Definir e invocar una funcion que devueelva la evulacion de la siguiente expresion: f(x) = 4x-7/5
            int EvaluarExpresion(int x)
            {
                int resultado = (4 * x - 7) / 5;
                return resultado;
            }
            // Invocacion
            int devolucion2;
            devolucion2 = EvaluarExpresion(9);
            Console.WriteLine($"Devolucion: {devolucion2}");

        } // Termino funcion pricipal
    } // Termino clase principal       
} // Termino espacio de nombres