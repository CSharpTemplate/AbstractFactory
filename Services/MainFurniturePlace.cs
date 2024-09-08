using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AbstractFabric.Services
{
    public class MainFurniturePlace<T> : RunnableClass<T> where T : IFurnitureFactory, new()
    {
        public MainFurniturePlace() : base() { }
    }
}
