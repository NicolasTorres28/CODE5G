using PeliculasCODE5G.Shared.Entity;
using System.Collections.Generic;

namespace PeliculasCODE5G.Client.Services
{
    public interface IServiceMovie
    {
        List <Movie> GetMovies();
    }
}