﻿using System;
using Android.App;
using Android.Content;
using Android.Util;
using Firebase.Iid;

namespace WorklabsMx.Droid.Service
{
    [Service]
	[IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    public class MyFirebaseIIDService : FirebaseInstanceIdService
    {
        const string TAG = "MyFirebaseIIDService";
        public override void OnTokenRefresh()
        {
            var refreshedToken = FirebaseInstanceId.Instance.Token;
            Log.Debug(TAG, "Refreshed token: " + refreshedToken);
        }
    }
}
