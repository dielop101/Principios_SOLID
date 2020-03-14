using System;
using System.Collections.Generic;
using System.Text;

namespace S
{
    public class Libro
    {
        string Tipo;
        string Autor;
        int NumeroPaginas;

        Libro(string tipo, string autor, int numeroPaginas) {
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

        //Este metodo rompe el principio de resposabilidad unica, ya que accede a la bbdd
        public void GuardarLibroBBDD(Libro libro)
        {
            //Logica de acceso a la base de datos para guardar el libro 
        }
    }
}
