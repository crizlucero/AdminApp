using System;
using UIKit;
//using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using Foundation;
using System.Text.RegularExpressions;
using WorklabsMx.iOS.Helpers;
using BigTed;
using System.Threading.Tasks;
using WorklabsMx.Models;
using WorklabsMx.Helpers;
using WorklabsMx.iOS.Models;
using CoreAnimation;
using CoreGraphics;

namespace WorklabsMx.iOS
{
    public partial class ViewControllerSidebar : UIViewController
    {
        MenuTableSourceClass objMenuTableSource;
        nfloat flViewShiftUpY;
        nfloat flViewBringDownY;

        public ViewControllerSidebar(IntPtr handle) : base ( handle )
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            FnInitializeView();
            tableViewLeftMenu.Hidden = true;
            FnBindMenu();
        }
        void FnInitializeView()
        {

            CGRect rectBounds = UIScreen.MainScreen.Bounds;

            flViewBringDownY = rectBounds.Height - 30f; //complete collapse viewContainer
            flViewShiftUpY = rectBounds.Height - 120f;//200 is the heght of viewContainer

            var recognizerRight = new UISwipeGestureRecognizer(FnSwipeLeftToRight);
            recognizerRight.Direction = UISwipeGestureRecognizerDirection.Right;
            View.AddGestureRecognizer(recognizerRight);

            var recognizerLeft = new UISwipeGestureRecognizer(FnSwipeRightToLeft);
            recognizerLeft.Direction = UISwipeGestureRecognizerDirection.Left;
            View.AddGestureRecognizer(recognizerLeft);


            btnIcon.SetBackgroundImage(UIImage.FromBundle("Images/menu_icon"), UIControlState.Normal);

            //          btnBottom.SetBackgroundImage ( UIImage.FromBundle ( "Images/up_arrow" ) , UIControlState.Normal );
            btnBottom.SetBackgroundImage(UIImage.FromBundle("Images/down_arrow"), UIControlState.Selected);

            btnBottom.TouchUpInside += delegate (object sender, EventArgs e)
            {
                btnBottom.Selected = !btnBottom.Selected;
            };
            btnIcon.TouchUpInside += delegate (object sender, EventArgs e)
            {
                FnPerformTableTransition();
            };

        }

        void FnSwipeLeftToRight()
        {
            if (tableViewLeftMenu.Hidden)
                FnPerformTableTransition();

        }

        void FnSwipeRightToLeft()
        {
            if (!tableViewLeftMenu.Hidden)
                FnPerformTableTransition();
        }
        void FnPerformTableTransition()
        {
            tableViewLeftMenu.Hidden = !tableViewLeftMenu.Hidden;
            var transition = new CATransition();
            transition.Duration = 0.25f;
            transition.Type = CAAnimation.TransitionPush;
            if (tableViewLeftMenu.Hidden)
            {
                transition.TimingFunction = CAMediaTimingFunction.FromName(new Foundation.NSString("easeOut"));
                transition.Subtype = CAAnimation.TransitionFromRight;
            }
            else
            {
                transition.TimingFunction = CAMediaTimingFunction.FromName(new Foundation.NSString("easeIn"));
                transition.Subtype = CAAnimation.TransitionFromLeft;
            }
            tableViewLeftMenu.Layer.AddAnimation(transition, null);
        }
        void FnBindMenu()
        {
            if (objMenuTableSource != null)
            {
                objMenuTableSource.MenuSelected -= FnMenuSelected;
                objMenuTableSource = null;
            }
            objMenuTableSource = new MenuTableSourceClass();
            objMenuTableSource.MenuSelected += FnMenuSelected;
            tableViewLeftMenu.Source = objMenuTableSource;
        }
        void FnMenuSelected(string strMenuSeleted)
        {
            txtActionBarText.Text = strMenuSeleted;
            FnSwipeRightToLeft();
        }
        void FnAnimateView(nfloat frameY, UIView view)
        {
            UIView.Animate(0.2f, 0.1f, UIViewAnimationOptions.CurveEaseIn, delegate
            {
                var frame = View.Frame;
                frame.Y = frameY;
                view.Frame = frame;
            }, null);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }
}