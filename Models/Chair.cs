using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Views;
using Microsoft.VisualBasic.Logging;
using System.Xml.Linq;


namespace AbstractFabric.Models
{
    public class Chair :  CommonFurniturePropertiesValidation
    {
        public Chair(string name, string style, double width, double height, string? logo) : base(name, style, width, height, logo)
        {
            this.Name = name;
            this.Style = style;
            this.Width = width;
            this.Height = height;
            this.Logo = logo;
        }
    }
}
