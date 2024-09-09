
using AbstractFabric.AbstractFactory;
using AbstractFabric.Models;
using AbstractFabric.Services;

namespace AbstractFabric.Views.Components
{
    public static class StyleFurniture
    {
        public static ComboBox? comboBox;
        public static dynamic? furniture;
        public static dynamic SelectComboBoxPosition()
        {
            switch (comboBox?.SelectedItem.ToString())
            {
                case "Modern":
                    furniture = new MainFurniturePlace<ModernFurniture>();
                break;
                
                case "Oldest":
                    furniture = new MainFurniturePlace<OldestFurniture>();
                break;
                
                default:
                
                break;
            }
            return furniture;
        }
    }
}
