using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AbstractFabric.Services
{
    public class MainFurniturePlace<T> : CommonFurnitureValidationGenerics<T> where T : IFurnitureFactory, new()
    {
        public MainFurniturePlace() : base() { }
    }
}
