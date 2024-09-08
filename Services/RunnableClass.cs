using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Services
{
    public abstract class RunnableClass<T> : CommonFurnitureValidationGenerics<T> where T : IFurnitureFactory, new()
    {
        public RunnableClass() : base(){}

        public dynamic Runnable(string category, string style, double height, double width, string? logo = null)
        {
            dynamic loot = "";
            switch (category)
            {
                case "Стул":
                    var result = this.factory.CreateChair(category, style, height, width, logo);
                    loot = result is not null ? result
                           : MessageBox.Show(Convert.ToString(new InvalidOperationException("Невозможно создать: Одно или несколько свойств содержат null или пустоту")), "Ошибка предмета!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
