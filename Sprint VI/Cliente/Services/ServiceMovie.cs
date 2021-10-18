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
        private JsonSerializerOptions OpcionesPorDefectoJSON =>new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public async Task<HttpResponseWrapper<object>> Post<T> (string url, T send){
           var sendJSON = JsonSerializer.Serialize(send);
           var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
           var responseHttp = await httpClient.PostAsync(url, sendContent);
           return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode,responseHttp);
        }
        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }
 
        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T send)
        {
            var sendJSON = JsonSerializer.Serialize(send);
            var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, sendContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<TResponse>(responseHttp, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }

        }
        /* MÉTODO CONSULTAR */
        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);
            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }
        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T send)
        {
            var enviarJSON = JsonSerializer.Serialize(send);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PutAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }
 
       
 
        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var responseHTTP = await httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null, !responseHTTP.IsSuccessStatusCode, responseHTTP);
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