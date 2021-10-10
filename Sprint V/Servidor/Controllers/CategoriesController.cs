using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeliculasCODE5G.Shared.Entity;

namespace PeliculasCODE5G.Server.Controllers
{
    [ApiController]
    /* El [Controller] tomara el nombre del controlador, en este caso CategoryController */
    [Route("api/[controller]")]
    public class CategoriesController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        /* Para crear el registro en la base de datos, debemos inyectar el DbContext en el controlador */
        public CategoriesController(ApplicationDbContext context){
            this.context = context;
        }
        [HttpPost]
        /* La tarea retorna un int correspondiente al Id de la categoria creada */
        public async Task<ActionResult<int>> Post(Category category){
            context.Add(category);
            await context.SaveChangesAsync();
            return category.Id;
        }
    }
}