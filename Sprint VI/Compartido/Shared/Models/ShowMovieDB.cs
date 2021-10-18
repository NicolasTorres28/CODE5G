using System.Collections.Generic;
using PeliculasCODE5G.Shared.Entity;
 
namespace PeliculasCODE5G.Shared.Models
{
    public class ShowMovieDB{
        public ShowMovieDB Movie {get;set;}
        public List<Category> Categories {get;set;}
        public List <Actor> Actors {get;set;}
        public int UserVote {get;set;}
        public double AvgVote {get;set;}
    }
}
