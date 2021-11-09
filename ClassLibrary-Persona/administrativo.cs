using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Persona
{
    public class administrativo:persona
    {
        private string cargo;

        public administrativo(string rut, string nombre)
        {
            this.rut = rut;
            this.nombre = nombre;
        }

        public string Cargo { get => cargo; set => cargo = value; }

        public override void imprimir()
        {
            Console.WriteLine("Rut:{0} nombre:{1} cargo:{2}", this.rut, this.nombre, this.cargo);
        }
    }
}
