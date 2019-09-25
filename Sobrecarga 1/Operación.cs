using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_1
{
    public class Operación
    {
        public double Multiplicar()//Metodo de operacion donde regresa valor nulo puesto que no recibe parámetros
        {
            int result=0;//incializas resultado pero no lo trabajas con nada
            return result;//devuelves resultado
        }
        public double Multiplicar(double a)//metodo de operacion donde regresa el único parámetro que recibe
        {
            double result = a;//inicializas resultado igual al parámetro único en el método
            return result;//devolverá  el valor del parámetro capturado
        }
        public double Multiplicar(double a, double b)//Metodo que recibe dos parámtetros y devuelve un valor
        {
            double result = a * b;//inicializa una variable igual a la multiplicación de los dos parámetros recibidos
            return result;//devuelve la variable recién inicializada
        }
    }
}
