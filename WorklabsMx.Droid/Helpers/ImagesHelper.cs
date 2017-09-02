using Android.Net;

namespace WorklabsMx.Droid.Helpers
{
    public class ImagesHelper
    {
        public static Uri GetPerfilImagen(string imagen)
        {
            return Uri.Parse("http://desarrolloworklabs.com/Dashboard_Client/usr_imgs/" + imagen);
        }
    }
}
