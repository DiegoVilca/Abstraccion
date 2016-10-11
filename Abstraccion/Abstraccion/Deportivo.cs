using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Deportivo : Auto,Iafip
    {

        public Deportivo(string patente , int cantRuedas) :base(patente, cantRuedas)
        {

        }

        public override float CalcularCosto()
        {
            return 150f;
        }



         public float RetornarImpuesto()
        {
            return CalcularCosto();
        }
    }
}
