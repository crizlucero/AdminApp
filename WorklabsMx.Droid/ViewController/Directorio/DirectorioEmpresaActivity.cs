using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using WorklabsMx.Controllers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class DirectorioEmpresaActivity : Activity
    {
        ScrollView svDirectorio;
        EmpresaController CompanyController;
        public DirectorioEmpresaActivity()
        {
            CompanyController = new EmpresaController();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Directorio();

        }

        void Directorio(string nombre = "", string pais = "", string estado = "", string municipio = "", string giro = "")
        {
            SetContentView(Resource.Layout.DirectorioLayout);
            SetTitle(Resource.String.DirectorioEmpresas);

            svDirectorio = FindViewById<ScrollView>(Resource.Id.svDirectorio);
            FillDirectorioUsuario(nombre, pais, estado, municipio, giro);
        }

        void FillDirectorioUsuario(string nombre = "", string pais = "", string estado = "", string municipio = "", string giro = "")
        {
            LinearLayout llDirectorio = new LinearLayout(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                Orientation = Orientation.Vertical
            };
            string aux = "";
            CompanyController.GetDirectorioEmpresas(nombre, pais, estado, municipio, giro).ForEach((empresa) =>
            {
                if (empresa.Empresa_Miembro_Nombre[0].ToString() != aux)
                {
                    LinearLayout llList = new LinearLayout(this);
                    llList.SetBackgroundColor(Color.Rgb(149, 214, 255));
                    TextView lblCapital = new TextView(this);
                    LinearLayout.LayoutParams ll = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
                    ll.LeftMargin = 50;
                    lblCapital.LayoutParameters = ll;
                    aux = empresa.Empresa_Miembro_Nombre[0].ToString();
                    lblCapital.Text = aux;

                    llList.AddView(lblCapital);
                    llDirectorio.AddView(llList);
                }
                LayoutInflater liView = LayoutInflater;

                View PersonaCard = liView.Inflate(Resource.Layout.PreViewListLayout, null, true);

                ImageButton ibProfile = PersonaCard.FindViewById<ImageButton>(Resource.Id.ibProfile);

                TextView lblNombre = PersonaCard.FindViewById<TextView>(Resource.Id.lblTitle);

                lblNombre.Text = empresa.Empresa_Miembro_Nombre;

                llDirectorio.AddView(PersonaCard);

            });
            svDirectorio.AddView(llDirectorio);
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
            SetContentView(Resource.Layout.SearchCompanyLayout);


            FindViewById<ImageButton>(Resource.Id.btnClear).Click += (sender, e) =>
            {
                Directorio();
            };

            FindViewById<Button>(Resource.Id.btnBuscar).Click += (sender, e) =>
            {
                Directorio(FindViewById<TextView>(Resource.Id.txtNombre).Text, FindViewById<TextView>(Resource.Id.txtPais).Text,
                           FindViewById<TextView>(Resource.Id.txtEstado).Text, FindViewById<TextView>(Resource.Id.txtMunicipio).Text,
                           FindViewById<TextView>(Resource.Id.txtGiroComercial).Text);
            };
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.DirectorioEmpresas);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
        }
    }
}