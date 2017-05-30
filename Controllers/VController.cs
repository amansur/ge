using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace georgia.Controllers
{
    public class VController : Controller
    {
        private Context _db { get; set; }

        public VController(Context db)
        {
            _db = db;
        }
        
        [HttpGet]
        public IActionResult I(string slug)
        {
            Photo photo;
            Photo prevPhoto;
            Photo nextPhoto;
            PhotoViewModel vm;

            if (string.IsNullOrWhiteSpace(slug))
            {
                photo = _db.Photo.OrderBy(c => c.Id).FirstOrDefault();
                nextPhoto = _db.Photo.OrderBy(c => c.Id).Skip(1).FirstOrDefault();
                vm = new PhotoViewModel
                {
                    Photo = photo,
                    PrevPhoto = null,
                    NextPhoto = nextPhoto
                };
                return View(vm);
            }

            photo = _db.Photo.FirstOrDefault(c => c.Slug == slug);
            prevPhoto = _db.Photo.Where(c => c.Id == photo.Id - 1).FirstOrDefault();
            nextPhoto = _db.Photo.Where(c => c.Id == photo.Id + 1).FirstOrDefault();
            vm = new PhotoViewModel 
            { 
                Photo = photo,
                PrevPhoto = prevPhoto,
                NextPhoto = nextPhoto
            };
            return View(vm);
        }

        [HttpGet]
        public IActionResult All()
        {
            var all = _db.Photo;
            return View(all);
        }

        [HttpGet]
        public void Delete()
        {
            var photo = _db.Photo;
            _db.Photo.RemoveRange(photo);
            _db.SaveChanges();
        }
    }
}
