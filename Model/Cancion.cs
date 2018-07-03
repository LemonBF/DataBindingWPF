using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding.Model
{
    public class Cancion
    {
        public string Artista { get; set; }
        public string Titulo { get; set; }

        public Cancion(string artista, string titulo)
        {
            Artista = artista;
            Titulo = titulo;
        }
    }
}
