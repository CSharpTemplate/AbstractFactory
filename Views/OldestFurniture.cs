using System;
using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Models;

namespace AbstractFabric.Views
{
    internal class OldestFurniture : IFurnitureFactory
    {
        public OldestFurniture() { }
        CommonFurniturePropertiesValidation IFurnitureFactory.CreateArmChair(string name, string style, double width, double height, string logo)
        {
            return new ArmChair(name, style, width, height, logo);
        }

        CommonFurniturePropertiesValidation IFurnitureFactory.CreateChair(string name, string style, double width, double height, string logo)
        {
            return new Chair(name, style, width, height, logo);
        }

        CommonFurniturePropertiesValidation IFurnitureFactory.CreateSofa(string name, string style, double width, double height, string logo)
        {
            return new Sofa(name, style, width, height, logo);
        }
    }
}
