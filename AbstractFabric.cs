
using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Models;
using AbstractFabric.Views;
using Microsoft.VisualBasic.Logging;

namespace Patterns
{
    public partial class AbstractFabric : Form
    {
       // private dynamic furniture { get; set; }
        public AbstractFabric()
        {
            InitializeComponent();
        }

        private void AbstractFabric_Load(object sender, EventArgs e)
        {
       
        }

        private void create_Click(object sender, EventArgs e)
        {
            MainFurniturePlace<ModernFurniture> furniture = new MainFurniturePlace<ModernFurniture>();
            var result = furniture.Runnable("Стул", "Example", 0.50, 0.50, null);
            width.Text = result.ToString();

        }
    }
}
