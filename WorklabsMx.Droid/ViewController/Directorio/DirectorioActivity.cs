using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using com.refractored;
using Java.Lang;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class DirectorioActivity : FragmentActivity
    {
        ViewPager _viewPager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.DirectoriosLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Directorio);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            _viewPager = FindViewById<ViewPager>(Resource.Id.vpSucursal);
            List<MiembroModel> miembros = new MiembrosController().GetDirectorioUsuarios();
            List<EmpresaModel> empresas = new EmpresaController().GetDirectorioEmpresas();
            SimpleStorage storage = SimpleStorage.EditGroup("Login");
            List<MiembroModel> favoritos = new MiembrosController().GetMiembrosFavoritos(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"));
            _viewPager.Adapter = new DirectorioAdapter(this, new List<string> { "Miembros", "Empresas", "Favoritos" }, miembros, empresas, favoritos);

            PagerSlidingTabStrip tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs);
            tabs.SetTextColorResource(Resource.Color.comment_pressed);
            tabs.SetViewPager(_viewPager);
            SearchView busqueda = FindViewById<SearchView>(Resource.Id.svBuscar);
            busqueda.SetQueryHint("Buscar...");
            busqueda.QueryTextChange += (sender, e) =>
            {
                _viewPager.Adapter = new DirectorioAdapter(this, new List<string> { "Miembros", "Empresas", "Favoritos" },
                                                           miembros.Where(miembro => miembro.Miembro_Nombre.IndexOf(((SearchView)sender).Query, StringComparison.OrdinalIgnoreCase) >= 0).ToList(),
                                                           empresas.Where(empresa => empresa.Empresa_Miembro_Nombre.IndexOf(((SearchView)sender).Query, StringComparison.OrdinalIgnoreCase)>= 0).ToList(),
                                                           favoritos.Where(miembro => miembro.Miembro_Nombre.IndexOf(((SearchView)sender).Query, StringComparison.OrdinalIgnoreCase) >= 0).ToList());
            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
            return base.OnOptionsItemSelected(item);
        }
    }

    public class DirectorioAdapter : PagerAdapter
    {
        readonly Context context;
        List<string> directorios;
        ScrollView svMiembros, svEmpresas;
        SimpleStorage storage;
        readonly List<MiembroModel> miembros, favoritos;
        readonly List<EmpresaModel> empresas;
        Android.Support.V7.App.AlertDialog dialog;
        public DirectorioAdapter(Context context, List<string> directorios, List<MiembroModel> miembros, List<EmpresaModel> empresas, List<MiembroModel> favoritos)
        {
            this.context = context;
            this.directorios = directorios;
            this.miembros = miembros;
            this.empresas = empresas;
            this.favoritos = favoritos;
            storage = SimpleStorage.EditGroup("Login");
        }

        public override Java.Lang.Object InstantiateItem(View container, int position)
        {
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            View SucursalView = liView.Inflate(Resource.Layout.DirectorioLayout, null, true);

            switch (directorios[position])
            {
                case "Favoritos": 
                    svMiembros = SucursalView.FindViewById<ScrollView>(Resource.Id.svDirectorio);
                    FillDirectorioUsuario(favoritos);
                    break;
                case "Empresas":
                    svEmpresas = SucursalView.FindViewById<ScrollView>(Resource.Id.svDirectorio);
                    FillDirectorioEmpresa(); break;
                default:
                    svMiembros = SucursalView.FindViewById<ScrollView>(Resource.Id.svDirectorio);
                    FillDirectorioUsuario(miembros); break;
            }

            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(SucursalView);
            return SucursalView;
        }

        public override int Count => directorios.Count;

        public override bool IsViewFromObject(View view, Java.Lang.Object @object) => view == @object;

        public override ICharSequence GetPageTitleFormatted(int position) => new Java.Lang.String(directorios[position]);

        public override void DestroyItem(View container, int position, Java.Lang.Object @object) => container.JavaCast<ViewPager>().RemoveView(@object as View);

        public void FillDirectorioUsuario(List<MiembroModel> usuarios)
        {
            LinearLayout llDirectorio = new LinearLayout(context)
            {
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                Orientation = Orientation.Vertical
            };
            string aux = "";
            usuarios.ForEach((miembro) =>
            {
                if (miembro.Miembro_Nombre[0].ToString() != aux)
                {
                    LinearLayout llList = new LinearLayout(context);
                    llList.SetBackgroundColor(Color.Rgb(149, 214, 255));
                    TextView lblCapital = new TextView(context);
                    LinearLayout.LayoutParams ll = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
                    {
                        LeftMargin = 50
                    };
                    lblCapital.LayoutParameters = ll;
                    aux = miembro.Miembro_Nombre[0].ToString();
                    lblCapital.Text = aux;

                    llList.AddView(lblCapital);
                    llDirectorio.AddView(llList);
                }
                LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);

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
            svMiembros.AddView(llDirectorio);
        }

        void ShowPerfilCard(MiembroModel miembro)
        {
            Android.Support.V7.App.AlertDialog.Builder builder = new Android.Support.V7.App.AlertDialog.Builder(context);

            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);

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

        public void FillDirectorioEmpresa()
        {
            LinearLayout llDirectorio = new LinearLayout(context)
            {
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                Orientation = Orientation.Vertical
            };
            string aux = "";
            empresas.ForEach((empresa) =>
            {
                if (empresa.Empresa_Miembro_Nombre[0].ToString() != aux)
                {
                    LinearLayout llList = new LinearLayout(context);
                    llList.SetBackgroundColor(Color.Rgb(149, 214, 255));
                    TextView lblCapital = new TextView(context);
                    LinearLayout.LayoutParams ll = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
                    {
                        LeftMargin = 50
                    };
                    lblCapital.LayoutParameters = ll;
                    aux = empresa.Empresa_Miembro_Nombre[0].ToString();
                    lblCapital.Text = aux;

                    llList.AddView(lblCapital);
                    llDirectorio.AddView(llList);
                }
                LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);

                View PersonaCard = liView.Inflate(Resource.Layout.PreViewListLayout, null, true);

                ImageButton ibProfile = PersonaCard.FindViewById<ImageButton>(Resource.Id.ibProfile);

                TextView lblNombre = PersonaCard.FindViewById<TextView>(Resource.Id.lblTitle);

                lblNombre.Text = empresa.Empresa_Miembro_Nombre;

                llDirectorio.AddView(PersonaCard);

            });
            svEmpresas.AddView(llDirectorio);
        }
    }
}
