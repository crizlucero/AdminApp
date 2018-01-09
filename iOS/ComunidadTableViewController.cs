using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using System.Threading.Tasks;
using Foundation;
using SWRevealViewControllerBinding;
using Xamarin.SimplePing;

namespace WorklabsMx.iOS
{
    public partial class ComunidadTableViewController : UITableViewController
    {
        List<MiembroModel> Usuarios = new List<MiembroModel>();

        const string IdentificadorCeldaHeader = "HeaderBuscador";
        const string IdentificadorCeldaUsuarios = "CeldaUsuarios";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoUsuarios = 70;
        const int TamañoHeader = 50;
        const int TamañoMensajeNoInfo = 800;

        bool isShowInformation = false;
        bool existeConeccion = true;

        UITableViewCell Header = new UITableViewCell();

        int ContadorPerfil;
        List<string> ListUser = new List<string>();

        public ComunidadTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.FillData();
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            ContadorPerfil = 0;
        }

        void InfoUserPost(object sender, EventArgs e)
        {
            ContadorPerfil = ContadorPerfil + 1;
            if (ContadorPerfil <= 1)
            {
                ListUser = (List<string>)sender;
                this.PerformSegue("DetallarPerfil", null);
            }

        }

        private void FillData(string nombre = "", string apellido = "", string puesto = "", string profesion = "", string habilidades = "", bool disponibilidad = true, string pais = "", string estado = "", string municipio = "")
        {
            this.Usuarios = new MiembrosController().GetDirectorioUsuarios(nombre, apellido, puesto, profesion, habilidades, disponibilidad, pais, estado, municipio);
        }


        private void AgregarBusqueda(string Parametro)
        {
            
        }

        void Buscando(object sender, EventArgs e)
        {
            string TextoBuscar = sender as string;
            List<MiembroModel> SearchPost = new List<MiembroModel>();

            if (InternetConectionHelper.VerificarConexion())
            {
                Usuarios = new MiembrosController().GetDirectorioUsuarios("", "", "", "", "", true, "", "", "");
            }

            if (TextoBuscar != "")
            {
                if (Usuarios.FindAll(x => x.Miembro_Nombre.Contains(TextoBuscar)) != null)
                {
                    foreach (MiembroModel post in Usuarios.FindAll(x => x.Miembro_Nombre.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                if (Usuarios.FindAll(x => x.Miembro_Apellidos.Contains(TextoBuscar)) != null)
                {
                    foreach (MiembroModel post in Usuarios.FindAll(x => x.Miembro_Apellidos.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                if (Usuarios.FindAll(x => x.Miembro_Puesto.Contains(TextoBuscar)) != null)
                {
                    foreach (MiembroModel post in Usuarios.FindAll(x => x.Miembro_Puesto.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                if (Usuarios.FindAll(x => x.Miembro_Profesion.Contains(TextoBuscar)) != null)
                {
                    foreach (MiembroModel post in Usuarios.FindAll(x => x.Miembro_Profesion.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                this.Usuarios = SearchPost;
            }
            this.TableView.ReloadData();
        }


        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (BuscadorTableViewCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell();
            headerCell.Buscando += Buscando;
            return headerCell.ContentView;
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return TamañoHeader;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (this.Usuarios.Count > 0)
            {
                isShowInformation = true;
                return this.Usuarios.Count;
            }
            isShowInformation = false;
            return 1;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var current = Usuarios[indexPath.Row];
                var currentUser = (ComunidadTableViewCell)tableView.DequeueReusableCell(IdentificadorCeldaUsuarios, indexPath);
                currentUser.InfoUserPost += InfoUserPost;
                currentUser.UpdateCell(current);
                this.WillDisplay(indexPath.Row);
                return currentUser;
            }
            else
            {
                BTProgressHUD.Dismiss();
                var noPostCell = (NoInfoCellUsuarios)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }

        private void WillDisplay(int Row)
        {
            int LastRow = Usuarios.Count - 1;
            if ((Row == LastRow))
            {
                BTProgressHUD.Dismiss();
            }
        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }


        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "DetallarPerfil")
            {
                var PerfilView = (PerfilesTableViewController)segue.DestinationViewController;
                PerfilView.ListUser = ListUser;
            }
        }

    }
}