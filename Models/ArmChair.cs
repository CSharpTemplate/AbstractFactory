using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Views;

namespace AbstractFabric.Models
{
    public class ArmChair : CommonFurniturePropertiesValidation
    {
        public ArmChair() {}
        public ArmChair(string name, string style, double width, double height, string? logo) : base(name,style,width,height,logo)
        {
            this.Logo   = logo;
            this.Name   = name;
            this.Style  = style;
            this.Width  = width;
            this.Height = height;
        }
    }
}
