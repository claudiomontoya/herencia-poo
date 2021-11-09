using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Persona
{
    public class alumno:persona
    {
        private  string carrera;

        public alumno()
        {

        }

        public alumno( string rut, string nombre)
        {
            this.rut = rut;
            this.nombre = nombre;
        }


        public string Carrera { get => carrera; set => carrera = value; }

        public override void imprimir() {
            Console.WriteLine("Rut:{0} nombre:{1} carrera:{2}", this.rut, this.nombre, this.carrera);
        }
    }
}
