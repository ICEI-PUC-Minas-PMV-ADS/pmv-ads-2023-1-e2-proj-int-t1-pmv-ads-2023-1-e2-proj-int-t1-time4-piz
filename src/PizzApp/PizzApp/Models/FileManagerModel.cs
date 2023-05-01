using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;

namespace PizzApp.Models
{
    public class FileManagerModel
    {
        public FileInfo[] Files { get; set; }
        public IFormFile IFormFile { get; set; }
        public List<IFormFile> FormFiles { get; set; }
        public string PathImagesProduto { get; set; }
    }
}
