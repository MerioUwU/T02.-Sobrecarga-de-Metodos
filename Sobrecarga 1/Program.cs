using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos data = new Datos();//instancia de objeto
            data.ObtenerDatos();//llamado del metodo por medio de la instancia
            Console.ReadKey();//Presionar cualquier tecla para salir
        }
    }
}
