using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Iniciando la consola
            // Imprime un mensaje de saludo en la consola
            Console.WriteLine("Hola sebastian progrmnado desde C#!");

            // Declaración de una cadena de texto
            string myString = "Esto es una cadena";
            // Asignación de un nuevo valor a la cadena de texto
            myString = "Ahora esta es otra cadena";
            // Imprime el valor actual de la cadena de texto en la consola
            Console.WriteLine(myString);

            // Declaración de un entero y asignación de un valor inicial
            int myInt = 7;
            // Suma 9 al valor actual del entero
            myInt = myInt + 9;
            // Imprime el valor actual del entero en la consola
            Console.WriteLine(myInt);
            // Imprime el valor del entero menos 1 en la consola
            Console.WriteLine(myInt - 1);
            //  vuelve y me emprime  valor a  entero en la consola
            Console.WriteLine(myInt);

            float myFloat = 6.5f;

            Console.WriteLine(myFloat);

            // Termina la consola
        }
    }
}


