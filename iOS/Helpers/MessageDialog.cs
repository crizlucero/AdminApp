using System;
using Foundation;
using UIKit;

using static WorklabsMx.iOS.Utils;

namespace WorklabsMx.iOS
{
    public class MessageDialog : IMessageDialog
    {

        public void SendMessage(string message, string title = null)
        {
            EnsureInvokedOnMainThread(() =>
            {
                var alertView = new UIAlertView(title ?? string.Empty, message, null, "OK");
                alertView.Show();
            });
        }

        public void SendToast(string message)
        {
            SendMessage(message);
        }

        public void SendConfirmation(string message, string title, Action<bool> confirmationAction)
        {
            EnsureInvokedOnMainThread(() =>
            {
                var alertView = new UIAlertView(title ?? string.Empty, message, null, "OK", "Cancel");
                alertView.Clicked += (sender, e) =>
                {
                    confirmationAction(e.ButtonIndex == 0);
                };
                alertView.Show();
            });
        }

        public void ShowImage(UIImage image)
        {
            EnsureInvokedOnMainThread(() =>
            {
                UIImageView uiIV = new UIImageView(image);
                UIAlertView Msg = new UIAlertView
                {
                    Frame = new CoreGraphics.CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)
                };
                Msg.SetValueForKey(uiIV, (NSString)"accessoryView");
                Msg.AddButton("X");
                Msg.Show();
            });
        }
    }
}
