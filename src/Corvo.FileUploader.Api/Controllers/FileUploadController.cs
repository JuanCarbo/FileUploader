using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Corvo.FileUploader.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileUploadController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostFile(string filename, [FromForm] IFormFile file)
        {
            if (file == null)
                throw new Exception();
            return new OkResult();
        }
    }
}
