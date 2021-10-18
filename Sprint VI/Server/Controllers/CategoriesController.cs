using System.Threading;
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
        [HttpGet]
        public async Task<ActionResult<List<Category>>> Get(){
            return await context.Categories.ToListAsync();
        }
 
        /* Consultar la información de determinado recurso */
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Get(int id){
            return await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }
 
        /* Actualizar información de determinado registro */
        [HttpPut]
        public async Task<ActionResult> Put(Category category){
            context.Attach(category).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
 
        [HttpDelete("{id}")]
        public async Task <ActionResult> Delete (int id){
            var exists = await context.Categories.AnyAsync(x => x.Id == id);
            /* Si no existe un registro con ese Id */
            if(!exists){return NotFound();}
            context.Remove(new Category {Id = id});
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}