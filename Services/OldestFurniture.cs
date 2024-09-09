using System;
using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Models;
using Message = AbstractFabric.Views.Components.Messages;

namespace AbstractFabric.Services
{
    public class OldestFurniture : IFurnitureFactory
    {
        public OldestFurniture() { }
        CommonFurniturePropertiesValidation? IFurnitureFactory.CreateArmChair(string name, string style, double width, double height, string logo)
        {

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(style))
            {
                Message.Message.BadName();
                return null;
            }
            else if (width <= 1.00 && height <= 1.00)
            {
                Message.Message.ErrorWidthAndHeightMessage();
                return null;
            }
            return new ArmChair(name, style, width, height, logo);
        }

        CommonFurniturePropertiesValidation IFurnitureFactory.CreateChair(string name, string style, double width, double height, string logo)
        {
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(style))
            {
                Message.Message.BadName();
                return null;
            }
            else if (width <= 1.00 && height <= 1.00)
            {
                Message.Message.ErrorWidthAndHeightMessage();
                return null;
            }
            return new Chair(name, style, width, height, logo);
        }

        CommonFurniturePropertiesValidation? IFurnitureFactory.CreateSofa(string name, string style, double width, double height, string logo)
        {
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(style))
            {
                Message.Message.BadName();
                return null;
            }
            else if (width <= 1.00 && height <= 1.00)
            {
                Message.Message.ErrorWidthAndHeightMessage();
                return null;
            }
            return new Sofa(name, style, width, height, logo);
        }
    }
}
