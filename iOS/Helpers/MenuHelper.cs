using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.iOS.Helpers;
using BigTed;
using SWRevealViewControllerBinding;
using Foundation;
using System.Threading.Tasks;
using WorklabsMx.Helpers;
using WorklabsMx.Controllers;

namespace WorklabsMx.iOS.Helpers
{
    

    public class MenuHelper
    {

        public static List<ItemsMenu> GeneralList;

        public static List<string> UserInfo;

        public static List<UsuarioModel> Comunidad;

        public static List<SucursalModel> ListaSucursales;

        public static string UploadImagePath;
        
        public static async Task FillTable()
        {
            await Task.Run(() =>
            {
                List<ItemsMenu> tableItems = new List<ItemsMenu>();
                if (InternetConectionHelper.VerificarConexion())
                {
                    foreach (ItemsMenu menu in new Controllers.EscritorioController().GetMenuiOS(Convert.ToInt32(KeyChainHelper.GetKey("Usuario_Tipo"))))
                    {
                        if (menu.Menu_Id != "8" && menu.Menu_Id != "22")
                        {
                            tableItems.Add(menu);
                        }
                    }
                    GeneralList = tableItems;
                }
                else
                {
                    GeneralList = null;
                }
            });
        }

        public static async Task FillUserInfo()
        {
            await Task.Run(() =>
            {
                var userinfo = new UsuariosController().GetMemberName(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
                UserInfo = userinfo;
            });
        }

        public static async Task FillData(string nombre = "", string apellido = "", string puesto = "", string profesion = "", string habilidades = "", bool disponibilidad = true, string pais = "", string estado = "", string municipio = "")
        {
            await Task.Run(() =>
            {
                var usuarios = new UsuariosController().GetDirectorioUsuarios(nombre, apellido, puesto, profesion, habilidades, disponibilidad, pais, estado, municipio);
                Comunidad = usuarios;
            });
        }


        public static async Task GetSucursales()
        {
            await Task.Run(() =>
            {
                var sucursales = new SucursalController().GetSucursales();
                ListaSucursales = sucursales;
            });

        }

        public static async Task GetListConfiguraciones()
        {
            await Task.Run(() =>
            {
                string upload_image_path;
                if (new ConfigurationsController().GetListConfiguraciones() != null)
                {
                    upload_image_path = new ConfigurationsController().GetListConfiguraciones().Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PUBLICACIONES").Parametro_Varchar_1;
                }
                else
                {
                    upload_image_path = "";
                }
                UploadImagePath = upload_image_path;
            });
        }

    }
}
