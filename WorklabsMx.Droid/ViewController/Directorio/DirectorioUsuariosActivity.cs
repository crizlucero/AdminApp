using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class DirectorioUsuariosActivity : Activity
    {
        ScrollView svDirectorio;
        SimpleStorage storage;
        MiembrosController MembersController;
        Android.Support.V7.App.AlertDialog dialog;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Directorio();
        }

        void Directorio(string nombre = "", string apellido = "", string puesto = "", string profesion = "",
                      string habilidades = "", bool disponibilidad = true, string pais = "", string estado = "",
                      string municipio = "")
        {
            SetContentView(Resource.Layout.DirectorioLayout);
            SetTitle(Resource.String.DirectorioUsuario);

            svDirectorio = FindViewById<ScrollView>(Resource.Id.svDirectorio);
            MembersController = new MiembrosController();
            storage = SimpleStorage.EditGroup("Login");
            FillDirectorioUsuario(nombre, apellido, puesto, profesion, habilidades, disponibilidad, pais, estado, municipio);

        }

        void FillDirectorioUsuario(string nombre = "", string apellido = "", string puesto = "", string profesion = "",
                      string habilidades = "", bool disponibilidad = true, string pais = "", string estado = "",
                      string municipio = "")
        {
            LinearLayout llDirectorio = new LinearLayout(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                Orientation = Orientation.Vertical
            };
            string aux = "";
            MembersController.GetDirectorioUsuarios(nombre, apellido, puesto, profesion, habilidades, disponibilidad, pais, estado, municipio).ForEach((miembro) =>
            {
                if(miembro.Miembro_Nombre[0].ToString() != aux)
                {
                    LinearLayout llList = new LinearLayout(this);
                    llList.SetBackgroundColor(Color.Rgb(149,214,255));
                    TextView lblCapital = new TextView(this);
                    LinearLayout.LayoutParams ll = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
                    ll.LeftMargin = 50;
                    lblCapital.LayoutParameters = ll;
                    aux = miembro.Miembro_Nombre[0].ToString();
                    lblCapital.Text = aux;

                    llList.AddView(lblCapital);
                    llDirectorio.AddView(llList);
                }
                LayoutInflater liView = LayoutInflater;

                View PersonaCard = liView.Inflate(Resource.Layout.PreViewListLayout, null, true);

                ImageButton ibProfile = PersonaCard.FindViewById<ImageButton>(Resource.Id.ibProfile);

                TextView lblNombre = PersonaCard.FindViewById<TextView>(Resource.Id.lblTitle);

                lblNombre.Text = miembro.Miembro_Nombre + " " + miembro.Miembro_Apellidos;
                lblNombre.Click += delegate
                {
                    ShowPerfilCard(miembro);
                };

                TextView lblEmpresa = PersonaCard.FindViewById<TextView>(Resource.Id.lblSubTitle);
                lblEmpresa.Text = miembro.Miembro_Empresa;

                llDirectorio.AddView(PersonaCard);

            });
            svDirectorio.AddView(llDirectorio);
        }

        void ShowPerfilCard(MiembroModel miembro)
        {
            Android.Support.V7.App.AlertDialog.Builder builder = new Android.Support.V7.App.AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            View customView = liView.Inflate(Resource.Layout.PerfilCardLayout, null, true);

            customView.FindViewById<ImageButton>(Resource.Id.ibCerrar).Click += (sender, e) => dialog.Dismiss();

            customView.FindViewById<TextView>(Resource.Id.lblNombre).Text = miembro.Miembro_Nombre + " " + miembro.Miembro_Apellidos;
            customView.FindViewById<TextView>(Resource.Id.lblEmpresa).Text = miembro.Miembro_Empresa;
            customView.FindViewById<TextView>(Resource.Id.lblPuesto).Text = miembro.Miembro_Puesto;
            customView.FindViewById<TextView>(Resource.Id.lblProfesion).Text = miembro.Miembro_Profesion;
            customView.FindViewById<TextView>(Resource.Id.lblFechaNacimiento).Text = miembro.Miembro_Fecha_Nacimiento;
            customView.FindViewById<TextView>(Resource.Id.lblContacto).Text = miembro.Miembro_Telefono;
            customView.FindViewById<TextView>(Resource.Id.lblCorreo).Text = miembro.Miembro_Correo_Electronico;
            customView.FindViewById<TextView>(Resource.Id.lblFacebook).Text = "";
            customView.FindViewById<TextView>(Resource.Id.lblInstagram).Text = "";
            customView.FindViewById<TextView>(Resource.Id.lblTwitter).Text = "";

            builder.SetView(customView);
            builder.Create();
            dialog = builder.Show();
            dialog.Window.SetGravity(GravityFlags.Top | GravityFlags.Center);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.search_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_search:
                    SearchView();
                    break;
                default:
                    StartActivity(new Intent(this, typeof(MainActivity)));
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }

        void SearchView()
        {
            SetContentView(Resource.Layout.SearchUserLayout);


            FindViewById<ImageButton>(Resource.Id.btnClear).Click += (sender, e) =>
            {
                Directorio();
            };

            FindViewById<Button>(Resource.Id.btnBuscar).Click += (sender, e) =>
            {
                Directorio(FindViewById<TextView>(Resource.Id.txtNombre).Text, FindViewById<TextView>(Resource.Id.txtApellidos).Text,
                           FindViewById<TextView>(Resource.Id.txtPuesto).Text, FindViewById<TextView>(Resource.Id.txtProfesion).Text,
                           FindViewById<TextView>(Resource.Id.txtHabilidades).Text, FindViewById<CheckBox>(Resource.Id.cbDisponibilidad).Checked,
                           FindViewById<TextView>(Resource.Id.txtPais).Text, FindViewById<TextView>(Resource.Id.txtEstado).Text,
                           FindViewById<TextView>(Resource.Id.txtMunicipio).Text);
            };
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.DirectorioUsuario);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
        }
    }
}