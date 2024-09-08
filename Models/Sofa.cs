using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Models
{
    public class Sofa : CommonFurniturePropertiesValidation
    {
        public Sofa(string name, string style, double width, double height, string? logo) : base(name, style, width, height, logo)
        {
            this.Name = name;
            this.Style = style; 
            this.Width = width;
            this.Height = height;
            this.Logo = logo;
        }
    }
}
