using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.Helpers;
using WorklabsMx.iOS.Helpers;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{

    public interface EventosCeldaLike
    {
        
    }

    public partial class CeldaLike : UITableViewCell
    {

        KeyValuePair<int, bool> isFavorite;
        string Usuario_Id;
        string Usuario_Tipo;

        public CeldaLike(IntPtr handle) : base(handle)
        {
        }

        public void UpdateCell(UsuarioModel usuario)
        {
            this.Usuario_Id = usuario.Usuario_Id;
            this.Usuario_Tipo = usuario.Usuario_Tipo;
            UsuariosController Favorites = new UsuariosController();
            this.lblNombre.Text = usuario.Usuario_Nombre + " " + usuario.Usuario_Apellidos;
            this.lblOcupacion.Text = usuario.Empresa_Actual.Empresa_Nombre;
            isFavorite = Favorites.IsMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), usuario.Usuario_Id, usuario.Usuario_Tipo);
            if (isFavorite.Value)
            {
                btnSeguir.Hidden = true;
                btnSeguir.Enabled = false;
            }
            else
            {
                btnSeguir.Hidden = false;
                btnSeguir.Enabled = true;
            }
        }

        partial void btnSeguir_Touch(UIButton sender)
        {
            this.AsignarFavorito();
        }

        private void AsignarFavorito()
        {
            if(InternetConectionHelper.VerificarConexion())
            {
                var result = new UsuariosController().AddMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.Usuario_Id, this.Usuario_Tipo);
                if (result)
                {
                    btnSeguir.Hidden = true;
                    btnSeguir.Enabled = false;
                }

            }
           
        }

    }
}