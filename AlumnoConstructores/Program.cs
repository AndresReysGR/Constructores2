using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Pendiente";
            alumno1.Matricula = "Sin asignar";
            Console.WriteLine("Datos del Alumno \n \t");
            Console.WriteLine("Alumno 1:\n");
            Console.WriteLine(
                "\tNombre: " + alumno1.Nombre);
            Console.WriteLine(
                "\tMatricula: " + alumno1.Matricula);

            //Usa el constructor sin parametros
            //Despues establece sus atributos

            Alumno alumno2 =
                new Alumno("Sebastian", "188486512");
            Console.WriteLine("\nAlumno 2:\n");
            Console.WriteLine(
                "\tNombre: " + alumno2.Nombre);
            Console.WriteLine(
                "\tMatricula: " + alumno2.Matricula);

            Console.Read();
        }
    }
}
