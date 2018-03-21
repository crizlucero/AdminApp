using System;
using System.Collections.Generic;
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
using Newtonsoft.Json;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
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
            List<UsuarioModel> usuarios = new UsuariosController().GetDirectorioUsuarios();
            List<EmpresaModel> empresas = new EmpresaController().GetDirectorioEmpresas();
            SimpleStorage storage = SimpleStorage.EditGroup("Login");
            List<UsuarioModel> favoritos = new UsuariosController().GetMiembrosFavoritos(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"));
            _viewPager.Adapter = new DirectorioAdapter(this, new List<string> { "Miembros", "Empresas", "Favoritos" }, usuarios, empresas, favoritos);

            PagerSlidingTabStrip tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs);
            tabs.SetTextColorResource(Resource.Color.comment_pressed);
            tabs.SetViewPager(_viewPager);
            SearchView busqueda = FindViewById<SearchView>(Resource.Id.svBuscar);
            busqueda.SetQueryHint("Buscar...");
            busqueda.QueryTextChange += (sender, e) =>
            {
                _viewPager.Adapter = new DirectorioAdapter(this, new List<string> { "Miembros", "Empresas", "Favoritos" },
                                                           usuarios.Where(usuario => usuario.Usuario_Nombre.IndexOf(((SearchView)sender).Query, StringComparison.OrdinalIgnoreCase) >= 0).ToList(),
                                                           empresas.Where(empresa => empresa.Empresa_Nombre.IndexOf(((SearchView)sender).Query, StringComparison.OrdinalIgnoreCase) >= 0).ToList(),
                                                           favoritos.Where(miembro => miembro.Usuario_Nombre.IndexOf(((SearchView)sender).Query, StringComparison.OrdinalIgnoreCase) >= 0).ToList());
            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
            return base.OnOptionsItemSelected(item);
        }

        public override void OnBackPressed()
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
        }
    }

    public class DirectorioAdapter : PagerAdapter
    {
        readonly Context context;
        List<string> directorios;
        ScrollView svDirectorio;
        SimpleStorage storage;
        readonly List<UsuarioModel> usuarios, favoritos;
        readonly List<EmpresaModel> empresas;
        public DirectorioAdapter(Context context, List<string> directorios, List<UsuarioModel> usuarios, List<EmpresaModel> empresas, List<UsuarioModel> favoritos)
        {
            this.context = context;
            this.directorios = directorios;
            this.usuarios = usuarios;
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
                    svDirectorio = SucursalView.FindViewById<ScrollView>(Resource.Id.svDirectorio);
                    FillDirectorioUsuario(favoritos);
                    break;
                case "Empresas":
                    svDirectorio = SucursalView.FindViewById<ScrollView>(Resource.Id.svDirectorio);
                    FillDirectorioEmpresa(); break;
                default:
                    svDirectorio = SucursalView.FindViewById<ScrollView>(Resource.Id.svDirectorio);
                    FillDirectorioUsuario(usuarios); break;
            }

            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(SucursalView);
            return SucursalView;
        }

        public override int Count => directorios.Count;

        public override bool IsViewFromObject(View view, Java.Lang.Object @object) => view == @object;

        public override ICharSequence GetPageTitleFormatted(int position) => new Java.Lang.String(directorios[position]);

        public override void DestroyItem(View container, int position, Java.Lang.Object @object) => container.JavaCast<ViewPager>().RemoveView(@object as View);

        public void FillDirectorioUsuario(List<UsuarioModel> miembros)
        {
            LinearLayout llDirectorio = new LinearLayout(context)
            {
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                Orientation = Orientation.Vertical
            };
            string aux = "";
            miembros.ForEach((miembro) =>
            {
                if (miembro.Usuario_Nombre[0].ToString() != aux)
                {
                    LinearLayout llList = new LinearLayout(context);
                    llList.SetBackgroundColor(Color.Rgb(149, 214, 255));
                    TextView lblCapital = new TextView(context);
                    LinearLayout.LayoutParams ll = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
                    {
                        LeftMargin = 50
                    };
                    lblCapital.LayoutParameters = ll;
                    aux = miembro.Usuario_Nombre[0].ToString();
                    lblCapital.Text = aux;

                    llList.AddView(lblCapital);
                    llDirectorio.AddView(llList);
                }
                LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);

                View PersonaCard = liView.Inflate(Resource.Layout.PreViewListLayout, null, true);

                ImageButton ibProfile = PersonaCard.FindViewById<ImageButton>(Resource.Id.ibProfile);
                if (miembro.Usuario_Fotografia_Perfil != null)
                    ibProfile.SetImageBitmap(ImagesHelper.GetRoundedShape(BitmapFactory.DecodeByteArray(miembro.Usuario_Fotografia_Perfil, 0, miembro.Usuario_Fotografia_Perfil.Length)));
                else
                    ibProfile.SetImageResource(Resource.Mipmap.ic_profile_empty);

                TextView lblNombre = PersonaCard.FindViewById<TextView>(Resource.Id.lblTitle);

                lblNombre.Text = miembro.Usuario_Nombre + " " + miembro.Usuario_Apellidos;
                lblNombre.Click += delegate
                {
                    ShowPerfilCard(miembro);
                };

                TextView lblEmpresa = PersonaCard.FindViewById<TextView>(Resource.Id.lblSubTitle);
                lblEmpresa.Text = miembro.Usuario_Empresa_Nombre;

                llDirectorio.AddView(PersonaCard);

            });
            svDirectorio.AddView(llDirectorio);
        }

        void ShowPerfilCard(UsuarioModel miembro)
        {
            Intent intent = new Intent(context, typeof(PerfilCardActivity));
            intent.PutExtra("Miembro", JsonConvert.SerializeObject(miembro));
            context.StartActivity(intent);
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
                if (empresa.Empresa_Nombre[0].ToString() != aux)
                {
                    LinearLayout llList = new LinearLayout(context);
                    llList.SetBackgroundColor(Color.Rgb(149, 214, 255));
                    TextView lblCapital = new TextView(context);
                    LinearLayout.LayoutParams ll = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
                    {
                        LeftMargin = 50
                    };
                    lblCapital.LayoutParameters = ll;
                    aux = empresa.Empresa_Nombre[0].ToString();
                    lblCapital.Text = aux;

                    llList.AddView(lblCapital);
                    llDirectorio.AddView(llList);
                }
                LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);

                View PersonaCard = liView.Inflate(Resource.Layout.PreViewListLayout, null, true);

                ImageButton ibProfile = PersonaCard.FindViewById<ImageButton>(Resource.Id.ibProfile);
                //if (empresa.Usuario_Fotografia_Perfil != null)
                //    ibProfile.SetImageBitmap(BitmapFactory.DecodeByteArray(miembro.Usuario_Fotografia_Perfil, 0, miembro.Usuario_Fotografia_Perfil.Length));
                //else
                //    ibProfile.SetImageResource(Resource.Mipmap.ic_profile_empty);


                TextView lblNombre = PersonaCard.FindViewById<TextView>(Resource.Id.lblTitle);

                lblNombre.Text = empresa.Empresa_Nombre;
                lblNombre.Click += delegate
                {
                    ShowEmpresaCard(empresa);
                };

                llDirectorio.AddView(PersonaCard);

            });
            svDirectorio.AddView(llDirectorio);
        }
        void ShowEmpresaCard(EmpresaModel empresa)
        {
            Intent intent = new Intent(context, typeof(EmpresaCardActivity));
            intent.PutExtra("Empresa", JsonConvert.SerializeObject(empresa));
            context.StartActivity(intent);

        }
    }
}
