using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using BigTed;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Models;

namespace WorklabsMx.iOS
{
    public partial class DetalleMembresiaTableVieController : UITableViewController
    {

        public MembresiaModel Membresia = new MembresiaModel();

        public DetalleMembresiaTableVieController (IntPtr handle) : base (handle)
        {
        }
    }
}