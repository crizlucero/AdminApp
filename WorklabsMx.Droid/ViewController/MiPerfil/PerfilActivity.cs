using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "PerfilActivity")]
    public class PerfilActivity : Activity
    {
        SimpleStorage storage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.PerfilLayout);
            SimpleStorage.SetContext(ApplicationContext);
            storage = SimpleStorage.EditGroup("Login");
            FillUserData();

        }

        void FillUserData()
        {
            MiembroModel miembro = new MiembrosController().GetMemberData(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"));
            FindViewById<ImageView>(Resource.Id.imgPerfil).SetImageURI(Android.Net.Uri.Parse("http://worklabs.mx/Dashboard_Client/usr_imgs/" + miembro.Miembro_Fotografia));
            FindViewById<TextView>(Resource.Id.txtProfileName).Text = miembro.Miembro_Nombre + " " + miembro.Miembro_Apellidos;
            FindViewById<TextView>(Resource.Id.txtEmailPerfil).Text = miembro.Miembro_Correo_Electronico;
            FindViewById<TextView>(Resource.Id.txtGeneroPerfil).Text = miembro.Genero_Descripcion;
            FindViewById<TextView>(Resource.Id.txtFechaNacimientoPerfil).Text = miembro.Miembro_Fecha_Nacimiento;
            FindViewById<TextView>(Resource.Id.txtProfesionPerfil).Text = miembro.Miembro_Profesion;
            FindViewById<TextView>(Resource.Id.txtPuestoPerfil).Text = miembro.Miembro_Puesto;
            FindViewById<TextView>(Resource.Id.txtHabilidadesPerfil).Text = miembro.Miembro_Habilidades;
            FindViewById<TextView>(Resource.Id.txtTelefonoPerfil).Text = miembro.Miembro_Telefono;
            FindViewById<TextView>(Resource.Id.txtCelularPerfil).Text = miembro.Miembro_Celular;
        }
    }
}