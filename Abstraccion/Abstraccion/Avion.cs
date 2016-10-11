using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Avion :Vehiculo,Iafip
    {
        public Avion(string patente) :base(patente)
        {
           
        }

        public override float CalcularCosto()
        {
            return 1500f;
        }



        public float RetornarImpuesto()
        {
            return CalcularCosto();
        }

        //propiedad 

        public override void Marca()
        {
            Console.WriteLine("Boing");
        }

        public override string Fabricante()
        {
            return "Alemania";
        }

        //De interface
        public float RetornarCuit()
        {
            return 5433555987;
        }
    }
}
