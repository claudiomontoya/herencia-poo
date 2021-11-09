using ClassLibrary_Persona;
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
            //Suma sum = new Suma();
            //sum.Valor1 = 10;
            //sum.Valor2 = 5;
            //sum.Calcular();
            //sum.Resultado();

            //Resta res = new Resta();
            //res.Valor1 = 10;
            //res.Valor2 = 5;
            //res.Calcular();
            //res.Resultado();

            alumno obj1 = new alumno("1-1","juan");
            obj1.Carrera = "Informatica";

            profesor obj2 = new profesor("1-2", "Pedro");
            obj2.Titulo = "Ing Informatico";
            
            administrativo obj3 = new administrativo("1-3", "Ana");
            obj3.Cargo = "Finanzas";

            List<persona> listaPersonas = new List<persona>();

            listaPersonas.Add(obj1);
            listaPersonas.Add(obj2);
            listaPersonas.Add(obj3);

            foreach (var item in listaPersonas)
            {
                
                item.imprimir();

            }

            



            Console.ReadKey();
        }
    }
}
