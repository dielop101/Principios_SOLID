using System;
using System.Collections.Generic;
using System.Text;

namespace S.ejemploBueno
{

    public class Libro
    {
        string Tipo;
        string Autor;
        int NumeroPaginas;

        Libro(string tipo, string autor, int numeroPaginas)
        {
            Tipo = tipo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }

        public string GetTipoLibro()
        {
            return Tipo;
        }

        public string GetAutor()
        {
            return Autor;
        }

        public int GetNumeroPaginas()
        {
            return NumeroPaginas;
        }
    }


    //Encapsulamos la logica de guardar libro en otra clase (o servicio)
    public class LibroService
    {

        public void GuardarLibroBBDD(Libro libro)
        {
            //Logica de acceso a la base de datos para guardar el libro 
        }

        public void EliminarLibroBBDD(Libro libro)
        {
            //Logica de acceso a la base de datos para eliminar el libro 
        }
    }
}
