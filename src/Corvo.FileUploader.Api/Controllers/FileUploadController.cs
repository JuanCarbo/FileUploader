
using System.Threading.Tasks;
using Corvo.FileUploader.Application.Operations.File.Upload;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Corvo.FileUploader.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileUploadController : ControllerBase
    {
        private readonly IMediator mediator;

        public FileUploadController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> PostFile(string filename, IFormFile file)
        {
            var result = await mediator.Send(new FileUploadRequest(filename, file));
            if (result.Valid)
            {
                return Ok();
            }
            return new NotFoundResult();
        }
    }
}
