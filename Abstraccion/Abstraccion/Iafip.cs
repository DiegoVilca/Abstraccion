using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public interface Iafip
    {
        //no se instancia y no tiene atributos.
        /// <summary>
        /// reglas
        /// </summary>
        /// <returns></returns>
        float RetornarImpuesto();

        //propiedad

        float RetornarCuit();


        

    }
}
