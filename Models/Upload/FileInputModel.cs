using Microsoft.AspNetCore.Http;

namespace RentalKendaraan.Models.Upload
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
