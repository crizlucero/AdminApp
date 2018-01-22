
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
using Newtonsoft.Json;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "InvitadosConfirmacionActivity")]
    public class InvitadosConfirmacionActivity : Activity
    {
        List<VisitaModel> invitados;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ConfirmacionInvitacionesLayout);
            invitados = new InvitadosController().GetInvitados(JsonConvert.DeserializeObject<List<int>>(Intent.GetStringExtra("Invitacion_Id")));
        }

        void FillInvitaciones()
        {
            invitados.ForEach(invitado =>
            {
                LayoutInflater liView = LayoutInflater;
                View invitadoView = liView.Inflate(Resource.Layout.ConfirmacionInvitadoLayout, null, true);
            });
        }
    }
}
