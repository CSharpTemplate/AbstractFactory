using AbstractFabric.AbstractFactory;
using Microsoft.VisualBasic.Logging;
using System.Xml.Linq;

namespace AbstractFabric.Interfaces
{
    public interface IFurnitureFactory
    {
        CommonFurniturePropertiesValidation CreateSofa(string name, string style, double width, double height, string logo);
        CommonFurniturePropertiesValidation CreateArmChair(string name, string style, double width, double height, string logo);
        CommonFurniturePropertiesValidation CreateChair(string name, string style, double width, double height, string logo);
    }
}
