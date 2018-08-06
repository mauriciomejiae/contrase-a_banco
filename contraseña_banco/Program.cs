using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contraseña_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nombre del Autor: Mauricio Mejia Estevez
            //Fecha: 10 Noviembre 2016 
            //Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi
            //trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar
            //1. Un banco ha solicitado se diseñe un programa que permita encriptar la información de las contraseñas
            //(4 números) digitada por teclado (como un único numero) hasta el servidor principal, utilizando
            //el siguiente criterio, el primer número se envía de último, el segundo, de penúltimo, el tercer numero
            //pasa a la segunda posición, el último pasa a ser primero: ejemplo: Sea 6532, se debe enviar como 2356
            String a = "";
            Console.WriteLine("Ingres un número de 4 digitos");
            String pal = Console.ReadLine();
            int numero = pal.Length;
            if (numero > 4)
            {
                Console.WriteLine(" El número ingresado por usted no es de 4 dijitos, la contraseña debe ser de 4 digitos");
                Console.ReadLine();
            }
            if (numero < 4)
            {
                Console.WriteLine(" El número ingresado por usted no es de 4 dijitos, la contraseña debe ser de 4 digitos");
                Console.ReadLine();
            }
            if (numero == 4)
            {
                for (int i = numero - 1; i >= 0; i--)
                {
                    a = a + pal.Substring(i, 1);
                }
            }
            Console.WriteLine(" Su contraseña Es : {0} ", a);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}