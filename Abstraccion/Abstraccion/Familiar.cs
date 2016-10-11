using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Familiar :Auto
    {
        public Familiar(string patente, int cantPuertas) :base(patente, cantPuertas)
        {

        }
        
        public override float CalcularCosto()
        {
            //throw new NotImplementedException();
            return 100f;
        }

        //propiedad

        public override string Modelo()
        {
            return "94";
        }
    }
}
