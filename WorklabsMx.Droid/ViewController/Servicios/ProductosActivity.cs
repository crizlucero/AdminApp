using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/Productos")]
    public class ProductosActivity : Activity
    {
        readonly Dictionary<string, int> Productos;
        readonly Dictionary<string, CarritoModel> Carrito;
        bool CanPay;
        SimpleStorage Storage;
        public ProductosActivity()
        {
            Storage = SimpleStorage.EditGroup("Login");
            Productos = new Dictionary<string, int>();
            CanPay = false;
            Carrito = new CarritoController().GetCarrito(Storage.Get("Usuario_Id"), TiposServicios.Producto);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ProductosLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Productos);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

            Spinner txtSucursales = FindViewById<Spinner>(Resource.Id.spSucursal);
            txtSucursales.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, new SucursalController().GetSucursalNombres().ToArray());
            FillData();
        }

        void FillData()
        {
            TableLayout tlProductos = FindViewById<TableLayout>(Resource.Id.tlProductos);
            foreach (ProductoModel producto in new PickerItemsController().GetProductos())
            {
                Productos.Add(producto.Producto_Id, 0);
                if (Carrito.ContainsKey(producto.Producto_Id))
                {
                    Productos[producto.Producto_Id] = (int)Carrito[producto.Producto_Id].Producto_Cantidad;
                    CanPay = true;
                }

                TableRow trProducto = new TableRow(this);

                TextView lblNombre = new TextView(this)
                {
                    Text = producto.Producto_Descripcion,
                    TextSize = 14
                };
                lblNombre.SetMaxWidth(Resources.DisplayMetrics.WidthPixels * 2 / 3);
                trProducto.AddView(lblNombre, 0);

                EditText txtCantidadProductos = new EditText(this)
                {
                    Text = Carrito.ContainsKey(producto.Producto_Id) ? Carrito[producto.Producto_Id].Producto_Cantidad.ToString() : "0",
                    TextSize = 14,
                    InputType = Android.Text.InputTypes.NumberFlagSigned
                };
                txtCantidadProductos.SetMaxWidth(70);
                txtCantidadProductos.SetFadingEdgeLength(2);
                txtCantidadProductos.TextChanged += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(txtCantidadProductos.Text))
                        if (Convert.ToInt32(txtCantidadProductos.Text) >= 0)
                            Productos[producto.Producto_Id] = Convert.ToInt32(txtCantidadProductos.Text);
                };

                trProducto.AddView(txtCantidadProductos, 1);

                ImageButton btnPlus = new ImageButton(this)
                {
                };
                btnPlus.SetImageResource(Resource.Mipmap.ic_add);
                btnPlus.Click += (sender, e) =>
                {
                    ++Productos[producto.Producto_Id];

                    txtCantidadProductos.Text = Productos[producto.Producto_Id].ToString();
                };

                trProducto.AddView(btnPlus, 2);

                ImageButton btnLess = new ImageButton(this)
                {

                };
                btnLess.SetImageResource(Resource.Mipmap.ic_remove);
                btnLess.Click += (sender, e) =>
                {
                    if (Productos[producto.Producto_Id] > 0)
                    {
                        --Productos[producto.Producto_Id];
                        txtCantidadProductos.Text = Productos[producto.Producto_Id].ToString();
                    }
                };

                trProducto.AddView(btnLess, 3);

                tlProductos.AddView(trProducto);
            }
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
                    if (CanPay)
                    {
                        Intent intent = new Intent(this, typeof(ShoppingCartActivity));
                        intent.PutExtra("Datos", "{" + string.Join(",", Productos.Select(d => string.Format("\"{0}\": {1}", d.Key, string.Join(",", d.Value)))) + "}");
                        intent.PutExtra("Tipo", true);
                        StartActivity(intent);
                    }
                    Toast.MakeText(this, Resource.String.NoSeleccionProducto, ToastLength.Short);
                    break;
                default:
                    base.OnBackPressed();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}
