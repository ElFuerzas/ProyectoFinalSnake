using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPrioyectoFinal
{
    internal class Cuerpo
    {
        /// <summary>
        /// {get; set;} son un tipo de dato llamados parametros los cuales son similares a las variables pero permiten pero dan mas control sobre como usarlos y como son llamados desde la clase
        /// </summary>
        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Constructor inicialmente solo indica el valor de X y Y
        /// </summary>
        public Cuerpo()
        {
            X = 0;
            Y = 0;
        }
    }
}
