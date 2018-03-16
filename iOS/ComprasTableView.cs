using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using BigTed;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Models;
using SWRevealViewControllerBinding;

namespace WorklabsMx.iOS
{
    public partial class ComprasTableView : UITableViewController
    {
        MembresiaModel MemebresiaSelect = new MembresiaModel();
        ProductoModel ProductoSelect = new ProductoModel();
        UIBarButtonItem barButton = new UIBarButtonItem();
        public List<CarritoCompras> PreordenProductos = new List<CarritoCompras>();

        public ComprasTableView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            barButton.Enabled = false;
            this.cvProductos.Hidden = false;
            this.cvMembresias.Hidden = true;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        partial void sclCompras_Changed(UISegmentedControl sender)
        {
            if (sclCompras.SelectedSegment == 0)
            {
                this.cvProductos.Hidden = false;
                this.cvMembresias.Hidden = true;
            }
            else
            {
                this.cvProductos.Hidden = true;
                this.cvMembresias.Hidden = false;
            }
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "Productos")
            {
                var VistaColeccionProductos = (ColeccionProductos)segue.DestinationViewController;
                VistaColeccionProductos.allProducts = MenuHelper.Productos;
                VistaColeccionProductos.ProductosDelegate = this;

            }
            else if (segue.Identifier == "Membresias")
            {
                var VistaColeccionMembresias = (ColeccionMembresias)segue.DestinationViewController;
                VistaColeccionMembresias.allMembresias = MenuHelper.Membresias;
                VistaColeccionMembresias.MembresiasDelegate = this;
            }
            else if (segue.Identifier == "VerProducto")
            {
                var VistaDetalleProducto = (DetalleProductoTableViewController)segue.DestinationViewController.ChildViewControllers[0];
                VistaDetalleProducto.Prodcuto = this.ProductoSelect;
                VistaDetalleProducto.ProductosDelegate = this;

            }
            else if (segue.Identifier == "VerMembresia")
            {
                var VistaDetalleMembresia = (DetalleMembresiaTableVieController)segue.DestinationViewController.ChildViewControllers[0];
                VistaDetalleMembresia.Membresia = this.MemebresiaSelect;
            }
        }

        partial void btnAtras_Touch(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }

        partial void btnCarrito_Touch(UIBarButtonItem sender)
        {
        }
    }

    public partial class ComprasTableView : ColeccionProductosInt
    {

        public void ProductoSeleccionado(ProductoModel ProductoSeleccionado)
        {
            this.ProductoSelect = ProductoSeleccionado;
            this.PerformSegue("VerProducto", null);
        }
    }


    public partial class ComprasTableView : ColeccionMembresiasInt
    {

        public void MembresiaSeleccionada(MembresiaModel MembresiaSeleccionada)
        {
            this.MemebresiaSelect = MembresiaSeleccionada;
            this.PerformSegue("VerMembresia", null);
        }
    }

    public partial class ComprasTableView : DetalleProductoInterface
    {
        public void ProductoSeleccionado(CarritoCompras Preorden)
        {
            this.PreordenProductos.Add(Preorden);
            int ContadorProductos = 0;
            double TotalPagar = 0;
            foreach(CarritoCompras Orden in PreordenProductos)
            {
                TotalPagar = TotalPagar + double.Parse(Orden.TotalPagar.Remove(0, 1));
                ContadorProductos = ContadorProductos + Orden.Cantidad;
            }
            this.lblTotal.Text = "Total en carrito: $" + TotalPagar.ToString();
            barButton.Title = ContadorProductos.ToString();

        }
    }
            

}