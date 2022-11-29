using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPrioyectoFinal
{
    internal class Opciones
    {
        //Esta son variables Estaticas las cuales son las cuales no es necesario crear una instancia de ellos, sino que una vez que son llamados de la clase principal son accesibles alrededor del programa
        public static int Anchura { get; set; }

        public static int Altura { get; set; }

        public static string direcciones;

        public Opciones()
        {
            Anchura = 28;

            Altura = 23;

            direcciones = "left";






        }


    }
}
