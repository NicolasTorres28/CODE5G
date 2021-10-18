namespace PeliculasCODE5G.Shared.Entity
{
    public class MovieActor
    {
        public int ActorId {get;set;}
        public int MovieId {get;set;}
        public Actor Actor {get;set;}
        public Movie Movie {get;set;}
        /* Campos adicionales en la relacion debil de muchos a muchos*/
        public int OrderCredits{get;set;}
        public string Character{get;set;}
    }
}