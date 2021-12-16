using Microsoft.AspNetCore.Http;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RentalKendaraan.Models.Upload
{
    public static class IFormFileExtensions
    {
        public static string GetFileName(this IFormFile file)
        {
            return ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.ToString().Trim('"');
        }
        
        public static async Task<MemoryStream> GetFileStream(this IFormFile file)
        {
            MemoryStream fileStream = new MemoryStream();
            await file.CopyToAsync(fileStream);
            return fileStream;
        }

        public static async Task<byte[]> GetFileArray(this IFormFile file)
        {
            MemoryStream stream = new MemoryStream();
            await file.CopyToAsync(stream);
            return stream.ToArray();
        }
    }
}
