using System;
using System.ServiceProcess;
using Firebase.CloudMessaging;
using Plugin.FirebasePushNotification;
using System.Collections.Generic;
using UserNotifications;
//using Microsoft.Azure.NotificationHubs;
//using Microsoft.Azure.Mobile.Server.Config;

namespace WorklabsMx.iOS
{
    public class FirebaseNotificationService
    {
        public void onMessageReceived(RemoteMessage remoteMessage)
        {
            
        }

        public void SendMessage()
        {
            var content = new UNMutableNotificationContent();
            content.Title = "Notification Title";
            content.Subtitle = "Notification Subtitle";
            content.Body = "This is the message body of the notification.";
            content.Badge = 1;

            var trigger = UNTimeIntervalNotificationTrigger.CreateTrigger(5, false);

            var requestID = "sampleRequest";
            var request = UNNotificationRequest.FromIdentifier(requestID, content, trigger);

            UNUserNotificationCenter.Current.AddNotificationRequest(request, (err) => {
                if (err != null)
                {
                    // Do something with error...
                }
            });
        }
           
    }
}
