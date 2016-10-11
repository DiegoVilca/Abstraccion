using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vehiculo miVehiculo = new Vehiculo("132456"); (se convirtio en clase abstracta, no es instanciable)
            //Auto miAuto = new Auto("123kkk", 4);

            //Console.WriteLine(miVehiculo.ToString());
            //Console.WriteLine(miVehiculo.MostrarDatos());
            //Console.WriteLine(miAuto.MostrarDatos());

            Familiar miFamiliar = new Familiar("asdfg", 6);
            Deportivo miDeportivo = new Deportivo("123rty", 4);
            Carreta micarreta = new Carreta("yyyyy");
            Avion miAvion = new Avion("jhgjhg");

            List<Vehiculo> miLista = new List<Vehiculo>();
            List<Iafip> listaIafip = new List<Iafip>();

            miLista.Add(miAvion);
            miLista.Add(miFamiliar);
            miLista.Add(micarreta);
            miLista.Add(miDeportivo);

            foreach (Vehiculo item in miLista)
            {
                Console.WriteLine(item.CalcularCosto());
            }

            listaIafip.Add(miAvion);
            listaIafip.Add(miDeportivo);

            foreach (Iafip item in listaIafip)
            {
                Console.WriteLine(item.RetornarImpuesto());
            }


            Console.ReadKey();

        }
    }
}
