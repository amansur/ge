using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace georgia.Controllers
{
    public class UController : Controller
    {
        private Context _db { get; set; }

        public UController(Context db)
        {
            _db = db;
        }
        
        [HttpGet]
        public IActionResult P(string slug)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> P(string slug, IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                var binary = memoryStream.ToArray();
                var fileEnding = file.FileName.Split('.').Last();

                var photo = new Photo
                {
                    Slug = slug,
                    PhotoUid = Guid.NewGuid(),
                    Binary = binary,
                    FileEnding = fileEnding
                };

                _db.Photo.Add(photo);
                await _db.SaveChangesAsync();
            }
            
            return View();
        }
    }
}
