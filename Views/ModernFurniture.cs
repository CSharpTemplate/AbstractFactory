using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Models;
using Microsoft.VisualBasic.Logging;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace AbstractFabric.Views
{
    public class ModernFurniture : IFurnitureFactory
    {
        public ModernFurniture(){}

        CommonFurniturePropertiesValidation IFurnitureFactory.CreateArmChair(string name, string style, double width, double height, string logo)
        {
            return new ArmChair(name, style, width, height, logo);
        }

        CommonFurniturePropertiesValidation IFurnitureFactory.CreateChair(string name, string style, double width, double height, string logo)
        {
            return new Chair(name,style,width,height,logo);
        }

        CommonFurniturePropertiesValidation IFurnitureFactory.CreateSofa(string name, string style, double width, double height, string logo)
        {
            return new Sofa(name, style, width, height, logo);
        }

    }
}
