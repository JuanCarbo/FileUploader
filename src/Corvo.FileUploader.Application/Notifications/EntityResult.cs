using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corvo.FileUploader.Application.Notifications
{
    public class EntityResult<T> : Result where T : class
    {
        public EntityResult(T data, IReadOnlyCollection<Notification> notifications) : base(notifications)
        {
            Data = data;
        }
        public T Data { get; set; }
    }
}
