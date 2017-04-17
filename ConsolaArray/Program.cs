using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsolaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aula miAula = new Aula();
            int indice = miAula.obtenerLugarLibre();


            for (int contador = 0; contador < 10; contador++)
            {
                miAula.agregarAlumno(new Alumno("juan", "galeano", contador));
            }
            
            miAula.borrarAlumno(new Alumno("","",4));

            miAula.agregarAlumno(new Alumno("Hola","Test",4));


        }
    }
}
