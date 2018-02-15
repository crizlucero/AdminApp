using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using Foundation;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class PerfilesTableViewController : UITableViewController
    {
        public List<string> ListUser = new List<string>();
        UsuariosController Favorites = new UsuariosController();
        public UsuarioModel Miembro = new UsuarioModel();

        bool FromMi = true, FromSocial = false, FromTrabajo = false;

        public PerfilesTableViewController (IntPtr handle) : base (handle)
        {
        }



        public override void ViewDidLoad()

        {
            base.ViewDidLoad();
            this.CargarInfo();
            this.cvwMi.Hidden = false;
            this.cvwSocial.Hidden = true;
            this.cvwTrabajo.Hidden = true;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
           
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }


        partial void btnVerMas_Touch(UIButton sender)
        {
            this.TableView.ScrollToRow(NSIndexPath.FromRowSection(1, 0), UITableViewScrollPosition.None, true);
        }

        partial void btnSobreMi_Touch(UIButton sender)
        {
            this.cvwMi.Hidden = false;
            this.cvwSocial.Hidden = true;
            this.cvwTrabajo.Hidden = true;
            this.btnSobreMi.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            this.btnSobreMi.SetTitleColor(UIColor.Clear.FromHex(0x63B4EA), UIControlState.Normal);
            this.vwMi.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            if (FromSocial)
            {
                this.btnSocial.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
                this.btnSocial.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwSocial.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
            }
            else if (FromTrabajo)
            {
                this.btnTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
                this.btnTrabajo.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
            }
            this.FromMi = true;
            this.FromSocial = false;
            this.FromTrabajo = false;
        }

        partial void btnSocial_Touch(UIButton sender)
        {
            this.cvwMi.Hidden = true;
            this.cvwSocial.Hidden = false;
            this.cvwTrabajo.Hidden = true;
            this.btnSocial.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            this.btnSocial.SetTitleColor(UIColor.Clear.FromHex(0x63B4EA), UIControlState.Normal);
            this.vwSocial.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            if (FromMi)
            {
                this.btnSobreMi.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
                this.btnSobreMi.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwMi.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
            }
            else if (FromTrabajo)
            {
                this.btnTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
                this.btnTrabajo.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
            }
            this.FromMi = false;
            this.FromSocial = true;
            this.FromTrabajo = false;
        }

        partial void btnTrabajo_Touch(UIButton sender)
        {
            this.cvwMi.Hidden = true;
            this.cvwSocial.Hidden = true;
            this.cvwTrabajo.Hidden = false;
            this.btnTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            this.btnTrabajo.SetTitleColor(UIColor.Clear.FromHex(0x63B4EA), UIControlState.Normal);
            this.vwTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            if (FromMi)
            {
                this.btnSobreMi.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
                this.btnSobreMi.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwMi.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
            }
            else if (FromSocial)
            {
                this.btnSocial.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
                this.btnSocial.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwSocial.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
            }
            this.FromMi = false;
            this.FromSocial = false;
            this.FromTrabajo = true;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "SobreMi")
            {
                var InfoPeril = (MiInfoViewController)segue.DestinationViewController;
                InfoPeril.Miembro = this.Miembro;
            }
            else if(segue.Identifier == "Social")
            {
                var InfoSocial = (PerfilSocialTableViewController)segue.DestinationViewController;
                InfoSocial.Redes_Sociales = this.Miembro.Redes_Sociales;
            }
            else if (segue.Identifier == "Trabajo")
            {
                var InfoPeril = (InfoEmpresaTableViewController)segue.DestinationViewController;
                InfoPeril.Miembro = this.Miembro;
            }
        }

        private void CargarInfo()
        {
            this.lblNombre.Text = (Miembro.Usuario_Nombre + " " + Miembro.Usuario_Apellidos != "") ? Miembro.Usuario_Nombre + " " + Miembro.Usuario_Apellidos : "Sin Info";
            this.lblEmpresa.Text = (Miembro.Usuario_Empresa_Nombre != null) ? Miembro.Usuario_Empresa_Nombre : "Sin Info";
            this.btnProfileImage.SetBackgroundImage(ImageGallery.LoadImage(Miembro.Usuario_Fotografia) ?? UIImage.FromBundle("ProfileImageBig"), UIControlState.Normal);
        }

        partial void btnEditarPerfil_Touch(UIButton sender)
        {
            
        }

        partial void btnCerrar_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }
    }
}