using System;
using CorEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("primaria Liceo colsag",2012,TiposEscuela.Secundaria, pais:"Colombia");

            
            Curso[] arregloCursos = {
                new Curso(){Nombre="601"},
                new Curso(){Nombre="701"},
                new Curso(){Nombre="802"}
            };
             
                      
            Console.WriteLine(escuela);
            System.Console.WriteLine("======================");
            imprimirCursos(arregloCursos);
            

        }

        private static void imprimirCursos(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                System.Console.WriteLine($"Nombre: {arregloCursos[i].Nombre} , Id{arregloCursos[i].UniqueId}");
            }
        }
    }
}
