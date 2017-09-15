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
        int size;
        readonly Dictionary<string, CarritoModel> Carrito, Membresias;
        bool CanPay, Changed;
        readonly SimpleStorage Storage;
        public TarifasController(IntPtr handle) : base(handle)
        {
            Storage = SimpleStorage.EditGroup("Login");
            Membresias = new Dictionary<string, CarritoModel>();
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
                    double subtotal = membresia.Membresia_Precio_Base;

                    Membresias.Add(membresia.Membresia_Id, new CarritoModel
                    {
                        Membresia_Cantidad = 0,
                        Sucursal_Id = 0
                    });
                    if (Carrito.ContainsKey(membresia.Membresia_Id))
                    {
                        Membresias[membresia.Membresia_Id].Membresia_Cantidad = (int)Carrito[membresia.Membresia_Id].Membresia_Cantidad;
                        Membresias[membresia.Membresia_Id].Sucursal_Id = Carrito[membresia.Membresia_Id].Sucursal_Id;
                        Membresias[membresia.Membresia_Id].Membresia_Fecha_Inicio = Carrito[membresia.Membresia_Id].Membresia_Fecha_Inicio;
                        CanPay = true;
                    }

                    scrollView.AddSubview(new STLLine());

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

                    scrollView.AddSubview(stpMembresia);
                    size += 45;
                    ///
                    scrollView.AddSubview(new STLLabel("Tarifa Mensual", size));
                    scrollView.AddSubview(new STLLabel(membresia.Membresia_Precio_Base.ToString("C"))
                    {
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 2 / 3, size, UIScreen.MainScreen.Bounds.Width / 4, 30)
                    });
                    size += 45;
                    scrollView.AddSubview(new STLLabel("Tarifa Inscripción", size));
                    scrollView.AddSubview(new STLLabel(membresia.Membresia_Precio_Base.ToString("C"))
                    {
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 2 / 3, size, UIScreen.MainScreen.Bounds.Width / 4, 30)
                    });
                    ///
                    size += 45;
                    UITextField txtSucursal = new STLTextField("Sucursal", size)
                    {
                        Text = Carrito.ContainsKey(membresia.Membresia_Id) ? Carrito[membresia.Membresia_Id].Sucursal_Descripcion : ""
                    };
                    txtSucursal.EditingDidBegin += (sender, e) =>
                    {
                        selectView = new UIDropdownList(txtSucursal, View);
                    };
                    txtSucursal.EditingDidEnd += (sender, e) =>
                    {
                        Membresias[membresia.Membresia_Id].Sucursal_Id = new SucursalController().GetSucursalId(txtSucursal.Text);
                        selectView.RemoveFromSuperview();
                    };
                    scrollView.AddSubview(txtSucursal);
                    size += 40;
                    scrollView.AddSubview(new STLLabel("Fecha de Inicio", size, 14));
                    size += 30;

                    UIDatePicker dpFechaInicio = new UIDatePicker
                    {
                        Mode = UIDatePickerMode.Date,
                        Frame = new CGRect(40, size, UIScreen.MainScreen.Bounds.Width - 80, 100),
                        Date = Carrito.ContainsKey(membresia.Membresia_Id) ? (NSDate)DateTime.SpecifyKind(DateTime.Parse(Membresias[membresia.Membresia_Id].Membresia_Fecha_Inicio), DateTimeKind.Utc) : (NSDate)DateTime.Now,
                        MinimumDate = (NSDate)DateTime.Now
                    };

                    scrollView.Add(dpFechaInicio);
                    size += 100;
                    /////
                    UILabel lblMeses = new STLLabel("Cantidad de meses", size, 14);
                    scrollView.AddSubview(lblMeses);
                    UITextField txtMesesCantidad = new UITextField
                    {
                        Text = "1",
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 120, size, 30, 30),
                        Font = UIFont.SystemFontOfSize(14),
                        KeyboardType = UIKeyboardType.NumberPad
                    };

                    scrollView.AddSubview(txtMesesCantidad);
                    UIStepper stpMesesMembresia = new UIStepper
                    {
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 100, size, 55, 30),
                        MinimumValue = 1
                    };

                    scrollView.AddSubview(stpMesesMembresia);
                    UILabel lblProporcional = new STLLabel(subtotal.ToString("C")), lblTotal = new STLLabel((membresia.Membresia_Precio_Base * stpMesesMembresia.Value).ToString("C"));
                    stpMesesMembresia.ValueChanged += (sender, e) =>
                    {
                        txtMesesCantidad.Text = stpMesesMembresia.Value.ToString();
                        lblTotal.Text = (((membresia.Membresia_Precio_Base * (Convert.ToDouble(txtMesesCantidad.Text) - 1)) + subtotal) * Convert.ToDouble(txtCantidad.Text)).ToString("C");
                    };
                    txtMesesCantidad.EditingChanged += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(txtMesesCantidad.Text) || txtMesesCantidad.Text != "0")
                        {
                            lblTotal.Text = (membresia.Membresia_Precio_Base * stpMesesMembresia.Value).ToString("C");
                        }
                    };
                    size += 45;
                    scrollView.AddSubview(new STLLabel("Proporcional al mes", size));
                    subtotal = (membresia.Membresia_Precio_Base / GetMonthsDays((DateTime)dpFechaInicio.Date) *
                                (GetMonthsDays((DateTime)dpFechaInicio.Date) - ((DateTime)dpFechaInicio.Date).Day + 1));
                    lblTotal.Text = (subtotal * Convert.ToDouble(txtCantidad.Text)).ToString("C");
                    lblProporcional.Text = (subtotal * Convert.ToDouble(txtCantidad.Text)).ToString("C");

                    lblProporcional.Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 2 / 3, size, UIScreen.MainScreen.Bounds.Width / 4, 30);
                    stpMembresia.ValueChanged += (sender, e) =>
                    {
                        txtCantidad.Text = stpMembresia.Value.ToString();
                        Membresias[membresia.Membresia_Id].Membresia_Cantidad = (int)stpMembresia.Value;
                        CanPay = (stpMembresia.Value > 0);
                        Changed = CanPay;
                        double EndMonth = GetMonthsDays((DateTime)dpFechaInicio.Date);
                        double currentDay = ((DateTime)dpFechaInicio.Date).Day;
                        subtotal = Convert.ToInt32(txtCantidad.Text) == 0 ? 0 : (membresia.Membresia_Precio_Base / EndMonth * (EndMonth - currentDay + 1));
                        lblProporcional.Text = subtotal.ToString("C");
                        lblTotal.Text = (((membresia.Membresia_Precio_Base * (Convert.ToDouble(txtMesesCantidad.Text) - 1)) + subtotal) * Convert.ToDouble(txtCantidad.Text)).ToString("C");
                    };
                    txtCantidad.EditingChanged += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(txtCantidad.Text))
                        {
                            if (Convert.ToDouble(txtCantidad.Text) > Convert.ToDouble(membresia.Membresia_Espacios_Disponibles))
                            {
                                new MessageDialog().SendMessage("Tamaño de " + membresia.Membresia_Descripcion, "Superaste el tamaño permitido");
                                txtCantidad.Text = membresia.Membresia_Espacios_Disponibles;
                            }
                            double EndMonth = GetMonthsDays((DateTime)dpFechaInicio.Date);
                            double currentDay = ((DateTime)dpFechaInicio.Date).Day;
                            subtotal = Convert.ToInt32(txtCantidad.Text) == 0 ? 0 : (membresia.Membresia_Precio_Base / EndMonth * (EndMonth - currentDay + 1));
                            lblProporcional.Text = subtotal.ToString("C");
                            lblTotal.Text = (((membresia.Membresia_Precio_Base * (Convert.ToDouble(txtMesesCantidad.Text) - 1)) + subtotal) * Convert.ToDouble(txtCantidad.Text)).ToString("C");
                            stpMembresia.Value = Convert.ToDouble(txtCantidad.Text);
                            Membresias[membresia.Membresia_Id].Membresia_Cantidad = (int)stpMembresia.Value;
                            CanPay = (stpMembresia.Value > 0);
                            Changed = CanPay;
                        }
                    };
                    txtMesesCantidad.EditingChanged += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(txtMesesCantidad.Text))
                        {
                            if (Convert.ToInt32(txtMesesCantidad.Text) < 1)
                            {
                                new MessageDialog().SendMessage("La cantidad de meses a contratar debe ser mínimo 1", "Meses de membresias");
                                txtMesesCantidad.Text = "1";
                            }
                            double EndMonth = GetMonthsDays((DateTime)dpFechaInicio.Date);
                            double currentDay = ((DateTime)dpFechaInicio.Date).Day;
                            subtotal = Convert.ToInt32(txtMesesCantidad.Text) == 0 ? 0 : (membresia.Membresia_Precio_Base / EndMonth * (EndMonth - currentDay + 1));
                            lblProporcional.Text = subtotal.ToString("C");
                            lblTotal.Text = (((membresia.Membresia_Precio_Base * (Convert.ToDouble(txtMesesCantidad.Text) - 1)) + subtotal) * Convert.ToDouble(txtCantidad.Text)).ToString("C");
                            stpMesesMembresia.Value = Convert.ToDouble(txtMesesCantidad.Text);
                            Membresias[membresia.Membresia_Id].Membresia_Cantidad = (int)stpMesesMembresia.Value;
                            CanPay = (stpMesesMembresia.Value > 0);
                            Changed = CanPay;
                        }
                    };
                    dpFechaInicio.ValueChanged += (sender, e) =>
                    {
                        double EndMonth = GetMonthsDays(((DateTime)(((UIDatePicker)sender).Date)));
                        double currentDay = ((DateTime)(((UIDatePicker)sender).Date)).Day;
                        subtotal = Convert.ToInt32(txtCantidad.Text) == 0 ? 0 : (membresia.Membresia_Precio_Base / EndMonth * (EndMonth - currentDay + 1));
                        lblProporcional.Text = subtotal.ToString("C");
                        lblTotal.Text = (((membresia.Membresia_Precio_Base * (Convert.ToDouble(txtMesesCantidad.Text) - 1)) + subtotal) * Convert.ToDouble(txtCantidad.Text)).ToString("C");
                    };
                    scrollView.AddSubview(lblProporcional);
                    size += 45;
                    scrollView.AddSubview(new STLLabel("Total", size));
                    lblTotal.Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 2 / 3, size, UIScreen.MainScreen.Bounds.Width / 4, 30);
                    scrollView.AddSubview(lblTotal);
                    ///
                    size += 45;
                }
                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, size + 30);
                View.AddSubview(scrollView);
            }
            NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_shopping_cart"), UIBarButtonItemStyle.Plain, (sender, e) =>
            {
                if (CanPay)
                    if (new CarritoController().AddCarrito(Membresias, TiposServicios.Membresia, Storage.Get("Usuario_Id")))
                    {
                        CarritoCompraController controller = (CarritoCompraController)Storyboard.InstantiateViewController("CarritoCompraController");
                        controller.Title = "Confirmación de pago";
                        NavigationController.PushViewController(controller, true);
                    }
                    else
                        new MessageDialog().SendMessage("Debe de seleccionar alguna sucursal", "Aviso");
                else
                    new MessageDialog().SendMessage("Debe de seleccionar alguna membresía", "Aviso");
            }), true);
            NavigationItem.SetLeftBarButtonItem(new UIBarButtonItem(UIBarButtonSystemItem.Cancel, (sender, e) =>
            {
                if (Changed)
                {
                    if (new CarritoController().AddCarrito(Membresias, TiposServicios.Membresia, Storage.Get("Usuario_Id")))
                    {
                        NavigationController.PopViewController(true);
                    }
                    else
                        new MessageDialog().SendMessage("Debe de seleccionar alguna sucursal", "Aviso");
                }
                else
                    NavigationController.PopViewController(true);
            }), true);
        }
        double GetMonthsDays(DateTime date) =>
             (new DateTime(date.Year, date.Month, 1)).AddMonths(1).AddDays(-1).Day;
    }
}