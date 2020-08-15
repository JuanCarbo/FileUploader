using Corvo.FileUploader.Application.Notifications;
using Flunt.Notifications;
using Flunt.Validations;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Corvo.FileUploader.Application.Operations.File.Upload
{
    public class FileUploadRequest : Notifiable, IRequest<EntityResult<FileUploadResult>>
    {
        public FileUploadRequest(string fileName, IFormFile formFile)
        {
            FileName = fileName;
            FormFile = formFile;
            Verify();
        }

        private void Verify()
        {
            AddNotifications(new Contract()
                .IsNotNull(FormFile, "FormFile", "FormFile Should not be null.")
                .IsNotNullOrEmpty(FileName, "FileName", "FileName should not be null"));
        }

        public string FileName { get; }
        public IFormFile FormFile { get; }
    }
}
