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
        List<UsuarioModel> Usuarios = new List<UsuarioModel>();

        const string IdentificadorCeldaHeader = "HeaderBuscador";
        const string IdentificadorCeldaUsuarios = "CeldaUsuarios";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoUsuarios = 70;
        const int TamañoHeader = 50;
        const int TamañoMensajeNoInfo = 800;

        bool isShowInformation = false;
        bool existeConeccion = true;

        UITableViewCell Header = new UITableViewCell();

        List<string> ListUser = new List<string>();

        public ComunidadTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
        }

        public override async void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            await FillData();
            this.TableView.ReloadData();
        }

        async Task FillData(string nombre = "", string apellido = "", string puesto = "", string profesion = "", string habilidades = "", bool disponibilidad = true, string pais = "", string estado = "", string municipio = "")
        {
            await Task.Delay(50);
            this.Usuarios = new UsuariosController().GetDirectorioUsuarios(nombre, apellido, puesto, profesion, habilidades, disponibilidad, pais, estado, municipio);
        }


        private void AgregarBusqueda(string Parametro)
        {
            
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            if(isShowInformation)
            {
                return TamañoUsuarios;
            }
            return TamañoMensajeNoInfo;
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (BuscadorTableViewCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell();
            headerCell.EventoBuscadorDelegate = this;
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
                currentUser.EventosComunidadCellDelegate = this;
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

    partial class ComunidadTableViewController : EventoBuscador
    {
        public async void Buscando(string Texto)
        {
            string TextoBuscar = Texto;
            List<UsuarioModel> SearchPost = new List<UsuarioModel>();

            if (InternetConectionHelper.VerificarConexion())
            {
                await FillData("", "", "", "", "", true, "", "", "");
            }

            if (TextoBuscar != "")
            {
                if (Usuarios.FindAll(x => x.Usuario_Nombre.Contains(TextoBuscar)) != null)
                {
                    foreach (UsuarioModel post in Usuarios.FindAll(x => x.Usuario_Nombre.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                if (Usuarios.FindAll(x => x.Usuario_Apellidos.Contains(TextoBuscar)) != null)
                {
                    foreach (UsuarioModel post in Usuarios.FindAll(x => x.Usuario_Apellidos.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                if (Usuarios.FindAll(x => x.Usuario_Puesto.Contains(TextoBuscar)) != null)
                {
                    foreach (UsuarioModel post in Usuarios.FindAll(x => x.Usuario_Puesto.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                if (Usuarios.FindAll(x => x.Usuario_Profesion.Contains(TextoBuscar)) != null)
                {
                    foreach (UsuarioModel post in Usuarios.FindAll(x => x.Usuario_Profesion.Contains(TextoBuscar)))
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
    }

    partial class ComunidadTableViewController : EventosComunidadCell
    {
        public void InfoUserPost(List<String> listaUser)
        {
            ListUser = listaUser;
            //this.PerformSegue("DetallarPerfil", null);
        }
    }

}