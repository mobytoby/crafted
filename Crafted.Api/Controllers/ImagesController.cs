using System;
using System.IO;
using System.Threading.Tasks;
using Crafted.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crafted.Api.Controllers
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    [Route("api/[controller]")]
    public class ImagesController : ControllerBase
    {
        private IHostingEnvironment Environment { get; }
        private CraftedContext Context { get; }
        public ImagesController(CraftedContext context, IHostingEnvironment environment)
        {
            Environment = Environment ?? throw new ArgumentNullException(nameof(environment));
        }
        
        // POST: api/Image
        [HttpPost]
        public async Task Post(IFormFile file)
        {
            var uploads = Path.Combine(Environment.WebRootPath, "uploads");
            var filename = Path.Combine(uploads, file.FileName);

            if (file.Length > 0)
            {
                using (var fileStream = new FileStream(filename, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                    var image = new Image {
                        Name = file.FileName,
                        ImageUrl = filename,
                    };
                    CraftedContext.Image
                }
            }
        }
    }
}