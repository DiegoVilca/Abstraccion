using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public abstract class Vehiculo
    {
        public string patente;


        //constructor


        public Vehiculo(string patente)
        {
            this.patente = patente;
        }


        //metodos


        //METODO VIRTUAL
        //Puede o no implementarse

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("vehiculo");
            sb.AppendLine(this.patente.ToString());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.patente;
        }


        //METODOS ABSTRACTOS    
        //1- los metodos abstractos solo estan en clases abstractas.
        //2- No tiene implementacion en la clase que se define.
        //3- Son obligatorias de implementar en su herencia DIRECTA.
        //4- Las clases abstractas no se pueden instancia (por constructor).


        public abstract float CalcularCosto();
        

        //Propiedad abstracta

        public abstract void Marca();

        //Metodo virtual

        public virtual string Fabricante()
        {
            return "Japon";
        }


    }
}
