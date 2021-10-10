using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace PeliculasCODE5G.Shared.Entity
{
    public class Movie
    {
        public int Id{get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Name {get;set;}
        public bool EnCartelera {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Sinopsis{get;set;}
        public string Poster{get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public DateTime Premier{get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Trailer{get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public List<CategoryMovie> CategoriesMovie {get;set;} = new List<CategoryMovie>();
        public List<MovieActor> MoviesActor{get;set;}
        public string ShortName{
            get{
                if (string.IsNullOrWhiteSpace(Name)){
                    return null;
                }
                if (Name.Length > 60){
                    return Name.Substring(0,60) + "...";
                }else{
                    return Name;
                }
            }
        }        
    }
}