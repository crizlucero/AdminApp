using System;
using System.ServiceProcess;
using Firebase.CloudMessaging;
using Plugin.FirebasePushNotification;
using System.Collections.Generic;
//using Microsoft.Azure.NotificationHubs;
//using Microsoft.Azure.Mobile.Server.Config;

namespace WorklabsMx.iOS
{
    public class FirebaseNotificationService : FirebasePushNotificationManager
    {
        public void onMessageReceived(RemoteMessage remoteMessage)
        {
            
        }
           
    }
}
