using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PeliculasCODE5G.Shared.Entity;
using System.Collections.Generic;

namespace PeliculasCODE5G.Client.Services
{
    public class ServiceMovie: IServiceMovie
    {
       private readonly HttpClient httpClient;

       public ServiceMovie(HttpClient httpClient){
           this.httpClient = httpClient;
        }

       public async Task<HttpResponseWrapper<object>> Post<T> (string url, T send){
           var sendJSON = JsonSerializer.Serialize(send);
           var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
           var responseHttp = await httpClient.PostAsync(url, sendContent);
           return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode,responseHttp);
        }

       public List<Movie> GetMovies(){
            return new List<Movie>(){
                new Movie(){Name="LUCA", Poster="/Images/beta11.jpg",Sinopsis="Descripcion Pelicula", Premier= new DateTime(2021,08,14)},
                new Movie(){Name="La Patrulla Canina",Poster="/Images/beta1.jpg",Sinopsis="Descripcion Pelicula", Premier= new DateTime(2021,03,09)},
                new Movie(){Name="Maligno", Poster="/Images/beta2.jpg",Sinopsis="Descripcion Pelicula", Premier= new DateTime(2021,06,11)},
                new Movie(){Name="Sweet Girl",Poster="/Images/beta3.jpg",Sinopsis="Descripcion Pelicula", Premier= new DateTime(2021,05,22)},
                new Movie(){Name="Space Jam",Poster="/Images/beta12.jpg",Sinopsis="Descripcion Pelicula", Premier= new DateTime(2021,10,13)},
                new Movie(){Name="Jefe En Pañales 2",Poster="/Images/beta5.jpg",Sinopsis="Descripcion Pelicula", Premier= new DateTime(2021,08,24)},
                new Movie(){Name="SAS:El Ascenso Del Cisne Negro",Poster="/Images/beta6.jpg",Sinopsis="Descripcion Pelicula", Premier= new DateTime(2020,09,14)},
                new Movie(){Name="Jumgle Cruise",Poster="/Images/beta7.jpg",Sinopsis="Descripcion Pelicula", Premier= new DateTime(2021,01,20)},
                new Movie(){Name="El Escuadron Suicida",Poster="/Images/beta8.jpg",Sinopsis="Descripcion Pelicula", Premier= new DateTime(2021,04,10)},
                new Movie(){Name="JOLT",Poster="/Images/beta9.jpg",Sinopsis="Descripcion Pelicula", Premier= new DateTime(2021,07,15)},
                new Movie(){Name="Escape Room 2",Poster="/Images/beta10.jpg",Sinopsis="Descripcion Pelicula", Premier= new DateTime(2021,12,05)}
            };
        }
    }
}