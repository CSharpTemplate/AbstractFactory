using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Models;

namespace AbstractFabric.Services
{
    public class ModernFurniture : IFurnitureFactory 
    {
        public ModernFurniture() { }

        CommonFurniturePropertiesValidation IFurnitureFactory.CreateArmChair(string name, string style, double width, double height, string logo)
        {
            var result = name is not null || style is not null || width <= 0.00 || height <= 0.00 || logo is not null ?
                         new ArmChair(name, style, width, height, logo) : null;
            return result;
        }

        CommonFurniturePropertiesValidation IFurnitureFactory.CreateChair(string name, string style, double width, double height, string logo)
        {
            var result = width <= 1.00 || height <= 1.00 ? null : new Chair(name, style, width, height, logo);
            return result;
        }

        CommonFurniturePropertiesValidation IFurnitureFactory.CreateSofa(string name, string style, double width, double height, string logo)
        {
            var result = name is not null || style is not null || width <= 0.00 || height <= 0.00 || logo is not null ?
                      new Sofa(name, style, width, height, logo) : null;
            return result;
        }

    }
}
