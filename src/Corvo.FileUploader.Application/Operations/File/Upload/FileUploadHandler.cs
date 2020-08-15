using Corvo.FileUploader.Application.Notifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Corvo.FileUploader.Application.Operations.File.Upload
{
    class FileUploadHandler : IRequestHandler<FileUploadRequest, EntityResult<FileUploadResult>>
    {
        public Task<EntityResult<FileUploadResult>> Handle(FileUploadRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
