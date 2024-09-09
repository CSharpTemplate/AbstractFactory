using AbstractFabric.Interfaces;
using Message = AbstractFabric.Views.Components.Messages.Message;

namespace AbstractFabric.AbstractFactory
{
    public abstract class CommonFurniturePropertiesValidation : ICommonFurnitureProperties
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
               Message.ErrorWidthAndHeightMessage();
            else if (name is null || style is null)
            {
                Message.BadName();
            }
            else
            {
                this.Logo   = logo;
                this.Name   = name;
                this.Width  = width;
                this.Height = height;
                this.Style  = style;
            }
        }
    }
}
