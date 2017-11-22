using System;
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
    [Activity(Label = "@string/app_name")]
    public class MyMembershipActivity : Activity
    {
        SimpleStorage Storage;
        public MyMembershipActivity()
        {
            Storage = SimpleStorage.EditGroup("Login");
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ProductosLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Productos);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            FindViewById<ImageButton>(Resource.Id.btnProductos).Click += delegate
            {
                FindViewById<TableLayout>(Resource.Id.tlProductos).RemoveAllViews();
                FillDataProductos();
            };

            FindViewById<ImageButton>(Resource.Id.btnMembresias).Click += delegate
            {
                FindViewById<TableLayout>(Resource.Id.tlProductos).RemoveAllViews();
                FillDataMembresias();
            };

            FillDataProductos();
        }

        void FillDataMembresias()
        {
            TableLayout tlMembresias = FindViewById<TableLayout>(Resource.Id.tlProductos);
            new PickerItemsController().GetMembresias().ForEach(membresia =>
            {
                TableRow trMembresia = new TableRow(this);
                View line = new View(this);
                line.SetBackgroundColor(Android.Graphics.Color.Cyan);
                line.LayoutParameters = new TableRow.LayoutParams(ViewGroup.LayoutParams.MatchParent, 5);

                trMembresia.AddView(line);
                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                TextView lblNombre = new TextView(this)
                {
                    Text = membresia.Membresia_Descripcion,
                    TextSize = 14
                };
                lblNombre.SetMaxWidth(Resources.DisplayMetrics.WidthPixels * 2 / 3);
                trMembresia.AddView(lblNombre, 0);

                TextView txtCantidadMembresias = new TextView(this)
                {
                    Text = "1",//[membresia.Membresia_Id].Membresia_Cantidad.ToString(),
                    TextSize = 14,
                    InputType = Android.Text.InputTypes.NumberFlagSigned
                };
                //txtCantidadMembresias.SetMaxWidth(70);
                txtCantidadMembresias.SetFadingEdgeLength(2);

                trMembresia.AddView(txtCantidadMembresias, 1);

                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Fecha de vencimiento" }, 0);

                TextView txtFechaVencimiento = new TextView(this)
                {
                    Text = DateTime.Now.ToString("d"),//[membresia.Membresia_Id].Membresia_Cantidad.ToString(),
                    TextSize = 14,
                    InputType = Android.Text.InputTypes.NumberFlagSigned
                };
                //txtFechaVencimiento.SetMaxWidth(70);
                txtFechaVencimiento.SetFadingEdgeLength(2);

                trMembresia.AddView(txtFechaVencimiento, 1);
                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Cantidad de meses" }, 0);

                TextView txtMesesMembresias = new TextView(this)
                {
                    Text = "1"
                };
                //txtMesesMembresias.SetMaxWidth(70);
                txtMesesMembresias.SetFadingEdgeLength(2);

                trMembresia.AddView(txtMesesMembresias, 1);

                tlMembresias.AddView(trMembresia);
            });
        }

        void FillDataProductos()
        {
            TableLayout tlProductos = FindViewById<TableLayout>(Resource.Id.tlProductos);
            new PickerItemsController().GetProductos().ForEach((producto) =>
            {
                TableRow trProducto = new TableRow(this);
                View line = new View(this);
                line.SetBackgroundColor(Android.Graphics.Color.Cyan);
                line.LayoutParameters = new TableRow.LayoutParams(ViewGroup.LayoutParams.MatchParent, 5);

                trProducto.AddView(line);
                tlProductos.AddView(trProducto);

                trProducto = new TableRow(this);

                TextView lblNombre = new TextView(this)
                {
                    Text = producto.Producto_Descripcion,
                    TextSize = 14
                };
                lblNombre.SetMaxWidth(Resources.DisplayMetrics.WidthPixels * 2 / 3);
                trProducto.AddView(lblNombre, 0);

                TextView txtCantidadProductos = new TextView(this)
                {
                    Text = "1",//Productos[producto.Producto_Id].Producto_Cantidad.ToString(),
                    TextSize = 14,
                    InputType = Android.Text.InputTypes.NumberFlagSigned
                };
                //txtCantidadProductos.SetMaxWidth(70);
                txtCantidadProductos.SetFadingEdgeLength(2);


                trProducto.AddView(txtCantidadProductos, 1);
                tlProductos.AddView(trProducto);

                trProducto = new TableRow(this);
                trProducto.AddView(new TextView(this) { Text = "Tarifa Mensual" });

                trProducto.AddView(new TextView(this) { Text = producto.Producto_Precio_Base_Neto.ToString("C") });

                tlProductos.AddView(trProducto);

                trProducto = new TableRow(this);
                /*Spinner spSucursales = new Spinner(this)
                {
                    Adapter = adapter
                };
                trProducto.AddView(spSucursales);
                tlProductos.AddView(trProducto);*/

                if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                {
                    trProducto = new TableRow(this);
                    trProducto.AddView(new TextView(this) { Text = "Fecha de inicio" }, 0);
                    TextView txtFechaVencimiento = new TextView(this)
                    {
                        Text = DateTime.Now.ToString("d"),//[membresia.Membresia_Id].Membresia_Cantidad.ToString(),
                        TextSize = 14,
                        InputType = Android.Text.InputTypes.NumberFlagSigned
                    };
                    //txtFechaVencimiento.SetMaxWidth(70);
                    txtFechaVencimiento.SetFadingEdgeLength(2);
                    trProducto.AddView(txtFechaVencimiento, 1);
                    tlProductos.AddView(trProducto);

                    trProducto = new TableRow(this);
                    trProducto.AddView(new TextView(this) { Text = "Cantidad de meses" }, 0);

                    TextView txtMesesProductos = new TextView(this)
                    {
                        Text = "1"
                    };
                    //txtMesesProductos.SetMaxWidth(70);
                    txtMesesProductos.SetFadingEdgeLength(2);
                    trProducto.AddView(txtMesesProductos, 1);

                    tlProductos.AddView(trProducto);


                }
            });
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            //MenuInflater.Inflate(Resource.Menu.shopping_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            base.OnBackPressed();
            return base.OnOptionsItemSelected(item);
        }
    }
}
