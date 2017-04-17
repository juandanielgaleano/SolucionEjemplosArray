using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        
            private string apellido;
            private string nombre;
            private int legajo;

            public Alumno(string apellido, string nombre, int legajo)
            {
                this.apellido = apellido;
                this.nombre = nombre;
                this.legajo = legajo;
            }

            public static bool operator ==(Alumno alumno1,Alumno alumno2)
            {
                if (alumno1.legajo == alumno2.legajo && alumno1.nombre == alumno2.nombre)
                {
                    return true;
                }
                return false;
            }
            public static bool operator !=(Alumno alumno1,Alumno alumno2)
            {
                return !(alumno1 == alumno2);
            }         



        
    }
}
