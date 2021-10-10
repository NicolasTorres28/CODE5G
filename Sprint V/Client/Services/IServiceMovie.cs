using System.Security.AccessControl;
using PeliculasCODE5G.Shared.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeliculasCODE5G.Client.Services
{
    public interface IServiceMovie
    {
        List <Movie> GetMovies();
        Task<HttpResponseWrapper<object>> Post<T>(string url, T send);
    }
}