using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoConstructores
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        //public DateTime Fechadenacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Alumno()
        {
            Nombre = "Pendiente";
            Matricula = "Sin asignar";
            /*fechadenacimiento = ;*/
            Direccion = "Sin asignar";
            Telefono = "Sin asignar";
        }

        public Alumno(string nombre, string matricula /*DateTime fechadenacimiento, string direccion, string telefono*/)
        {
            Nombre = nombre;
            Matricula = matricula;
            /*fechadenacimiento
            Direccion = "Sin asignar";
            Telefono = "Sin asignar";*/


        }







    }
}
