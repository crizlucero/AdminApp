
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WorklabsMx.Droid.ViewController.Servicios
{
    [Activity(Label = "ComprasActivity")]
    public class ComprasActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }

    class ImageAdapter : BaseAdapter
    {
        Context context;
        List<string> elementos;
        public ImageAdapter(Context context, List<string> elementos)
        {
            this.context = context;
            this.elementos = elementos;
        }

        public override int Count
        {
            get { return elementos.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            TextView textView;

            if (convertView == null)
            {  // if it's not recycled, initialize some attributes
                textView = new TextView(context);
                //imageView.LayoutParameters = new GridView.LayoutParams(85, 85);
                //imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
                //imageView.SetPadding(8, 8, 8, 8);
            }
            else
            {
                textView = (TextView)convertView;
            }

            //imageView.SetImageResource(thumbIds[position]);
            return textView;
        }


    }
}
