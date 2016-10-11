using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Carreta :Vehiculo
    {

        public Carreta(string patente) :base(patente)
        {
            
        }

        public override float CalcularCosto()
        {
            //throw new NotImplementedException();
            return 5f;
        }
    }
}
