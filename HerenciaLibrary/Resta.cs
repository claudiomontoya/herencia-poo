using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaLibrary
{
    public class Resta:Operacion
    {
       public void Calcular() {
            resultado = valor1 - valor2;
       }

       public override void Resultado()
        {
            Console.WriteLine("El resultado de " + valor1 + " - " + valor2 + "  es: " + resultado);
        }
    }
}
