using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public abstract class Auto :Vehiculo
    {
        public int cantPuertas;

        public Auto()
        {

        }

        public Auto(string patente, int cantPuertas) :base(patente)
        {
            base.patente = patente;
            this.cantPuertas = cantPuertas;
        }

        public int CantidadPuertas 
        {
            get { return this.cantPuertas; } 
        }


        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("auto");
            sb.AppendLine(this.CantidadPuertas.ToString());
            
            return sb.ToString();
        }




        
        
    }
}
