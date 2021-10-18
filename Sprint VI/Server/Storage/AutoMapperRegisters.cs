using AutoMapper;
using PeliculasCODE5G.Shared.Entity;
 
namespace PeliculasCODE5G.Server.Storage
{
    public class AutoMappeRegisters:Profile
    {
        public AutoMappeRegisters(){
            CreateMap<Actor, Actor>().ForMember(x=>x.Photo, option =>option.Ignore());
            CreateMap<Movie, Movie>().ForMember(x=>x.Poster, option =>option.Ignore());
 
        }
    }
}
