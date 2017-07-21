using System;
using System.Collections.Generic;

namespace WorklabsMx.Models
{
    public class ItemsMenu
    {
        public string Image { get; set; }
        public string Label { get; set; }
        public string Controller { get; set; }
        public List<ItemsMenu> Childs { get; set; }
        public bool Principal { get; set; }
        public ItemsMenu()
        {
        }
    }
}
