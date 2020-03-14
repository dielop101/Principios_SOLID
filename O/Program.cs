using O.Correcto;
using System;
using System.Collections.Generic;

namespace O
{
    class Program
    {
        public static void main(String[] args)
        {
            List<Libro> listLibros = new List<Libro>(){
                new Libro("IT","Autor anonimo","Manual principios SOLID", 543),
                new Libro("Fantastica","JR Martin","Juego de Tronos" ,893)
            };

            imprimirTipoDeLibro(listLibros);

            //Si añadimos un nuevo tipo de libro, por ejemplo
            listLibros.Add(new Libro("Comedia", "Autor2", "Algo pasa con Mary", 378));
            //tendriamos que modificar imprimirTipoDeLibro, porque no estamos contemplando la comedia 
            //Con lo que no cumpliriamos el Principio abierto/cerrado


            //De esta forma seria la forma correcta de hacerlo usando principios SOLID
            List<Libro2> listLibro2 = new List<Libro2>();

            listLibro2.Add(new IT("IT", "Autor anonimo", "Manual principios SOLID", 543));
            listLibro2.Add(new Fantastica("Fantastica", "JR Martin", "Juego de Tronos", 893));
            listLibro2.Add(new Comedia("Comedia", "Autor2", "Algo pasa con Mary", 378));
            listLibro2.Add(new Drama("Drama", "Autor3", "Lo que el viento se llevo", 1378));

            imprimirTipoDeLibro2(listLibro2);
        }

        public static void imprimirTipoDeLibro(List<Libro> listLibros)
        {
            foreach (var libro in listLibros)
            {
                if (libro.Tipo.Contains("IT")) Console.WriteLine("Es IT");
                if (libro.Tipo.Contains("Fantastica")) Console.WriteLine("Es Fantastica");
                if (libro.Tipo.Contains("Comedia")) Console.WriteLine("Es Comedia");
            }
        }

        //De esta forma este metodo nunca cambiara por mas tipos de libro que introduzcamos nuevos
        public static void imprimirTipoDeLibro2(List<Libro2> listLibros)
        {
            foreach (var libro in listLibros)
            {
                libro.imprimirTipoDeLibro();
            }
        }
    }
}
