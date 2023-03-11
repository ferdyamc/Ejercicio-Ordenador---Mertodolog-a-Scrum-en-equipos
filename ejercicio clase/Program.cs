using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_clase
{
    internal class Program

    {
        static void Main(string[] args)
        {
            ordenador abc = new ordenador(50, 100, true);// Se instancia un ordenador con 50 de tamaño, el maximo permitido es 100 y se ecuentra encendido

            Console.WriteLine(abc.encendido);//Validamos si el valor de encendido

            abc.AnadirDatos(300);//añadimos 300 al tamaño del disco
            Console.WriteLine(abc.tamano_disco);//mostramos el tamaño del disco

            abc.EliminarDatos(200);//Eliminamos 200 al tamaño del disco
            Console.WriteLine(abc.tamano_disco);//mostramos el tamaño del disco

            Console.ReadKey();

        }
    }
}