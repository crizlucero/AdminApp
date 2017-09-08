using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using PerpetualEngine.Storage;
using WorklabsMx.iOS.Styles;
using CoreGraphics;

namespace WorklabsMx.iOS
{
    public partial class MiMembresiaController : UIViewController
    {
        public MiMembresiaController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            int sizeTotal = 90;
            SimpleStorage storage = SimpleStorage.EditGroup("Login");
            Title = "Suscripciones contratas";
            #region Membresias
            UILabel lblMembresias = new STLLabel("MEMBRESIAS", 50, 20)
            {
                Frame = new CGRect(20, 60, UIScreen.MainScreen.Bounds.Width, 50)
            };
            Add(lblMembresias);
            foreach (MembresiaModel membresia in new SuscripcionesController().GetMembresiasContratadas(storage.Get("Usuario_Id")))
            {

            }
            #endregion
            #region Productos
            UILabel lblProductos = new STLLabel("PRODUCTOS", 50, 20)
            {
                Frame = new CGRect(20, sizeTotal + 30, UIScreen.MainScreen.Bounds.Width, 50)
            };
            Add(lblProductos);
            #endregion
            foreach (ProductoModel producto in new SuscripcionesController().GetProductosContratados(storage.Get("Usuario_Id")))
            {

            }

        }
    }
}