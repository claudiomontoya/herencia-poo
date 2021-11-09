using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Persona
{
    public class profesor:persona
    {
        private string titulo;

        public profesor(string rut, string nombre)
        {
            this.rut = rut;
            this.nombre = nombre;
        }

        public string Titulo { get => titulo; set => titulo = value; }

        public override void imprimir()
        {
            Console.WriteLine("Rut:{0} nombre:{1} titulo:{2}", this.rut, this.nombre, this.titulo);
        }
    }
}
