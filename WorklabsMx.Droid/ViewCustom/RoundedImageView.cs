using System;
using Android.Content;
using Android.Widget;
using Android.Util;
using Android.Graphics;

namespace WorklabsMx.Droid.ViewCustom
{
    public class RoundedImageView : ImageView
    {
        public static float radius = 20.0f;
        public RoundedImageView(Context context) : base(context)
        {
        }

        public RoundedImageView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public RoundedImageView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        {
        }

        protected override void OnDraw(Canvas canvas)
        {
            Path clipPath = new Path();
            RectF rect = new RectF(0, 0, Width, Height);
            clipPath.AddRoundRect(rect, radius, radius, Path.Direction.Cw);
            canvas.ClipPath(clipPath);
            OnDraw(canvas);
        }
    }
}
