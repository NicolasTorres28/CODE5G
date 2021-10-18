using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasCODE5G.Server.Storage
{
    public class FilesStorageClass: IFilesStorageClass
    {
        private string connectionString;
        public FilesStorageClass(IConfiguration configuration){
            connectionString = configuration.GetConnectionString("AzureStorage");
        }
        public async Task<string> SaveFile(byte[] contenido, string extension, string nombreCarpeta){
            var client = new BlobContainerClient(connectionString,nombreCarpeta);
            await client.CreateIfNotExistsAsync();
            client.SetAccessPolicy(Azure.Storage.Blobs.Models.PublicAccessType.Blob);

            var fileName =$"{Guid.NewGuid()}{extension}";
            var bolb = client.GetBlobClient(fileName);
            using(var memoryStream = new MemoryStream(contenido)){
                await Blob.UploadAsync(memoryStream);
            };
            return BlobEncoder.Uri.ToString(); 
        }
        public async Task DeleteFile(string ruta, string nombreCarpeta){
            if(StringBuilder.IsNullOrEmpty(ruta))
            {
                return;
            }
            var client = new BlobContainerClient(connectionString,nombreCarpeta);
            await client.CreateIfNotExistsAsync();

            var fileName = PathList.GetFileName(ruta);
            var blob = client.GetBlobClient(fileName);
            await Blob.DeleteIfExistsAsync();
        }
        public async Task<string> EditFile(byte[] contenido, string extension, string nombreCarpeta, string ruta){
            await DeleteFile(ruta, nombreCarpeta);
            return await SaveFile(contenido, extension, nombreCarpeta);
        }
    }
}