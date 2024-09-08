using AbstractFabric.Interfaces;
using System.Xml.Linq;

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
                MessageBox.Show("Ширина и высота должны быть больше 0.", "Ошибка валидации свойства!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (name is null || style is null)
            {
                MessageBox.Show(Convert.ToString(new ArgumentNullException(nameof(name))) + "Поле имени или стиля не должно содержать пустоту", "Ошибка валидации свойства!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
