using System;
using UIKit;
using System.Collections.Generic;
using CoreGraphics;
using WorklabsMx.iOS.Styles;
using WorklabsMx.iOS.ViewElements;
using WorklabsMx.Controllers;
using WorklabsMx.Models;
using PerpetualEngine.Storage;
using Foundation;
using WorklabsMx.Helpers;
using WorklabsMx.Enum;

namespace WorklabsMx.iOS
{
    public partial class ProductosController : UIViewController
    {
        UITableView selectView;
        int size;
        readonly Dictionary<string, CarritoModel> Carrito, Productos;
        bool CanPay, Changed;
        SimpleStorage Storage;

        public ProductosController(IntPtr handle) : base(handle)
        {
            Storage = SimpleStorage.EditGroup("Login");
            Productos = new Dictionary<string, CarritoModel>();
            CanPay = false;
            Carrito = new CarritoController().GetCarrito(Storage.Get("Usuario_Id"), TiposServicios.Producto);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {
                foreach (ProductoModel producto in new PickerItemsController().GetProductos())
                {
                    double subtotal = producto.Producto_Precio_Base;
                    UIDatePicker dpFechaInicio = new UIDatePicker();
                    UIStepper stpMesesProducto = new UIStepper();
                    UITextField txtMesesCantidad = new UITextField { Text = "1" };
                    scrollView.AddSubview(new STLLine(size));
                    Productos.Add(producto.Producto_Id, new CarritoModel { Producto_Cantidad = 0 });
                    if (Carrito.ContainsKey(producto.Producto_Id))
                    {
                        Productos[producto.Producto_Id].Membresia_Fecha_Inicio = DateTime.Now.ToString();
						if (DateTime.Parse(Productos[producto.Producto_Id].Membresia_Fecha_Inicio) >= DateTime.Now)
						{
							Productos[producto.Producto_Id].Producto_Cantidad = (int)Carrito[producto.Producto_Id].Producto_Cantidad;
							Productos[producto.Producto_Id].Sucursal_Id = Carrito[producto.Producto_Id].Sucursal_Id;
							Productos[producto.Producto_Id].Membresia_Fecha_Inicio = Carrito[producto.Producto_Id].Membresia_Fecha_Inicio;
							CanPay = true;
						}
                    }

                    size += 10;

                    UILabel lblProducto = new STLLabel(producto.Producto_Descripcion, size, 14)
                    {
                        Frame = new CGRect(10, size, UIScreen.MainScreen.Bounds.Width / 2 + 30, 30)
                    };
                    scrollView.AddSubview(lblProducto);
                    UITextField txtCantidad = new UITextField
                    {
                        Text = Productos[producto.Producto_Id].Producto_Cantidad.ToString(),
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 120, size, 30, 30),
                        Font = UIFont.SystemFontOfSize(14),
                        KeyboardType = UIKeyboardType.NumberPad
                    };

                    scrollView.AddSubview(txtCantidad);
                    UIStepper stpProducto = new UIStepper
                    {
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 100, size, 55, 30),
                        Value = Productos[producto.Producto_Id].Producto_Cantidad,
                        MinimumValue = 0
                    };

                    scrollView.AddSubview(stpProducto);
                    size += 45;
                    ///
                    if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                        scrollView.AddSubview(new STLLabel("Tarifa Mensual", size));
                    else
                        scrollView.AddSubview(new STLLabel("Tarifa de pago único", size));
                    scrollView.AddSubview(new STLLabel(producto.Producto_Precio_Base.ToString("C"))
                    {
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 2 / 3, size, UIScreen.MainScreen.Bounds.Width / 5, 30)
                    });
                    ///
                    size += 45;
                    UITextField txtSucursal = new STLTextField("Sucursal", size)
                    {
                        Text = Carrito.ContainsKey(producto.Producto_Id) ? Carrito[producto.Producto_Id].Sucursal_Descripcion : ""
                    };
                    txtSucursal.EditingDidBegin += (sender, e) =>
                    {
                        selectView = new UIDropdownList(txtSucursal, View);
                    };
                    txtSucursal.EditingDidEnd += (sender, e) =>
                    {
                        Productos[producto.Producto_Id].Sucursal_Id = new SucursalController().GetSucursalId(txtSucursal.Text);
                        selectView.RemoveFromSuperview();
                    };
                    scrollView.AddSubview(txtSucursal);
                    if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                    {
                        size += 40;
                        scrollView.AddSubview(new STLLabel("Fecha de Inicio", size, 12));
                        size += 30;
                        dpFechaInicio = new UIDatePicker
                        {
                            Mode = UIDatePickerMode.Date,
                            Frame = new CGRect(40, size, UIScreen.MainScreen.Bounds.Width - 80, 100),
                            Date =!string.IsNullOrEmpty(Productos[producto.Producto_Id].Membresia_Fecha_Inicio) ? (NSDate)DateTime.SpecifyKind(DateTime.Parse(Productos[producto.Producto_Id].Membresia_Fecha_Inicio), DateTimeKind.Utc) : (NSDate)DateTime.Now,
                            MinimumDate = (NSDate)DateTime.Now
                        };

                        scrollView.Add(dpFechaInicio);
                        size += 100;
                        UILabel lblMeses = new STLLabel("Cantidad de meses", size, 14);
                        scrollView.AddSubview(lblMeses);
                        txtMesesCantidad = new UITextField
                        {
                            Text = "1",
                            Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 120, size, 30, 30),
                            Font = UIFont.SystemFontOfSize(14),
                            KeyboardType = UIKeyboardType.NumberPad
                        };

                        scrollView.AddSubview(txtMesesCantidad);
                        stpMesesProducto = new UIStepper
                        {
                            Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 100, size, 55, 30),
                            MinimumValue = 1
                        };

                        scrollView.AddSubview(stpMesesProducto);
                    }
                    /////

                    UILabel lblProporcional = new STLLabel(subtotal.ToString("C")), lblTotal = new STLLabel((producto.Producto_Precio_Base * stpMesesProducto.Value).ToString("C"));
                    stpMesesProducto.ValueChanged += (sender, e) =>
                    {
                        txtMesesCantidad.Text = stpMesesProducto.Value.ToString();
                        lblTotal.Text = (((producto.Producto_Precio_Base * (Convert.ToDouble(txtMesesCantidad.Text) - 1)) + subtotal) * Convert.ToDouble(txtCantidad.Text)).ToString("C");
                    };
                    txtMesesCantidad.EditingChanged += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(txtMesesCantidad.Text))
                        {
                            if (Convert.ToInt32(txtMesesCantidad.Text) < 1)
                            {
                                new MessageDialog().SendMessage("La cantidad de meses a contratar debe ser mínimo 1", "Meses de productos");
                                txtMesesCantidad.Text = "1";
                            }
                            double EndMonth = DateHelper.GetMonthsDays((DateTime)dpFechaInicio.Date);
                            double currentDay = ((DateTime)dpFechaInicio.Date).Day;
                            subtotal = Convert.ToInt32(txtMesesCantidad.Text) == 0 ? 0 : (producto.Producto_Precio_Base / EndMonth * (EndMonth - currentDay + 1));
                            lblProporcional.Text = subtotal.ToString("C");
                            lblTotal.Text = (((producto.Producto_Precio_Base * (Convert.ToDouble(txtMesesCantidad.Text) - 1)) + subtotal) * Convert.ToDouble(txtCantidad.Text)).ToString("C");
                            stpMesesProducto.Value = Convert.ToDouble(txtMesesCantidad.Text);
                            Productos[producto.Producto_Id].Membresia_Cantidad = (int)stpMesesProducto.Value;
                            CanPay = (stpMesesProducto.Value > 0);
                            Changed = CanPay;
                        }
                    };
                    if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                    {
                        size += 45;
                        scrollView.AddSubview(new STLLabel("Proporcional al mes", size));
                        subtotal = Convert.ToInt32(txtCantidad.Text) == 0 ? 0 : (producto.Producto_Precio_Base / DateHelper.GetMonthsDays((DateTime)dpFechaInicio.Date) *
                                    (DateHelper.GetMonthsDays((DateTime)dpFechaInicio.Date) - ((DateTime)dpFechaInicio.Date).Day + 1));
                        lblTotal.Text = subtotal.ToString("C");
                        lblProporcional.Text = subtotal.ToString("C");

                        lblProporcional.Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 2 / 3, size, UIScreen.MainScreen.Bounds.Width / 4, 30);
                        dpFechaInicio.ValueChanged += (sender, e) =>
                        {
                            double EndMonth = DateHelper.GetMonthsDays(((DateTime)(((UIDatePicker)sender).Date)));
                            double currentDay = ((DateTime)(((UIDatePicker)sender).Date)).Day;
                            subtotal = (producto.Producto_Precio_Base / EndMonth * (EndMonth - currentDay + 1));
                            lblProporcional.Text = subtotal.ToString("C");
                            lblTotal.Text = (((producto.Producto_Precio_Base * (Convert.ToDouble(txtMesesCantidad.Text) - 1)) + subtotal) * Convert.ToDouble(txtCantidad.Text)).ToString("C");
                        };
                        scrollView.AddSubview(lblProporcional);
                    }
                    stpProducto.ValueChanged += (sender, e) =>
                    {
                        txtCantidad.Text = stpProducto.Value.ToString();
                        Productos[producto.Producto_Id].Producto_Cantidad = (int)stpProducto.Value;
                        CanPay = (stpProducto.Value > 0);
                        Changed = CanPay;
                        double EndMonth = DateHelper.GetMonthsDays((DateTime)dpFechaInicio.Date);
                        double currentDay = ((DateTime)dpFechaInicio.Date).Day;
                        if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                            subtotal = Convert.ToInt32(txtCantidad.Text) == 0 ? 0 : (producto.Producto_Precio_Base / EndMonth * (EndMonth - currentDay + 1));
                        else
                            subtotal = Convert.ToInt32(txtCantidad.Text) == 0 ? 0 : producto.Producto_Precio_Base;
                        lblProporcional.Text = subtotal.ToString("C");
                        lblTotal.Text = (((producto.Producto_Precio_Base * (Convert.ToDouble(txtMesesCantidad.Text) - 1)) + subtotal) * Convert.ToDouble(txtCantidad.Text)).ToString("C");
                    };
                    txtCantidad.EditingChanged += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(txtCantidad.Text))
                        {
                            stpProducto.Value = Convert.ToDouble(txtCantidad.Text);
                            Productos[producto.Producto_Id].Producto_Cantidad = (int)stpProducto.Value;
                            CanPay = (stpProducto.Value > 0);
                            Changed = CanPay;
                            double EndMonth = DateHelper.GetMonthsDays((DateTime)dpFechaInicio.Date);
                            double currentDay = ((DateTime)dpFechaInicio.Date).Day;
                            if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                                subtotal = Convert.ToInt32(txtCantidad.Text) == 0 ? 0 : (producto.Producto_Precio_Base / EndMonth * (EndMonth - currentDay + 1));
                            else
                                subtotal = Convert.ToInt32(txtCantidad.Text) == 0 ? 0 : producto.Producto_Precio_Base;
                            lblProporcional.Text = subtotal.ToString("C");
                            lblTotal.Text = (((producto.Producto_Precio_Base * (Convert.ToDouble(txtMesesCantidad.Text) - 1)) + subtotal) * Convert.ToDouble(txtCantidad.Text)).ToString("C");
                        }
                    };
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
                    if (new CarritoController().AddCarrito(Productos, TiposServicios.Producto, Storage.Get("Usuario_Id")))
                    {
                        CarritoCompraController controller = (CarritoCompraController)Storyboard.InstantiateViewController("CarritoCompraController");
                        controller.Title = "Confirmación de pago";
                        NavigationController.PushViewController(controller, true);
                    }
                    else
                        new MessageDialog().SendMessage("Debe de seleccionar alguna sucursal", "Aviso");
                else
                    new MessageDialog().SendMessage("Debe de seleccionar algún producto", "Aviso");

            }), true);

            NavigationItem.SetLeftBarButtonItem(new UIBarButtonItem(UIBarButtonSystemItem.Cancel, (sender, e) =>
            {
                if (Changed)
                    if (new CarritoController().AddCarrito(Productos, TiposServicios.Producto, Storage.Get("Usuario_Id")))
                        NavigationController.PopViewController(true);
                    else
                        new MessageDialog().SendMessage("Debe de seleccionar alguna sucursal", "Aviso");
                else
                    NavigationController.PopViewController(true);

            }), true);
        }
    }
}