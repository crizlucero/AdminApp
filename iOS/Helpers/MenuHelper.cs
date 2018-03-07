using System;
using WorklabsMx.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public static string ProfileImagePath;

        public static UsuarioModel Usuario;

        public static List<ProductoModel> Productos;

        public static List<MembresiaModel> Membresias;

        public static List<PostModel> AllPost = new List<PostModel>();

        public static List<ConfiguracionesModel> Configuraciones = new List<ConfiguracionesModel>();

        
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

        public static void GetListConfiguraciones()
        {
            Configuraciones = new ConfigurationsController().GetListConfiguraciones();
        }

        public static async Task GetUsuarioInfo()
        {
            await Task.Run(() =>
            {
                Usuario = new UsuariosController().GetMemberData(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
            });
        }

        public static async Task GetProductos()
        {
            await Task.Run(() =>
            {
                Productos = new PickerItemsController().GetProductos();
            });
        }

        public static async Task GetMembresias()
        {
            await Task.Run(() =>
            {
                Membresias = new PickerItemsController().GetMembresias();
            });
        }

        public static async Task GetMuroPosts()
        {
            await Task.Run(() =>
            {
                AllPost = new Controllers.EscritorioController().GetMuroPosts(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
            });
        }

    }
}
