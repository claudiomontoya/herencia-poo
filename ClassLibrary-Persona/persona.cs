using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Persona
{
    public class persona
    {
        protected string rut;
        protected string nombre;

        public persona()
        {
        }
        public virtual void imprimir()
        {
            Console.WriteLine("Rut:{0} nombre:{1}", this.rut, this.nombre);
        }

    }
}
