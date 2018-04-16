using System;
using System.Collections.Generic;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.ViewHolders;
using WorklabsMx.Models;

namespace WorklabsMx.Droid.Helpers
{
    public class MeGustaListAdapter : BaseAdapter<UsuarioModel>
    {
        readonly List<UsuarioModel> usuarios;
        public MeGustaListAdapter(List<UsuarioModel> usuarios)
        {
            this.usuarios = usuarios;
        }

        public override UsuarioModel this[int position] => usuarios[position];

        public override int Count => usuarios.Count;

        public override long GetItemId(int position) => (long)Convert.ToDouble(usuarios[position].Usuario_Id);

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.PreViewListLayout, parent, false);
                TextView nombre = view.FindViewById<TextView>(Resource.Id.lblTitle);
                TextView empresa = view.FindViewById<TextView>(Resource.Id.lblSubTitle);
                ImageButton imagen = view.FindViewById<ImageButton>(Resource.Id.ibProfile);
                Button seguir = view.FindViewById<Button>(Resource.Id.btnSeguir);

                view.Tag = new UsuariosHolder
                {
                    lblNombre = nombre,
                    imgPerfil = imagen,
                    lblEmpresa = empresa,
                    btnSeguir = seguir
                };
            }

            UsuariosHolder holder = (UsuariosHolder)view.Tag;

            holder.lblNombre.Text = usuarios[position].Usuario_Nombre;
            holder.lblEmpresa.Text = usuarios[position].Usuario_Empresa_Nombre;
            SimpleStorage storage = SimpleStorage.EditGroup("Login");
            if (new UsuariosController().IsMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), usuarios[position].Usuario_Id, usuarios[position].Usuario_Tipo).Value)
            {
                holder.btnSeguir.Visibility = ViewStates.Visible;
                holder.btnSeguir.Click += (sender, e) =>
                {
                    if (new UsuariosController().AddMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), usuarios[position].Usuario_Id, usuarios[position].Usuario_Tipo))
                        ((Button)sender).Visibility = ViewStates.Gone;
                    else
                        Toast.MakeText(parent.Context, Resource.String.str_general_save_error, ToastLength.Short).Show();
                };
            }
            if (usuarios[position].Usuario_Fotografia_Perfil != null && usuarios[position].Usuario_Fotografia_Perfil.Length > 0)
                holder.imgPerfil.SetImageBitmap(ImagesHelper.GetRoundedShape(BitmapFactory.DecodeByteArray(usuarios[position].Usuario_Fotografia_Perfil, 0, usuarios[position].Usuario_Fotografia_Perfil.Length)));

            return view;
        }
    }
}
