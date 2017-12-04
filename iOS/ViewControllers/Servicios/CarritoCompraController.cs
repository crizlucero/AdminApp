using System;
using UIKit;
using WorklabsMx.Models;
using CoreGraphics;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
//using PerpetualEngine.Storage;
using WorklabsMx.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class CarritoCompraController : UIViewController
    {

        Dictionary<string, int> membresias = null, productos = null;
        int size = 30;
        UIScrollView scrollView;
        UIView totalesView, cuponesView;
        readonly List<decimal> Descuentos;
        List<UIView> Conceptos;
        decimal Descuento, Subtotal, IVA = 0.16M, Total, IVATotal;
        UILabel txtDescuento, txtSubtotal, txtIva, txtTotal;
        //SimpleStorage Storage;
        public CarritoCompraController(IntPtr handle) : base(handle)
        {
            Descuentos = new List<decimal>();
            Conceptos = new List<UIView>();
            membresias = new Dictionary<string, int>();
            productos = new Dictionary<string, int>();
            //Storage = SimpleStorage.EditGroup("Login");
            Dictionary<string, CarritoModel> CarritoMembresia = new CarritoController().GetCarrito(KeyChainHelper.GetKey("Usuario_Id"), TiposServicios.Membresia);
            Dictionary<string, CarritoModel> CarritoProducto = new CarritoController().GetCarrito(KeyChainHelper.GetKey("Usuario_Id"), TiposServicios.Producto);
            try
            {
                foreach (MembresiaModel membresia in new PickerItemsController().GetMembresias())
                    if (CarritoMembresia.ContainsKey(membresia.Membresia_Id))
                        membresias.Add(membresia.Membresia_Id, (int)CarritoMembresia[membresia.Membresia_Id].Membresia_Cantidad);
                foreach (ProductoModel producto in new PickerItemsController().GetProductos())
                    if (CarritoProducto.ContainsKey(producto.Producto_Id))
                        productos.Add(producto.Producto_Id, (int)CarritoProducto[producto.Producto_Id].Producto_Cantidad);
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_credit_card"), UIBarButtonItemStyle.Plain, (sender, e) =>
            {
                PaymentController controller = (PaymentController)Storyboard.InstantiateViewController("PaymentController");
                controller.Title = "Realiza el pago";
                controller.Descuento = Descuento;
                controller.IVATotal = IVATotal;
                controller.Total = Total;
                controller.Subtotal = Subtotal;
                NavigationController.PushViewController(controller, true);
            }), true);

            scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)) { BackgroundColor = UIColor.White };

            scrollView.AddSubview(new STLLabel("Cantidad")
            {
                Frame = new CGRect(0, 30, UIScreen.MainScreen.Bounds.Width / 4, 30)
            });
            scrollView.AddSubview(new STLLabel("Descripcion")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 30, UIScreen.MainScreen.Bounds.Width / 2, 30)
            });
            scrollView.AddSubview(new STLLabel("Total")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 30, UIScreen.MainScreen.Bounds.Width / 4, 30)
            });

            scrollView.AddSubview(new UIView(new System.Drawing.RectangleF(0, 60, 100, 100))
            {
                Frame = new CGRect(0, 60, UIScreen.MainScreen.Bounds.Width, 2),
                BackgroundColor = UIColor.LightGray
            });
            #region Descripciones
            if (membresias.Count > 0)
                AddMembresiaDescripcion(new PickerItemsController().GetMembresiasPrecios(membresias));
            if (productos.Count > 0)
                AddProductosDescripcion(new PickerItemsController().GetProductosPrecios(productos));
            #endregion
            #region Cupones

            CuponView();
            #endregion
            size += 75;
            Subtotal = Total - (Total * IVA);

            #region Tabla de precios
            ShowTablaTotales();
            #endregion

            scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, size);

            View.AddSubview(scrollView);
        }

        public void AddMembresiaDescripcion(List<MembresiaModel> membresiasPrecios)
        {

            foreach (MembresiaModel membresiaPrecio in membresiasPrecios)
            {
                UIView elemento = new UIView(new CGRect(0, 30 + size, UIScreen.MainScreen.Bounds.Width, 90));
                UIButton btnEliminar = new STLButton(UIImage.FromBundle("ic_clear"))
                {
                    Frame = new CGRect(0, 30, 30, 30)
                };

                btnEliminar.TouchUpInside += (sender, e) =>
                {
                    Total = 0;
                    if (membresiasPrecios.Count > 1)
                    {
                        totalesView.RemoveFromSuperview();
                        cuponesView.RemoveFromSuperview();
                        View.BackgroundColor = UIColor.White;
                        txtSubtotal.Text = (Total - (Total * IVA)).ToString("C");
                        txtIva.Text = (Total * IVA).ToString("C");
                        txtTotal.Text = Total.ToString("C");
                        foreach (UIView concepto in Conceptos)
                            concepto.RemoveFromSuperview();
                        membresiasPrecios.Remove(membresiaPrecio);
                        size = 30;
                        AddMembresiaDescripcion(membresiasPrecios);
                        CuponView();
                        size += 75;
                        ShowTablaTotales();
                    }
                    else
                    {
                        NavigationController.PopViewController(true);
                    }
                };

                elemento.AddSubview(btnEliminar);

                elemento.AddSubview(new UILabel(new CGRect(30, 30, UIScreen.MainScreen.Bounds.Width / 4, 30))
                {
                    Text = membresias[membresiaPrecio.Membresia_Id].ToString()
                });
                elemento.AddSubview(new UILabel(new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 30, UIScreen.MainScreen.Bounds.Width / 2, 30))
                {
                    Text = membresiaPrecio.Membresia_Descripcion
                });
                elemento.AddSubview(new UILabel(new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 30, UIScreen.MainScreen.Bounds.Width / 4, 30))
                {
                    Text = (Convert.ToDecimal(membresiaPrecio.Membresia_Precio_Base) * Convert.ToDecimal(membresias[membresiaPrecio.Membresia_Id])).ToString("C")
                });
                //Inscripcion
                elemento.AddSubview(new UILabel(new CGRect(30, 60, UIScreen.MainScreen.Bounds.Width / 4, 30))
                {
                    Text = membresias[membresiaPrecio.Membresia_Id].ToString()
                });
                elemento.AddSubview(new UILabel(new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 60, UIScreen.MainScreen.Bounds.Width / 2, 30))
                {
                    Text = "Inscripción de " + membresiaPrecio.Membresia_Descripcion
                });
                elemento.AddSubview(new UILabel(new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 60, UIScreen.MainScreen.Bounds.Width / 4, 30))
                {
                    Text = (Convert.ToDecimal(membresiaPrecio.Inscripcion_Precio_Base) * Convert.ToDecimal(membresias[membresiaPrecio.Membresia_Id])).ToString("C")
                });
                Total += (Convert.ToDecimal(membresiaPrecio.Membresia_Precio_Base) * Convert.ToDecimal(membresias[membresiaPrecio.Membresia_Id])) +
                          (Convert.ToDecimal(membresiaPrecio.Inscripcion_Precio_Base) * Convert.ToDecimal(membresias[membresiaPrecio.Membresia_Id]));

                size += 65;

                scrollView.AddSubview(elemento);

                Conceptos.Add(elemento);
            }
        }

        public void AddProductosDescripcion(List<ProductoModel> productosPrecios)
        {

            foreach (ProductoModel productoPrecio in productosPrecios)
            {
                UIView elemento = new UIView(new CGRect(0, 30 + size, UIScreen.MainScreen.Bounds.Width, 60));

                UIButton btnEliminar = new STLButton(UIImage.FromBundle("ic_clear"))
                {
                    Frame = new CGRect(0, 30, 30, 40)
                };

                btnEliminar.TouchUpInside += (sender, e) =>
                {
                    Total = 0;
                    if (productosPrecios.Count > 1)
                    {
                        totalesView.RemoveFromSuperview();
                        cuponesView.RemoveFromSuperview();
                        View.BackgroundColor = UIColor.White;
                        IVATotal = (Total * IVA);
                        txtSubtotal.Text = (Total - IVATotal).ToString("C");
                        txtIva.Text = IVATotal.ToString("C");
                        txtTotal.Text = Total.ToString("C");
                        foreach (UIView concepto in Conceptos)
                            concepto.RemoveFromSuperview();
                        productosPrecios.Remove(productoPrecio);
                        size = 30;
                        AddProductosDescripcion(productosPrecios);
                        CuponView();
                        size += 75;
                        ShowTablaTotales();
                    }
                    else
                    {
                        NavigationController.PopViewController(true);
                    }
                };
                elemento.AddSubview(btnEliminar);
                elemento.AddSubview(new UILabel(new CGRect(30, 30, UIScreen.MainScreen.Bounds.Width / 4, 30))
                {
                    Text = productos[productoPrecio.Producto_Id].ToString()
                });
                elemento.AddSubview(new UILabel(new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 30, UIScreen.MainScreen.Bounds.Width / 2, 30))
                {
                    Text = productoPrecio.Producto_Descripcion
                });
                elemento.AddSubview(new UILabel(new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 30, UIScreen.MainScreen.Bounds.Width / 4, 30))
                {
                    Text = (Convert.ToDecimal(productoPrecio.Producto_Precio_Base) * Convert.ToDecimal(productos[productoPrecio.Producto_Id])).ToString("C")
                });
                size += 55;
                Total += (Convert.ToDecimal(productoPrecio.Producto_Precio_Base) * Convert.ToDecimal(productos[productoPrecio.Producto_Id]));
                scrollView.AddSubview(elemento);

                Conceptos.Add(elemento);
            }
        }

        public void ShowTablaTotales()
        {
            totalesView = new UIView(new CGRect(0, size, UIScreen.MainScreen.Bounds.Width, 150));

            totalesView.AddSubview(new STLLabel("Subtotal")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 30, UIScreen.MainScreen.Bounds.Width / 2, 30)
            });

            txtSubtotal = new STLLabel(Subtotal.ToString("C"))
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 30, UIScreen.MainScreen.Bounds.Width / 2, 30)
            };
            totalesView.AddSubview(txtSubtotal);

            totalesView.AddSubview(new STLLabel("Descuento")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 60, UIScreen.MainScreen.Bounds.Width / 2, 30)
            });

            txtDescuento = new STLLabel(Descuento.ToString("C"))
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 60, UIScreen.MainScreen.Bounds.Width / 2, 30)
            };
            totalesView.AddSubview(txtDescuento);

            totalesView.AddSubview(new STLLabel("IVA 16%")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 90, UIScreen.MainScreen.Bounds.Width / 2, 30)
            });

            txtIva = new STLLabel((Total * IVA).ToString("C"))
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 90, UIScreen.MainScreen.Bounds.Width / 2, 30)
            };
            totalesView.AddSubview(txtIva);

            totalesView.AddSubview(new STLLabel("Total")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 120, UIScreen.MainScreen.Bounds.Width / 2, 30)
            });

            txtTotal = new STLLabel(Total.ToString("C"))
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 120, UIScreen.MainScreen.Bounds.Width / 2, 30)
            };
            totalesView.AddSubview(txtTotal);

            scrollView.AddSubview(totalesView);
            size += 120;
        }

        public void ShowPromocion(PromocionModel promo)
        {
            scrollView.AddSubview(new STLLabel(promo.Promocion_Descripcion)
            {
                Frame = new CGRect(0, 30 + size, UIScreen.MainScreen.Bounds.Width * 2 / 3, 30)
            });

            scrollView.AddSubview(new STLLabel(promo.Descuento_Descripcion)
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 2 / 3, 30 + size, UIScreen.MainScreen.Bounds.Width / 3 - 10, 30)
            });
            size += 45;

        }

        public void CuponView()
        {
            cuponesView = new UIView(new CGRect(0, 60 + size, UIScreen.MainScreen.Bounds.Width / 6, 30)) { BackgroundColor = UIColor.White };
            cuponesView.AddSubview(new STLLabel("Código de Promoción")
            {
                Frame = new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width / 2, 30)
            });
            UITextField txtCupon = new STLTextField("Código de Promoción")
            {
                Frame = new CGRect((UIScreen.MainScreen.Bounds.Width / 2) - 20, 0, UIScreen.MainScreen.Bounds.Width * 2 / 5, 30)
            };
            cuponesView.AddSubview(txtCupon);

            UIButton btnCupon = new STLButton(UIImage.FromBundle("ic_check"))
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 50, 0, 30, 30)
            };
            btnCupon.TouchUpInside += (sender, e) =>
            {
                PromocionModel promo = new PagosController().AplicarCupon(txtCupon.Text);
                if (!promo.Equals(null))
                {
                    Descuento = Total * promo.Descuento_Porcentaje;
                    Total -= Descuento;
                    txtDescuento.Text = Descuento.ToString();
                    txtIva.Text = (Total * IVA).ToString();
                    txtTotal.Text = Total.ToString();
                    size -= 120;
                    totalesView.RemoveFromSuperview();
                    ShowPromocion(promo);
                    ShowTablaTotales();
                    Descuentos.Add(promo.Descuento_Porcentaje);
                    txtCupon.Enabled = false;
                }
            };
            cuponesView.AddSubview(btnCupon);
            scrollView.AddSubview(cuponesView);
        }
    }
}