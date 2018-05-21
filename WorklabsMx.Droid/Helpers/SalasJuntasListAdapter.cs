using System;
using System.Collections.Generic;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using WorklabsMx.Droid.ViewHolders;
using WorklabsMx.Models;

namespace WorklabsMx.Droid.Helpers
{
    public class SalasJuntasListAdapter : BaseAdapter<SalaJuntasModel>
    {
        readonly List<SalaJuntasModel> salas;
        public SalasJuntasListAdapter(List<SalaJuntasModel> salas)
        {
            this.salas = salas;
        }

        public override SalaJuntasModel this[int position] => salas[position];

        public override int Count => salas.Count;

        public override long GetItemId(int position) => (long)Convert.ToDouble(salas[position].Sala_Id);

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            /*if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.SalasJuntasLayout, parent, false);
                LinearLayout Base = view.FindViewById<LinearLayout>(Resource.Id.llSalaJunta);
                LinearLayout reserva = view.FindViewById<LinearLayout>(Resource.Id.llReserva);
                TextView nombre = view.FindViewById<TextView>(Resource.Id.lblSalaJunta);
                TextView capacidad = view.FindViewById<TextView>(Resource.Id.tvCapacidad);
                TextView nivel = view.FindViewById<TextView>(Resource.Id.tvNivel);
                ImageView imagen = view.FindViewById<ImageView>(Resource.Id.ivSalaJunta);

                view.Tag = new SalasJuntasHolder
                {
                    Nombre = nombre,
                    Capacidad = capacidad,
                    Nivel = nivel,
                    Reserva = reserva,
                    Base = Base,
                    imgSalaJuntas = imagen
                };
            }

            SalasJuntasHolder holder = (SalasJuntasHolder)view.Tag;

            holder.Nombre.Text = salas[position].Sala_Descripcion;
            holder.Capacidad.Text = salas[position].Sala_Capacidad + "-" + (Convert.ToInt32(salas[position].Sala_Capacidad) + 2).ToString();
            holder.Nivel.Text = "Nivel " + Convert.ToInt32(salas[position].Sala_Nivel).ToString("00");
            if (salas[position].Sala_Fotografia_Imagen != null && salas[position].Sala_Fotografia_Imagen.Length > 0)
                holder.imgSalaJuntas.SetImageBitmap(BitmapFactory.DecodeByteArray(salas[position].Sala_Fotografia_Imagen, 0, salas[position].Sala_Fotografia_Imagen.Length));
*/
            return view;
        }
    }
}
