using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasCODE5G.Server.Storage
{
    public interface IFilesStorageClass
    {
         Task<string> SaveFile(byte[] contenido, string extension, string nombreCarpeta);
         Task DeleteFile(string ruta, string FilesStorage);
         Task<string> EditFile(byte[] contenido, string extension, string nombreCarpeta, string ruta);
    }
}