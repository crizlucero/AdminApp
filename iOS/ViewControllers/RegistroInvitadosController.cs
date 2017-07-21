using Foundation;
using System;
using UIKit;
using System.Drawing;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class RegistroInvitadosController : UIViewController
    {
        public RegistroInvitadosController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
            //this.DefineMinMaxDate();
		}

        private void DefineMinMaxDate(){
            //dpFecha.MinimumDate = (NSDate) DateTime.Today;
            DateTime date = DateTime.Now;
			DateTime FirstDay = new DateTime(date.Year, date.Month, 1);
            DateTime LastDay = FirstDay.AddMonths(1).AddDays(-1);
            //dpFecha.MaximumDate = (NSDate)LastDay;
        }
    }
}