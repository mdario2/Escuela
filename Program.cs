using System;
using System.Collections.Generic;
using System.Diagnostics;
using CorEscuela.Entidades;


namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("primaria Liceo colsag",2012,TiposEscuela.Secundaria, pais:"Colombia");

            
            /*Curso[] arregloCursos = {
                new Curso(){Nombre="601"},
                new Curso(){Nombre="701"},
                new Curso(){Nombre="802"}
            };

            escuela.Cursos = arregloCursos ; */

            
            var listaCursos = new List<Curso>();
            listaCursos.Add(new Curso(){Nombre="601", Jornada=TiposJornada.Mañana});
            listaCursos.Add(new Curso(){Nombre="701", Jornada=TiposJornada.Mañana});
            listaCursos.Add(new Curso(){Nombre="801", Jornada=TiposJornada.Mañana});

            escuela.Cursos = listaCursos;

            var otraLista = new List<Curso>();
            otraLista.Add(new Curso(){Nombre="902", Jornada=TiposJornada.Tarde});
            otraLista.Add(new Curso(){Nombre="1002", Jornada=TiposJornada.Tarde});
            otraLista.Add(new Curso(){Nombre="1102", Jornada=TiposJornada.Tarde});

            listaCursos.AddRange(otraLista);
            
            System.Console.WriteLine("======================");
            imprimirCursos(escuela);
            
            Predicate<Curso> miAlgortimo = Predicado;
            listaCursos.RemoveAll(miAlgortimo);
            System.Console.WriteLine("======================");
            imprimirCursos(escuela);
            
            
        }
        private static int PredicadoMalHecho(Curso c)
        {

            return 1002;
        }

        private static bool Predicado(Curso c)
        {

            return c.Nombre == "1002";
        }


        private static void imprimirCursos(Escuela escuela)
        {
            if(escuela != null && escuela.Cursos != null)
            {
             foreach(var curso in escuela.Cursos )
                {
                    Console.WriteLine($"Nombre {curso.Nombre}, Id: {curso.UniqueId}");
                }
            
            }
                


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
