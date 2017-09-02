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
			Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.MiPerfil);
			ActionBar.SetDisplayHomeAsUpEnabled(true);
			ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

			/*ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
			var tab = this.ActionBar.NewTab();
			tab.SetIcon(Resource.Mipmap.ic_profile);
			tab.TabSelected += (sender, e) =>
			{
				e.FragmentTransaction.Add(Resource.Id.ProfileLayout, new MyProfileFragment());
			};
			ActionBar.AddTab(tab);*/

            /*ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            ActionBar.Tab tab = ActionBar.NewTab();
            tab.SetText(Resources.GetString(Resource.String.MiPerfil));
            tab.SetIcon(Resource.Mipmap.ic_profile);
            tab.TabSelected += (sender, e) => {
                
            };

            ActionBar.AddTab(tab);

            tab = ActionBar.NewTab();
            tab.SetText(Resources.GetString(Resource.String.MiEmpresa));
            tab.SetIcon(Resource.Mipmap.ic_domain);
            tab.TabSelected += (sender, e) => {
                
            };
            ActionBar.AddTab(tab);*/
        }

		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			//MenuInflater.Inflate(Resource.Menu.top_menus, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{

			base.OnBackPressed();
			return base.OnOptionsItemSelected(item);
		}

        void FillUserData()
        {
            MiembroModel miembro = new MiembrosController().GetMemberData(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"));
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