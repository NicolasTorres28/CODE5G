using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using PeliculasCODE5G.Shared.Entity;
using System;
namespace PeliculasCODE5G.Server
{
    public class ApplicationDbContext:DbContext
    {
        /* Cada DbSet es una tabla que crearemos a partir de una entidad */
        public DbSet<Movie> Movies {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<Actor> Actors {get;set;}
        public DbSet<CategoryMovie> CategoriesMovie {get;set;}
        public DbSet<MovieActor> MoviesActor {get;set;}
 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){
 
        }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            /* Establecemos los tipos de relaciones entre las tablas que se van a crear 1 - 1, 1 - *, N - M
        Creamos una llave primaria compuesta para la tabla CategoryMovie*/
            modelBuilder.Entity<CategoryMovie>().HasKey(x=> new {x.CategoryId, x.MovieId});
            modelBuilder.Entity<MovieActor>().HasKey(x=> new {x.MovieId, x.ActorId});
            base.OnModelCreating(modelBuilder);
        }
    }
}
