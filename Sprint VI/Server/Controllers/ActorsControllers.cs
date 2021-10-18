using System.Net.Mime;
using System.Threading;
using PeliculasCODE5G.Shared.Entity;
using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeliculasCODE5G.Server.Storage;
using PeliculasCODE5G.Shared.Configuration;
/*using PeliculasCODE5G.Server.Storage;*/

namespace PeliculasCODE5G.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class ActorsControllers: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFilesStorageClass FilesStorage;
        /* Para crear el registro en la base de datos, debemos inyectar el DbContext en el controlador */
        /*private readonly IFilesStorageClass FilesStorage;*/
        /*private readonly string carpeta ="actors";*/
        public ActorsControllers(ApplicationDbContext context, IFilesStorageClass filesStorage){
            this.context = context;
            this.FilesStorage = filesStorage;
        }
        [HttpPost]
        /* La tarea retorna un int correspondiente al Id de la categoria creada */
        public async Task<ActionResult<int>> Post(Actor actor){
            if (!string.IsNullOrWhiteSpace(actor.Photo))
            {
                var photo = Convert.FromBase64String(actor.Photo);
                actor.Photo = await FilesStorage.SaveFile(photo,"jpg","actors");
            }
            context.Add(actor);
            await context.SaveChangesAsync();
            return actor.Id;
        }
        [HttpGet]
        public async Task<ActionResult<List<Actor>>> Get ([FromQuery] Pagination pagination){
            var queryable = Context.Actors.AsQueryable();
            /* await HttpContext.ActoresPorPagina(queryable,pagination.CantidadRegistros); */
            return await queryable.Paginar(pagination).ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Actor>> Get (int id){
            var actor = await Context.Actors.FirstOrDefaultAsync(x=>x.Id == id);
            if (actor == null)
            {
                return NotFound();
            }
            return actor;
        }
 
        [HttpPut]
        public async Task<ActionResult> Put(Actor actor){
            var actorDB = await Context.Actors.FirstOrDefaultAsync(x=>x.Id == actor.Id);
            if (actorDB == null)
            {
                return NotFound();
            }
            /* actorDB =mapper.Map(actor, actorDB); */
            if (!string.IsNullOrWhiteSpace(actor.Photo))
            {
               var newPhotoActor = Convert.FromBase64String(actor.Photo);
               actorDB.Photo = await  FilesStorage.EditFile(newPhotoActor, "jpg","actors", actorDB.Photo);
            }
            await Context.SaveChangesAsync();
            return NoContent();
        }
 
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete (int id){
            var actorExist = await Context.Actors.AnyAsync(x=>x.Id == id);
            if (!actorExist)
            {
                return NotFound();
            }
            Context.Remove(new Actor{Id = id});
            await Context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("search/{text}")]
        public async Task<ActionResult<List<Actor>>> Get (string text){
            if (!string IsNullOrWhiteSpace(text))
            {
                return new List<Actor>();
            }
            Text = text.ToLower();
            return await Context.Actors.Where(x =>x.Name.ToLower().Contains(text)).ToListAsync();
        }
    }
}