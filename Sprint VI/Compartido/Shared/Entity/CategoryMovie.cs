namespace PeliculasCODE5G.Shared.Entity
{
    public class CategoryMovie
    {
        public int MovieId{get;set;}
        public int CategoryId{get;set;}
        public Category Category{get;set;}
        public Movie Movie {get;set;}
    }
}