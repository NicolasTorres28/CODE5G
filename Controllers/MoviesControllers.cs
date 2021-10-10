using PeliculasCODE5G.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PeliculasCODE5G.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MoviesControllers: ControllerBase
    {
        private readonly ApplicationDbContext context;
        /* Para crear el registro en la base de datos, debemos inyectar el DbContext en el controlador */
        public MoviesControllers(ApplicationDbContext context){
            this.context = context;
        }

        [HttpPost]
        /* La tarea retorna un int correspondiente al Id de la categoria creada */
        public async Task<ActionResult<int>> Post(Movie movie){
            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }        
    }
}