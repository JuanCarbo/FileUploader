using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Corvo.FileUploader.Application.Notifications
{
    public class Result : Notifiable
    {
        public Result(IReadOnlyCollection<Notification> notifications, StatusCode statusCode)
        {
            this.AddNotifications(notifications);
            Error = statusCode;
        }

        public StatusCode Error { get; }
    }
}
