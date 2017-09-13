using Foundation;
using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.Styles;
using WorklabsMx.iOS.ViewElements;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Models;
using PerpetualEngine.Storage;

namespace WorklabsMx.iOS
{
    public partial class TarifasController : UIViewController
    {
        UITableView selectView;
        int size, sucursal;
        readonly Dictionary<string, int> Membresias;
        readonly Dictionary<string, CarritoModel> Carrito;
        bool CanPay, Changed;
        readonly SimpleStorage Storage;
        public TarifasController(IntPtr handle) : base(handle)
        {
            Storage = SimpleStorage.EditGroup("Login");
            Membresias = new Dictionary<string, int>();
            Carrito = new CarritoController().GetCarrito(Storage.Get("Usuario_Id"), TiposServicios.Membresia);
            CanPay = false;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {

                foreach (MembresiaModel membresia in new PickerItemsController().GetMembresias())
                {
                    Membresias.Add(membresia.Membresia_Id, 0);
                    if (Carrito.ContainsKey(membresia.Membresia_Id))
                    {
                        Membresias[membresia.Membresia_Id] = (int)Carrito[membresia.Membresia_Id].Producto_Cantidad;
                        CanPay = true;
                    }

                    UIView line = new UIView(new System.Drawing.RectangleF(0, 0, 100, 100))
                    {
                        Frame = new CGRect(0, size, UIScreen.MainScreen.Bounds.Width, 5),
                        BackgroundColor = UIColor.FromRGB(101, 216, 250)
                    };
                    scrollView.AddSubview(line);

                    size += 10;

                    UILabel lblMembresia = new STLLabel(membresia.Membresia_Descripcion, size, 14)
                    {
                        Frame = new CGRect(10, size, UIScreen.MainScreen.Bounds.Width / 2 + 30, 30),
                        Text = membresia.Membresia_Descripcion
                    };
                    scrollView.AddSubview(lblMembresia);
                    UITextField txtCantidad = new UITextField
                    {
                        Text = Carrito.ContainsKey(membresia.Membresia_Id) ? Carrito[membresia.Membresia_Id].Membresia_Cantidad.ToString() : "0",
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 120, size, 30, 30),
                        Font = UIFont.SystemFontOfSize(14),
                        KeyboardType = UIKeyboardType.NumberPad
                    };

                    scrollView.AddSubview(txtCantidad);
                    UIStepper stpMembresia = new UIStepper
                    {
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 100, size, 55, 30),
                        Value = Carrito.ContainsKey(membresia.Membresia_Id) ? Carrito[membresia.Membresia_Id].Membresia_Cantidad : 0,
                        MaximumValue = Convert.ToDouble(membresia.Membresia_Espacios_Disponibles)
                    };
                    stpMembresia.ValueChanged += (sender, e) =>
                    {
                        txtCantidad.Text = stpMembresia.Value.ToString();
                        Membresias[membresia.Membresia_Id] = (int)stpMembresia.Value;
                        CanPay = (stpMembresia.Value > 0);
                        Changed = CanPay;
                    };
                    txtCantidad.EditingChanged += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(txtCantidad.Text))
                        {
                            if (Convert.ToDouble(txtCantidad.Text) > Convert.ToDouble(membresia.Membresia_Espacios_Disponibles))
                            {
                                new MessageDialog().SendMessage("Superaste el tamaño permitido", "Tamaño de " + membresia.Membresia_Descripcion);
                                txtCantidad.Text = membresia.Membresia_Espacios_Disponibles;
                            }
                            stpMembresia.Value = Convert.ToDouble(txtCantidad.Text);
                            Membresias[membresia.Membresia_Id] = (int)stpMembresia.Value;
                            CanPay = (stpMembresia.Value > 0);
                            Changed = CanPay;
                        }
                    };
                    scrollView.AddSubview(stpMembresia);
                    size += 45;
                    UITextField txtSucursal = new STLTextField("Sucursal", size);
                    txtSucursal.EditingDidBegin += (sender, e) =>
                    {
                        selectView = new UIDropdownList(txtSucursal, View);
                    };
                    txtSucursal.EditingDidEnd += (sender, e) =>
                    {
                        sucursal = new SucursalController().GetSucursalId(txtSucursal.Text);
                        selectView.RemoveFromSuperview();
                    };
                    scrollView.AddSubview(txtSucursal);
                    size += 40;
                    scrollView.AddSubview(new STLLabel("Fecha de Inicio", size, 14));
                    size += 40;
                    UIDatePicker dpFechaInicio = new UIDatePicker
                    {
                        Mode = UIDatePickerMode.Date,
                        Frame = new CGRect(40, size, UIScreen.MainScreen.Bounds.Width - 80, 100),
                        Date = (NSDate)DateTime.Now,
                        MinimumDate = (NSDate)DateTime.Now
                    };

                    scrollView.Add(dpFechaInicio);


                    size += 110;
                }
                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, size + 30);
                View.AddSubview(scrollView);
            }
            NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_shopping_cart"), UIBarButtonItemStyle.Plain, (sender, e) =>
            {
                if (CanPay)
                {
                    if (sucursal > 0)
                    {
                        new CarritoController().AddCarrito(Membresias, TiposServicios.Membresia, Storage.Get("Usuario_Id"), sucursal);
                        CarritoCompraController controller = (CarritoCompraController)Storyboard.InstantiateViewController("CarritoCompraController");
                        controller.Title = "Confirmación de pago";
                        NavigationController.PushViewController(controller, true);
                    }
                    else
                        new MessageDialog().SendMessage("Debe de seleccionar alguna sucursal", "Aviso");
                }
                else
                {
                    new MessageDialog().SendMessage("Debe de seleccionar algún producto", "Aviso");
                }
            }), true);
            NavigationItem.SetLeftBarButtonItem(new UIBarButtonItem(UIBarButtonSystemItem.Cancel, (sender, e) =>
            {
                if (Changed)
                {
                    if (sucursal > 0)
                    {
                        new CarritoController().AddCarrito(Membresias, TiposServicios.Membresia, Storage.Get("Usuario_Id"), sucursal);
                        NavigationController.PopViewController(true);
                    }
                    else
                        new MessageDialog().SendMessage("Debe de seleccionar alguna sucursal", "Aviso");
                }
                else
                    NavigationController.PopViewController(true);
            }), true);
        }
    }
}