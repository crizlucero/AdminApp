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
        int size = 30;
        readonly Dictionary<string, int> Membresias;
        readonly Dictionary<string, CarritoModel> Carrito;
        public string test;
        bool CanPay;
        SimpleStorage Storage;
        public TarifasController(IntPtr handle) : base(handle)
        {
            Storage = SimpleStorage.EditGroup("Login");
            Membresias = new Dictionary<string, int>();
            Carrito = new CarritoController().GetCarrito(Storage.Get("Usuario_Id"), "Membresia");
            CanPay = false;
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {
                UITextField txtSucursal = new STLTextField("Sucursal", 30);
                txtSucursal.EditingDidBegin += (sender, e) =>
                {
                    selectView = new UIDropdownList(txtSucursal, View);
                };
                txtSucursal.EditingDidEnd += (sender, e) =>
                {
                    selectView.RemoveFromSuperview();
                };
                scrollView.AddSubview(txtSucursal);

                foreach (MembresiaModel membresia in new PickerItemsController().GetMembresias())
                {
                    Membresias.Add(membresia.Membresia_Id, 0);
                    if (Carrito.ContainsKey(membresia.Membresia_Id))
                    {
                        Membresias[membresia.Membresia_Id] = (int)Carrito[membresia.Membresia_Id].Producto_Cantidad;
                        CanPay = true;
                    }

                    size += 40;

                    UILabel lblMembresia = new UILabel
                    {
                        Frame = new CGRect(10, size, UIScreen.MainScreen.Bounds.Width / 2 + 30, 30),
                        Text = membresia.Membresia_Descripcion,
                        Font = UIFont.SystemFontOfSize(14)
                    };
                    lblMembresia.Font.WithSize(12);
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
                        }
                    };
                    scrollView.AddSubview(stpMembresia);
                }
                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, size + 30);
                View.AddSubview(scrollView);
            }
            NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_shopping_cart"), UIBarButtonItemStyle.Plain, (sender, e) =>
            {
                if (CanPay)
                {
                    CarritoCompraController controller = (CarritoCompraController)Storyboard.InstantiateViewController("CarritoCompraController");
                    controller.Title = "Confirmación de pago";
                    controller.membresias = Membresias;
                    NavigationController.PushViewController(controller, true);
                }
                else
                {
                    new MessageDialog().SendMessage("Debe de seleccionar algún producto", "Aviso");
                }
            }), true);
        }
    }
}