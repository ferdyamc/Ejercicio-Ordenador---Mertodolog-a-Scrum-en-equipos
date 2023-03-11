using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_clase
{
    internal class ordenador
    {
        public int tamano_disco;
        public int tamano_disco_max;
        public bool encendido;


        public ordenador(int tamano, int tamano_max, bool estado)
        {
            this.tamano_disco = tamano_disco;
            this.tamano_disco_max = tamano_max;
            this.encendido = estado;

        }
        //metodos

        public void AnadirDatos(int tamano_disco)
        {
            if (encendido == true)
            {
                this.tamano_disco += tamano_disco;
                if (this.tamano_disco >= tamano_disco_max)
                {
                    this.tamano_disco = tamano_disco_max;


                }
            }
            else
            {
                Console.WriteLine("No se puede añadir información. El ordenador esta apagado");
            }
        }
        public void Apagar(bool encendido)
        {
            encendido = false;
        }
        public void EliminarDatos( int tamano_disco)
        {

            if (encendido == true)
            {
                //Console.WriteLine("Encendido");
                //Console.WriteLine("Digite el tamaño del disco");
                
                    this.tamano_disco -= tamano_disco;
                    if (this.tamano_disco <= 0)
                    {
                       this.tamano_disco = 0;
                                        
                    }
                }
                else
                {
                    Console.WriteLine("No se puede eliminar información. El ordenador esta apagado");
                }         
        }
    }
}
