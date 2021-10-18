using System.Collections.Generic;
using PeliculasCODE5G.Shared.Entity;

namespace PeliculasCODE5G.Shared.Models
{
    public class FilterMovie
    {
        public List<Movie> PeliculasEnCartelera {get;set;} 
        public List<Movie> ProximosEstrenos {get;set;} 
    }
}