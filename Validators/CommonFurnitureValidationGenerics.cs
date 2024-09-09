using AbstractFabric.Interfaces;
using AbstractFabric.Services;
using Message = AbstractFabric.Views.Components;

namespace AbstractFabric.AbstractFactory
{
    public abstract class CommonFurnitureValidationGenerics<T> where T : IFurnitureFactory, new()
    {
        public dynamic? furniture { get; set; }
        public IFurnitureFactory? factory {get;set;}

        public CommonFurnitureValidationGenerics()
        {
            if (typeof(T) == typeof(ModernFurniture))
            {
                this.furniture = new ModernFurniture();
                this.factory = this.furniture;
            }
            else if (typeof(T) == typeof(OldestFurniture))
            {
                this.furniture = new OldestFurniture();
                this.factory = this.furniture;
            }
            else
            {
                Message.Messages.Message.ErrorStyleGenericType();
            }
        }
    }
}
