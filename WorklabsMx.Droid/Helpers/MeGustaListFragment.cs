
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace WorklabsMx.Droid.Helpers
{
    public class MeGustaListFragment : DialogFragment
    {
        string post_id;
        public MeGustaListFragment(string post_id)
        {
            this.post_id = post_id;
        }

        public Dialog GetDialog(){
            AlertDialog.Builder builder = new AlertDialog.Builder(Activity);

            return builder.Create();
        }
    }
}
