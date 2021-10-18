using System.Collections.Generic;
using PeliculasCODE5G.Shared.Entity;

namespace PeliculasCODE5G.Shared.Models
{
    public class PutMovie
    {
        public Movie Movie {get;set;}
        public List <Actor> Actors {get;set;}
        public List <Category> CategoriasSeleccionadas {get;set;}
        public List <Category> CategoriasNoSeleccionadas {get;set;}
 
    }
}
