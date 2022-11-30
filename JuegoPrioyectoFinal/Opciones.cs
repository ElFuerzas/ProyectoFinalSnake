using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPrioyectoFinal
{
    internal class Opciones
    {
        /// <summary>
        /// Esta son variables Estaticas las cuales son las cuales no es necesario crear una instancia de ellos, sino que una vez que son llamados de la clase principal son accesibles alrededor del programa,
        /// Establece las variables estaticas de anchura y altura
        /// </summary>
       

        public static int Anchura { get; set; }

        public static int Altura { get; set; }

        /// <summary>
        /// Establece las variable estatica que se encarga de las direcciones
        /// </summary>
        public static string direcciones;

        /// <summary>
        /// Constructor que establece los valores que definen el tamaño en altura y anchura de la serpiente y la comida, tambien establece en que dirección comenzara la serpiente a caminar al iniciar el juego
        /// </summary>
        public Opciones()
        {
            Anchura = 28;

            Altura = 23;

            direcciones = "left";

        }


    }
}
