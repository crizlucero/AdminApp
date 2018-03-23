using System;
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
        List<ProductoModel> productosLista;
        List<MembresiaModel> membresiasLista;
        Dictionary<string, CarritoModel> Productos, Membresias;
        TextView lblTotal;
        double totalCompra;
        bool flag;
        public ComprasActivity()
        {
            productosLista = new PickerItemsController().GetProductos();
            membresiasLista = new PickerItemsController().GetMembresias();
            Productos = new Dictionary<string, CarritoModel>();
            Membresias = new Dictionary<string, CarritoModel>();
            productosLista.ForEach(producto =>
            {
                if (!Productos.ContainsKey(producto.Producto_Id))
                    Productos.Add(producto.Producto_Id, new CarritoModel
                    {
                        Producto_Cantidad = 0,
                        Sucursal_Id = 1,
                        Membresia_Fecha_Inicio = DateTime.Now.ToString("d"),
                        Meses_Adelantados = 1,
                        Lista_Precio_Id = producto.Lista_Precio_Id,
                        Impuesto_Id = producto.Moneda_Id,
                        Moneda_Id = producto.Moneda_Id,
                        Tipo = producto.Producto_Disponibilidad,
                        Precio_Base = producto.Producto_Precio_Base_Neto.ToString()
                    });
            });
            membresiasLista.ForEach(membresia =>
            {
                if (!Membresias.ContainsKey(membresia.Membresia_Id))
                    Membresias.Add(membresia.Membresia_Id, new CarritoModel
                    {
                        Membresia_Cantidad = 0,
                        Sucursal_Id = 0,
                        Meses_Adelantados = 1,
                        Membresia_Fecha_Inicio = DateTime.Now.ToString("d"),
                        Lista_Precio_Id = membresia.Lista_Precio_Id,
                        Moneda_Id = membresia.Moneda_Id,
                        Impuesto_Id = membresia.Impuesto_Id,
                        Precio_Base = membresia.Membresia_Precio_Base_Neto.ToString()
                    });
            });
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ComprasLayout);
            flag = false;
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_shop);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            gvElementos = FindViewById<GridLayout>(Resource.Id.glCompras);
            RadioButton rbProductos = FindViewById<RadioButton>(Resource.Id.btnProductos);
            RadioButton rbMembresias = FindViewById<RadioButton>(Resource.Id.btnMembresias);
            productosLista.ForEach(producto =>
            {
                totalCompra += producto.Producto_Precio_Base_Neto * Productos[producto.Producto_Id].Producto_Cantidad;
            });
            membresiasLista.ForEach(membresia =>
            {
                totalCompra += (membresia.Membresia_Precio_Base_Neto * Membresias[membresia.Membresia_Id].Membresia_Cantidad) +
                    (membresia.Inscripcion_Precio_Base_Neto * Membresias[membresia.Membresia_Id].Membresia_Cantidad);
            });
            lblTotal = FindViewById<TextView>(Resource.Id.lblTotal);
            lblTotal.Text = totalCompra.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));

            adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, new SucursalController().GetSucursalNombres().ToArray());
            if (rbProductos.Checked)
            {
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
            new PickerItemsController().GetProductos().ForEach(elemento =>
            {
                LayoutInflater liView = LayoutInflater;
                View view = liView.Inflate(Resource.Layout.CompraElementoLayout, null, true);
                Button btnElemento = view.FindViewById<Button>(Resource.Id.btnElemento);
                btnElemento.Text = elemento.Producto_Descripcion;
                btnElemento.Click += delegate
                {
                    SetContentView(Resource.Layout.CompraCardLayout);
                    Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                    int cantidad = 1;
                    SetActionBar(toolbar);
                    ActionBar.Title = elemento.Producto_Descripcion;
                    ActionBar.SetDisplayHomeAsUpEnabled(true);
                    FindViewById<TextView>(Resource.Id.lblNombre).Text = elemento.Producto_Descripcion;
                    FindViewById<TextView>(Resource.Id.lblPrecio).Text = GetString(Resource.String.str_shop_numeric_mn, elemento.Producto_Precio_Base.ToString());

                    EditText ProductoCantidad = FindViewById<EditText>(Resource.Id.txtCantidad);
                    FindViewById<ImageView>(Resource.Id.imgMas).Click += delegate
                    {
                        cantidad++;
                        ProductoCantidad.Text = cantidad.ToString();
                    };
                    FindViewById<ImageView>(Resource.Id.imgMenos).Click += delegate
                    {
                        if (cantidad != 0)
                        {
                            cantidad--;
                            ProductoCantidad.Text = cantidad.ToString();
                        }
                    };

                    Spinner spSucursales = FindViewById<Spinner>(Resource.Id.spSucursal);
                    spSucursales.Adapter = adapter;
                    FindViewById<ImageView>(Resource.Id.btnClose).Click += delegate
                    {
                        OnCreate(null);
                    };
                    FindViewById<Button>(Resource.Id.btnAdd).Click += delegate
                    {
                        Productos[elemento.Producto_Id].Producto_Cantidad = cantidad;
                        OnCreate(null);
                    };
                };
                gvElementos.AddView(view);
            });
        }
        void FillMembresias()
        {
            gvElementos.RemoveAllViews();
            new PickerItemsController().GetMembresias().ForEach(elemento =>
            {
                LayoutInflater liView = LayoutInflater;
                View view = liView.Inflate(Resource.Layout.CompraElementoLayout, null, true);
                Button btnElemento = view.FindViewById<Button>(Resource.Id.btnElemento);
                btnElemento.Text = elemento.Membresia_Descripcion;
                btnElemento.Click += delegate
                {
                    SetContentView(Resource.Layout.CompraCardLayout);
                    flag = true;
                    Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                    SetActionBar(toolbar);
                    int cantidad = 1;
                    ActionBar.Title = elemento.Membresia_Descripcion;
                    ActionBar.SetDisplayHomeAsUpEnabled(true);
                    FindViewById<TextView>(Resource.Id.lblNombre).Text = elemento.Membresia_Descripcion;
                    FindViewById<TextView>(Resource.Id.lblPrecio).Text = GetString(Resource.String.str_shop_numeric_mn, elemento.Membresia_Precio_Base.ToString());
                    EditText MembresiaCantidad = FindViewById<EditText>(Resource.Id.txtCantidad);
                    FindViewById<ImageView>(Resource.Id.imgMas).Click += delegate
                    {
                        cantidad++;
                        MembresiaCantidad.Text = cantidad.ToString();
                    };
                    FindViewById<ImageView>(Resource.Id.imgMenos).Click += delegate
                    {
                        if (cantidad != 0)
                        {
                            cantidad--;
                            MembresiaCantidad.Text = cantidad.ToString();
                        }
                    };
                    Spinner spSucursales = FindViewById<Spinner>(Resource.Id.spSucursal);
                    spSucursales.Adapter = adapter;
                    FindViewById<ImageView>(Resource.Id.btnClose).Click += delegate
                    {
                        OnCreate(null);
                    };
                    FindViewById<Button>(Resource.Id.btnAdd).Click += delegate
                    {
                        Membresias[elemento.Membresia_Id].Membresia_Cantidad = cantidad;
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
                    if (Math.Abs(totalCompra) > 0)
                    {
                        Intent intent = new Intent(this, typeof(ShoppingCartActivity));
                        intent.PutExtra("Productos", JsonConvert.SerializeObject(Productos));
                        intent.PutExtra("Membresias", JsonConvert.SerializeObject(Membresias));
                        StartActivity(intent);
                    }
                    else
                        Toast.MakeText(this, Resources.GetString(Resource.String.str_shop_products_selected_error), ToastLength.Short).Show();
                    break;
                default:
                    StartActivity(new Intent(this, typeof(MainActivity)));
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
        void AddProductoCarrito()
        {

        }

		public override void OnBackPressed()
		{
            if (flag)
                OnCreate(null);
            else
            {
                StartActivity(new Intent(this, typeof(MainActivity)));
                Finish();
            }
		}
	}
}