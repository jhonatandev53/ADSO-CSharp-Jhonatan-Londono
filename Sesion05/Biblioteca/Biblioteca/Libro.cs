using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Libro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int Paginas { get; private set; }
        public bool Disponible { get; private set; } = true;


        // Constructor
        public Libro(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        // Metodos
        public bool Prestar()
        {
            if (!Disponible) return false;
            Disponible = false;
            return true;
            
        }

        public void Devolver()
        {
            Disponible = true;
        }
    }
}
