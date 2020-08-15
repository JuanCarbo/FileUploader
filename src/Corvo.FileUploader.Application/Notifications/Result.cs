using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corvo.FileUploader.Application.Notifications
{
    public class Result : Notifiable
    {
        public Result(IReadOnlyCollection<Notification> notifications)
        {
            AddNotifications(notifications);
        }
    }
}
