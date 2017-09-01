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
    [Activity(Label = "MembresiasActivity")]
    public class MembresiasActivity : Activity
    {
        bool CanPay;
        SimpleStorage Storage;
        readonly Dictionary<string, int> Membresias;
        readonly Dictionary<string, CarritoModel> Carrito;
        public MembresiasActivity()
        {
            Storage = SimpleStorage.EditGroup("Login");
            Membresias = new Dictionary<string, int>();
            Carrito = new CarritoController().GetCarrito(Storage.Get("Usuario_Id"), "Membresia");
            CanPay = false;
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MembresiasLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Membresias);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

            Spinner txtSucursales = FindViewById<Spinner>(Resource.Id.spSucursal);
            txtSucursales.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, new SucursalController().GetSucursalNombres().ToArray());
            FillData();
        }

        void FillData()
        {
            TableLayout tlMembresias = FindViewById<TableLayout>(Resource.Id.tlMembresias);
            foreach (MembresiaModel membresia in new PickerItemsController().GetMembresias())
            {
                Membresias.Add(membresia.Membresia_Id, 0);
                if (Carrito.ContainsKey(membresia.Membresia_Id))
                {
                    Membresias[membresia.Membresia_Id] = (int)Carrito[membresia.Membresia_Id].Membresia_Cantidad;
                    CanPay = true;
                }

                TableRow trMembresia = new TableRow(this);

                TextView lblNombre = new TextView(this)
                {
                    Text = membresia.Membresia_Descripcion,
                    TextSize = 14
                };
                lblNombre.SetMaxWidth(Resources.DisplayMetrics.WidthPixels * 2 / 3);
                trMembresia.AddView(lblNombre, 0);

                EditText txtCantidadMembresias = new EditText(this)
                {
                    Text = Carrito.ContainsKey(membresia.Membresia_Id) ? Carrito[membresia.Membresia_Id].Membresia_Cantidad.ToString() : "0",
                    TextSize = 14,
                    InputType = Android.Text.InputTypes.NumberFlagSigned
                };
                txtCantidadMembresias.SetMaxWidth(70);
                txtCantidadMembresias.SetFadingEdgeLength(2);
                txtCantidadMembresias.TextChanged += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(txtCantidadMembresias.Text))
                        if (Convert.ToInt32(txtCantidadMembresias.Text) >= 0)
                            Membresias[membresia.Membresia_Id] = Convert.ToInt32(txtCantidadMembresias.Text);
                };

                trMembresia.AddView(txtCantidadMembresias, 1);

                ImageButton btnPlus = new ImageButton(this);
                btnPlus.SetImageResource(Resource.Mipmap.ic_add);
                btnPlus.Click += (sender, e) =>
                {
                    ++Membresias[membresia.Membresia_Id];

                    txtCantidadMembresias.Text = Membresias[membresia.Membresia_Id].ToString();
                };

                trMembresia.AddView(btnPlus, 2);

                ImageButton btnLess = new ImageButton(this);
                btnLess.SetImageResource(Resource.Mipmap.ic_remove);
                btnLess.Click += (sender, e) =>
                {
                    if (Membresias[membresia.Membresia_Id] > 0)
                    {
                        --Membresias[membresia.Membresia_Id];
                        txtCantidadMembresias.Text = Membresias[membresia.Membresia_Id].ToString();
                    }
                };

                trMembresia.AddView(btnLess, 3);

                tlMembresias.AddView(trMembresia);
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
                        intent.PutExtra("Datos", "{" + string.Join(",", Membresias.Select(d => string.Format("\"{0}\": {1}", d.Key, string.Join(",", d.Value)))) + "}");
                        intent.PutExtra("Tipo", false);
                        StartActivity(intent);
                    }
                    Toast.MakeText(this, Resource.String.NoSeleccionMembresia, ToastLength.Short);
                    break;
                default:
                    base.OnBackPressed();
                    break;
            }

            return base.OnOptionsItemSelected(item);
        }
    }
}