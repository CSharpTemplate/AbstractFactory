using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Views.Components.Messages;


namespace AbstractFabric.Services
{
    public abstract class RunnableClass<T> : CommonFurnitureValidationGenerics<T> where T : IFurnitureFactory, new()
    {
        public RunnableClass() : base(){}

        public dynamic Runnable(string category, string style, double height, double width, string? logo = null)
        {
            dynamic? loot = "";
            switch (category)
            {
                case "Стул":
                    var chair = this.factory?.CreateChair(category, style, height, width, logo);
                    loot = chair is not null ? chair : null;
                    break;
                case "Кресло":
                    var armChair = this.factory?.CreateArmChair(category, style, height, width,logo);
                    loot = armChair is not null ? armChair : null;
                    break;
                case "Диван":
                    var sofa = this.factory?.CreateSofa(category, style, height, width, logo);
                    loot = sofa is not null ? sofa : null;
                    break;
                default:
                    MessageBox.Show(Convert.ToString(new InvalidOperationException("Невозможно создать! Указанный предмет отсутствует!")), "Ошибка предмета!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            return loot;
        }
    }
}
