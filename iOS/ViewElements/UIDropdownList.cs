using System;
using System.Collections.Generic;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS.ViewElements
{
    public class UIDropdownList : UITableView
    {
        /// <summary>
        /// Genera el objeto de drop down list
        /// </summary>
        /// <param name="field">Campo a donde se le agregará la selección</param>
        /// <param name="View">Vista en donde se pondrá el objeto</param>
        /// <param name="parent"></param>
        public UIDropdownList( UITextField field, UIView View, string parent = "")
        {
            List<string> data = new List<string>();
            PickerItemsController items = new PickerItemsController();
            field.Text = "";
            switch (field.Placeholder)
            {
                case "País": data = items.GetPaises(); break;
                case "Estado": data = items.GetEstados(parent); break;
                case "Municipio": data = items.GetMunicipios(parent); break;
                case "Colonia": data = items.GetColonias(parent); break;
                case "Giro": data = items.GetGiros(); break;
                case "Genero": data = items.GetGeneros(); break;
                case "Sucursal": data = items.GetSucursales(); break;
            }
            View.AddSubview(new STLDropDownList(data, field));
        }


    }
}
