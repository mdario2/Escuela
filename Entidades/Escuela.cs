using System.Collections.Generic;

namespace CorEscuela.Entidades
{
    class Escuela{
        string nombre;

        public string Nombre { get; set; }

        public int AñoDeCreacion { get; set; }

        public string pais { get; set; }

        public string direccion;

        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        

        //Costructor
        public Escuela(string nombre, int año){
            this.Nombre = nombre;
            AñoDeCreacion = año;

        }
         
        public Escuela(string nombre, int año, TiposEscuela tipo, string pais=""){
            Nombre = nombre;
            AñoDeCreacion = año;
            TipoEscuela = tipo;
            this.pais = pais;
            
            
        }




        public override string ToString(){
            
            return $"Nombre: {Nombre}, {System.Environment.NewLine}  Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {pais}";
        }
    }
    
}