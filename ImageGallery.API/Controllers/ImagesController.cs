using ImageGallery.API.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ImageGallery.API.Controllers
{
    public class ImagesController : Controller
    {
        private readonly IGalleryRepository _repository;
        private readonly IHostingEnvironment _enviroment;

        public ImagesController(IGalleryRepository repository, IHostingEnvironment environment)
        {
            _repository = repository;
            _enviroment = environment;
        }

        [HttpGet()]
        public IActionResult GetImages()
        {
            var images = _repository.GetImages();

            return Ok(images);
        }
    }
}