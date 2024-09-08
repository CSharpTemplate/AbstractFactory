using AbstractFabric.Interfaces;
using AbstractFabric.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.AbstractFactory
{
    public abstract class CommonFurnitureValidationGenerics<T> where T : IFurnitureFactory, new()
    {
        private dynamic furniture { get; set; }
        private IFurnitureFactory? factory {get;set;}

        public CommonFurnitureValidationGenerics()
        {
            if (typeof(T) == typeof(ModernFurniture))
            {
                this.furniture = new ModernFurniture();
                this.factory = this.getFurniture();
            }
            else if (typeof(T) == typeof(OldestFurniture))
            {
                this.furniture = new OldestFurniture();
                this.factory = this.getFurniture();
            }
            else
            {
                MessageBox.Show(Convert.ToString(new InvalidOperationException("Такой тип отсутствует!")), "Ошибка дженерика!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public dynamic Runnable(string category, string style, double height, double width, string? logo = null)
        {
            dynamic loot="";
            switch (category)
            {
                case "Стул":
                    loot = this.factory.CreateChair(category, style, height, width, logo);
                    break;
                case "Кресло":
                    loot = this.factory.CreateArmChair(category, style, height, width, logo);
                    break;
                case "Диван":
                    loot = this.factory.CreateSofa(category, style, height, width, logo);
                    break;
                default:
                    MessageBox.Show(Convert.ToString(new InvalidOperationException("Невозможно создать! Указанный предмет отсутствует!")), "Ошибка предмета!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            return loot;
        }

        IFurnitureFactory getFurniture()
        {
            return this.furniture;
        }
    }
}
