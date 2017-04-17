using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        private int numero;
        private Alumno[] misAlumnos;

        public Aula()
        {
            this.numero = 0;
            this.misAlumnos=new Alumno[10];
        }
        public void agregarAlumno(Alumno miAlumno)
        {
            int indice = 0;
            if (this.obtenerLugarLibre() != -1)
            {
                indice = this.obtenerLugarLibre();
                this.misAlumnos[indice] = miAlumno;
            }
            
        }
        /// <summary>
        /// Obtiene el indice del primer lugar en NULL.
        /// Retorna -1 si no hay lugar
        /// </summary>
        /// <returns>El indice o -1</returns>
        public int obtenerLugarLibre()
        {
            int retorno = -1;
            int contador = 0;
            foreach (Alumno itemAlumno in this.misAlumnos)
            {

                if (itemAlumno == null)
                {
                    retorno = contador;
                    return retorno;
                }
                else
                {
                    Console.WriteLine("No hay mas lugar");
                    Console.ReadLine();
                    return retorno;
                }
                contador++;
            }
            return retorno;
        }
        public void borrarAlumno(Alumno unAlumno)
        {
            int indiceborrar = this.retornarIndicedeObjeto(unAlumno);
            if (indiceborrar != -1)
            {
                this.misAlumnos[indiceborrar] = null;
            }

        }
        /// <summary>
        /// Retorna el indice del obketo pasado por parametros
        /// Retorno -1 si no lo encuentra
        /// </summary>
        /// <param name="unAlumno"></param>
        /// <returns>indice o -1</returns>
        private int retornarIndicedeObjeto(Alumno unAlumno)
        {
            int retorno = -1;            

            for (int contador = 0;contador< this.misAlumnos.Length;contador++)
            {
                if (this.misAlumnos.GetValue(contador)!=null && unAlumno==this.misAlumnos[contador])
                {
                    return contador;
                }
            }
            return retorno;
        }
    }
}
