using System.Threading.Tasks;
using Xunit;
using Corvo.FileUploader.Api.Controllers;
using MediatR;
using Moq;
using System.IO;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.Extensions.Primitives;
using System.Threading;

namespace Corvo.FileUploader.Tests.Acceptance.Api.Controllers
{
    public class FileUploadControllerTests
    {
        private readonly FileUploadController fileUploadController;
        private readonly Mock<IMediator> mediator;
        private const string FILESLOCATION = "Files\\Api\\Controllers\\UploadSample.txt";

        public FileUploadControllerTests()
        {
            mediator = new Mock<IMediator>();

            fileUploadController = new FileUploadController();
        }

        [Fact(DisplayName = "Should receive a FormFile and a location and send it to a mediator")]
        public async Task ReceivesAndSendsFile()
        {
            //Arrange
            var file = File.OpenRead( $"{AppDomain.CurrentDomain.BaseDirectory}\\{FILESLOCATION}");
            var formFile = new FormFile(file, 0, file.Length, file.Name, file.Name);

            var fileName = ".\\UploadTest.txt";

            //Act
            var result = await fileUploadController.PostFile(fileName, formFile);

            //Assert
            mediator.Verify(x => x.Send(It.Is<FormFile>(x => x.FileName == fileName), It.IsAny<CancellationToken>()));

        }

    }
}
