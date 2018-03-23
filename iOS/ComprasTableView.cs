using System;
using Foundation;
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

        nfloat TamañoHeader = 90;
        nfloat TamañoPie = 66;

        string IdentificadorCeldaHeader = "Header";
        string IdentificadorCeldaPie = "Pie";

        public ComprasTableView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.lblTotal.Text = "Total en carrito: $0.00";

            barButton.Enabled = false;
            this.cvProductos.Hidden = false;
            this.cvMembresias.Hidden = true;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            //this.TableView.RegisterClassForCellReuse(typeof(HeaderCompras), IdentificadorCeldaHeader);
            //this.TableView.RegisterClassForCellReuse(typeof(PieCompras), IdentificadorCeldaPie);
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

       /*public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            
            var headerCell = (HeaderCompras)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            return headerCell.ContentView;
        } 

        public override UIView GetViewForFooter(UITableView tableView, nint section)
        {
            var headerCell = (PieCompras)tableView.DequeueReusableCell(IdentificadorCeldaPie);
            return headerCell.ContentView;
        }
       
        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return TamañoHeader;
        }

        public override nfloat GetHeightForFooter(UITableView tableView, nint section)
        {
            return TamañoPie;
        }*/

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
                VistaDetalleMembresia.MembresiaDelegate = this;
            }
            else if (segue.Identifier == "DetalleCompra")
            {
                var VistaDetalleCompra = (VentaDetalleTableViewController)segue.DestinationViewController;
                VistaDetalleCompra.PreordenProductos = this.PreordenProductos;
            }
        }

        partial void btnAtras_Touch(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }

        partial void btnCarrito_Touch(UIBarButtonItem sender)
        {
            this.PerformSegue("DetalleCompra", null);
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

    public partial class ComprasTableView : DetalleCompraInterface
    {
        public void ArticuloSeleccionado(CarritoCompras Preorden)
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