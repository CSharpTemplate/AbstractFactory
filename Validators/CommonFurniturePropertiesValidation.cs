using AbstractFabric.Interfaces;
using System.Xml.Linq;

namespace AbstractFabric.AbstractFactory
{
    public abstract class CommonFurniturePropertiesValidation : ICommonProperties
    {
        public string? Logo { get; set; }
        public string? Name { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public string? Style { get; set; }

        public CommonFurniturePropertiesValidation() { }
        public CommonFurniturePropertiesValidation(string name, string style, double width, double height, string? logo=null)
        {
            if (width <= 0.00 || height <=0.00)
               throw new ArgumentOutOfRangeException(nameof(width), "Ширина должна быть больше 0.00");
            else 
               Name = name ?? throw new ArgumentNullException(nameof(name), "Имя не должно быть пустым ");
               Style = style ?? throw new ArgumentNullException(nameof(style), "Стиль не должен содержать пустоту");
        }
    }
}
