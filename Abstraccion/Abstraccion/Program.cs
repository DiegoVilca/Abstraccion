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
            Privado miAvionPrivado = new Privado("654987");
            Comercial miAvionComercial = new Comercial("lalalaa");

            List<Vehiculo> miLista = new List<Vehiculo>();
            List<Iafip> listaIafip = new List<Iafip>();

            miLista.Add(miAvion);
            miLista.Add(miFamiliar);
            miLista.Add(micarreta);
            miLista.Add(miDeportivo);

            Console.WriteLine("Vehiculo");

            foreach (Vehiculo item in miLista)
            {
                Console.WriteLine(item.CalcularCosto());
            }



            listaIafip.Add(miAvion);
            listaIafip.Add(miDeportivo);
            listaIafip.Add(miAvionPrivado);
            listaIafip.Add(miAvionComercial);
            Console.WriteLine("\nIafip");

            foreach (Iafip item in listaIafip)
            {
                Console.WriteLine(item.RetornarImpuesto());
            }

            //miAvionPrivado hereda los metodos y propiedades de interface que posee avion. 
             Console.WriteLine(miAvionPrivado.RetornarCuit());

            

            //1- Implementar MostrarIafip()
            //2- Verificar si la implementacion se hereda o no. Crear clases hijas de avion, Privada/Comercial. (La implementacion de la interfaz se hereda, privado y comercial seria ahora Iafip)
            //3- Crear Propiedades
            //-abstractas
            //-virtuales
            //-en la interfaz

            Console.WriteLine("\nGestion");
            foreach (Iafip item in listaIafip)
            {
                Console.WriteLine(Gestion.MostrarIMP(item));
            }

            Console.ReadKey();

        }
    }
}
