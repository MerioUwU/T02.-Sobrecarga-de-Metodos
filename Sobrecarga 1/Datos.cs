using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_1
{
    public class Datos//clase pública para capturar datos
    {
        public void ObtenerDatos()//Metodo de captura de datos
        {
            Console.WriteLine("Hola\n\nIngrese el valor del Dato 1: ");//petición del dato 1
            double dato1 = double.Parse(Console.ReadLine());//Inicialización y captura del dato 1
            Console.WriteLine("\nIngrese el valor del dato 2: ");//peticion del dato 2
            double dato2 = double.Parse(Console.ReadLine());// inicialización y captura del dato 2
            Operación op = new Operación();//Instancia de operaciones para poder usar la sobrecarga
            double res1 = op.Multiplicar(), res2 = op.Multiplicar(dato1), res3 = op.Multiplicar(dato1,dato2);//Operación, cada variable equivale a un resultado
            Console.Clear();//Limpieza de la consola
            Console.WriteLine("Resultado 1 (Sin parámetros): {0}\n Resultado 2(Con un sólo parámetro): {1}\n Resultado 3(Con dos parámetros): {2}",res1,res2,res3);//despliegue de resultados
        }
    }
}
