using System;
using SprintIII_G34.Shared.Entity;
using System.Collections.Generic;
namespace SprintIII_G34.Client.Services
{
    public class ServicePelicula: IServicePelicula
        {
            public List<Movie>GetMovies()  {
                return new List<Movie>() {
                    new Movie(){Image="/Images/poster1.jpg", Nombre="Snake Eyes", Genero="Accion", Puntuacion_usuario="", Sinopsis="", Fecha_estreno=new DateTime(2020, 08, 24), Duracion="02h:23min", Idioma_original="Idioma original: Ingles", Produccion="", Direccion=""},
                    new Movie(){Image="/Images/poster2.jpg", Nombre="Je Suis Karl", Genero="Drama", Puntuacion_usuario="", Sinopsis="", Fecha_estreno=new DateTime(2011, 09, 27), Duracion="01h:59min", Idioma_original="Idioma original: Ingles", Produccion="", Direccion=""},
                    new Movie(){Image="/Images/poster3.jpg", Nombre="La Fielle au Bracelet", Genero="Accion", Puntuacion_usuario="", Sinopsis="", Fecha_estreno=new DateTime(2021, 10, 13), Duracion="02h:20min", Idioma_original="Idioma original: Ingles", Produccion="", Direccion=""},
                    new Movie(){Image="/Images/poster4.jpg", Nombre="Murder", Genero="Terror", Puntuacion_usuario="", Sinopsis="", Fecha_estreno=new DateTime(2012, 05, 24), Duracion="02h:10min", Idioma_original="Idioma original: Ingles", Produccion="", Direccion=""},
                    new Movie(){Image="/Images/poster5.jpg", Nombre="Sweat", Genero="Accion", Puntuacion_usuario="", Sinopsis="", Fecha_estreno=new DateTime(2009, 01, 23), Duracion="01h:60min", Idioma_original="Idioma original: Ingles", Produccion="", Direccion=""},
                    new Movie(){Image="/Images/poster6.jpg", Nombre="The medium", Genero="Terror", Puntuacion_usuario="", Sinopsis="", Fecha_estreno=new DateTime(2000, 09, 15), Duracion="01h:23min", Idioma_original="Idioma original: Ingles", Produccion="", Direccion=""},
                    new Movie(){Image="/Images/poster7.jpg", Nombre="Under the volcano", Genero="Drama", Puntuacion_usuario="", Sinopsis="", Fecha_estreno=new DateTime(2015, 07, 20), Duracion="02h:50min", Idioma_original="Idioma original: Ingles", Produccion="", Direccion=""},
                    new Movie(){Image="/Images/poster8.jpg", Nombre="Free Guy", Genero="Aventura", Puntuacion_usuario="", Sinopsis="", Fecha_estreno=new DateTime(2021, 09, 24), Duracion="01h:23min", Idioma_original="Idioma original: Ingles", Produccion="", Direccion=""},
                    new Movie(){Image="/Images/poster9.jpg", Nombre="A soldier´s story", Genero="Aventura", Puntuacion_usuario="", Sinopsis="", Fecha_estreno=new DateTime(2021, 08, 24), Duracion="01h:50min", Idioma_original="Idioma original: Ingles", Produccion="", Direccion=""},
                    new Movie(){Image="/Images/poster10.jpg", Nombre="Edge World", Genero="Accion", Puntuacion_usuario="", Sinopsis="", Fecha_estreno=new DateTime(2018, 09, 24), Duracion="01h:40min", Idioma_original="Idioma original: Ingles", Produccion="", Direccion=""}
                   
                };
            }
        }
    
}
      
        
        
       
