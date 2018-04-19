
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

namespace WorklabsMx.Droid.ViewHolders
{
    public class UsuariosHolder : Java.Lang.Object
    {
        public ImageButton imgPerfil { get; set; }
        public TextView lblNombre { get; set; }
        public TextView lblEmpresa { get; set; }
        public ImageView imgFavorito { get; set; }
        public Button btnSeguir { get; set; }
    }
}
