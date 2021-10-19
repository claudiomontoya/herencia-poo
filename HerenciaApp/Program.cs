using HerenciaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma sum = new Suma();
            sum.Valor1 = 10;
            sum.Valor2 = 5;
            sum.Calcular();
            sum.Resultado();

            Resta res = new Resta();
            res.Valor1 = 10;
            res.Valor2 = 5;
            res.Calcular();
            res.Resultado();


            Console.ReadKey();
        }
    }
}
