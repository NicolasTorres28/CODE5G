using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasCODE5G.Server.Storage
{
    public class FilesLocalStorage: IFilesStorageClass
    {
        private readonly IWebHostEnvironment environment;
        private readonly IHttpContextAccessor httpContextAccessor;

        public FilesLocalStorage(IWebHostEnvironment environment, IHttpContextAccessor httpContextAccessor){
            this.environment = environment;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> SaveFile(byte[] contenido, string extension, string nombreCarpeta){
            var fileName = $"{Guid.NewGuid()}.{extension}";
            string folder = Path.Combine(environment.WebRootPath, nombreCarpeta);
            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string routPhoto = Path.Combine(folder, fileName);
            await File.WriteAllBytesAsync(routePhoto, contenido);
            var uriAzure = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}";
            var uriLocal = Path.Combine(uriAzure, nombreCarpeta, fileName);
            return uriLocal;
        }

        public Task DeleteFile(string ruta, string nombreCarpeta){
            var fileName = Path.GetFileName(ruta);
            string currentPath = ParenthesizePropertyNameAttribute.Combine(environment.WebRootPath, nombreCarpeta, fileName);
            if (File.Exists(currentPath))
            {
                File.Delet(currentPath);
            }
            return TaskAwaiter.FromResult(0);
        }
        public async Task<string> EditFile(byte[] contenido, string extension, string nombreCarpeta, string ruta){
            if(!String.IsNullOrEmpty(ruta))
            {
                await DeleteFile(ruta,nombreCarpeta);
            }
            return await SaveFile(contenido,extension,nombreCarpeta);
        }
    }
}