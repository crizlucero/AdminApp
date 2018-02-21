using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ComprasActivity : Activity
    {
        GridLayout gvElementos;
        ArrayAdapter adapter;
        List<ProductoModel> productos;
        List<MembresiaModel> membresias;
        public ComprasActivity()
        {
            productos = new PickerItemsController().GetProductos();
            membresias = new PickerItemsController().GetMembresias();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ComprasLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_shop);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            gvElementos = FindViewById<GridLayout>(Resource.Id.glCompras);
            RadioButton rbProductos = FindViewById<RadioButton>(Resource.Id.btnProductos);
            RadioButton rbMembresias = FindViewById<RadioButton>(Resource.Id.btnMembresias);
            adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, new SucursalController().GetSucursalNombres().ToArray());
            if (rbProductos.Checked)
            {
                //rbProductos.SetBackgroundResource(Resource.Color.switch_selected);//.SetBackgroundResource(Resource.Drawable.switch_style_toggle);
                FillProductos();
            }
            else
            {
                rbMembresias.SetBackgroundResource(Resource.Drawable.switch_style_toggle);
                FillMembresias();
            }
            FindViewById<RadioGroup>(Resource.Id.rgCompras).CheckedChange += delegate
            {
                if (rbProductos.Checked)
                    FillProductos();
                else
                    FillMembresias();
            };
        }
        void FillProductos()
        {
            gvElementos.RemoveAllViews();
            productos.ForEach(elemento =>
            {
                LayoutInflater liView = LayoutInflater;
                View view = liView.Inflate(Resource.Layout.CompraElementoLayout, null, true);
                Button btnElemento = view.FindViewById<Button>(Resource.Id.btnElemento);
                btnElemento.Text = elemento.Producto_Descripcion;
                btnElemento.Click += delegate
                {
                    SetContentView(Resource.Layout.CompraCardLayout);
                    Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                    SetActionBar(toolbar);
                    ActionBar.Title = elemento.Producto_Descripcion;
                    ActionBar.SetDisplayHomeAsUpEnabled(true);
                    FindViewById<TextView>(Resource.Id.lblNombre).Text = elemento.Producto_Descripcion;
                    FindViewById<TextView>(Resource.Id.lblPrecio).Text = "$ " + elemento.Producto_Precio_Base.ToString() + " M/N";
                    Spinner spSucursales = FindViewById<Spinner>(Resource.Id.spSucursal);
                    spSucursales.Adapter = adapter;
                    FindViewById<ImageView>(Resource.Id.btnClose).Click += delegate
                    {
                        OnCreate(null);
                    };
                };
                gvElementos.AddView(view);
            });
        }
        void FillMembresias()
        {
            gvElementos.RemoveAllViews();
            membresias.ForEach(elemento =>
            {
                LayoutInflater liView = LayoutInflater;
                View view = liView.Inflate(Resource.Layout.CompraElementoLayout, null, true);
                Button btnElemento = view.FindViewById<Button>(Resource.Id.btnElemento);
                btnElemento.Text = elemento.Membresia_Descripcion;
                btnElemento.Click += delegate
                {
                    SetContentView(Resource.Layout.CompraCardLayout);
                    SetContentView(Resource.Layout.CompraCardLayout);
                    Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                    SetActionBar(toolbar);
                    ActionBar.Title = elemento.Membresia_Descripcion;
                    ActionBar.SetDisplayHomeAsUpEnabled(true);
                    FindViewById<TextView>(Resource.Id.lblNombre).Text = elemento.Membresia_Descripcion;
                    FindViewById<TextView>(Resource.Id.lblPrecio).Text = "$ " + elemento.Membresia_Precio_Base.ToString() + " M/N";
                    Spinner spSucursales = FindViewById<Spinner>(Resource.Id.spSucursal);
                    spSucursales.Adapter = adapter;
                    FindViewById<ImageView>(Resource.Id.btnClose).Click += delegate
                    {
                        OnCreate(null);
                    };
                };
                gvElementos.AddView(view);
            });
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.shopping_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_cart:
                    if (productos.Count != 0 || membresias.Count != 0)
                    {
                        Intent intent = new Intent(this, typeof(ShoppingCartActivity));
                        intent.PutExtra("Productos", JsonConvert.SerializeObject(productos));
                        intent.PutExtra("Membresias", JsonConvert.SerializeObject(membresias));
                        StartActivity(intent);
                    }
                    else
                        Toast.MakeText(this, "Debe seleccionar algún producto o membresía", ToastLength.Short).Show();
                    break;
                default:
                    StartActivity(new Intent(this, typeof(MainActivity)));
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}