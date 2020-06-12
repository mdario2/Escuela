using System;
using CorEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("primaria Liceo colsag",2012,TiposEscuela.Secundaria, pais:"Colombia");

            var arregloCursos = new Curso[3];
            arregloCursos[0] =  new Curso()
                                {
                                Nombre="601"
                                 };

            var curso2 = new Curso(){
                Nombre="701"
            };
            arregloCursos[1] = curso2;

            arregloCursos[2] = new Curso{
                                Nombre="802"
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
