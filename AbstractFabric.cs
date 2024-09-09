
using AbstractFabric.AbstractFactory;
using AbstractFabric.Interfaces;
using AbstractFabric.Models;
using AbstractFabric.Services;
using AbstractFabric.Views.Components;
using Microsoft.VisualBasic.Logging;

using Message = AbstractFabric.Views.Components.Messages.Message;
namespace Patterns
{
    public partial class AbstractFactory : Form
    {
        private dynamic? furnitureStyle { get; set; }
      
        public AbstractFactory()
        {
            InitializeComponent();
        }

        private void AbstractFabric_Load(object sender, EventArgs e)
        {
            StyleFurniture.comboBox = this.style;
        }

        private void create_Click(object sender, EventArgs e)
        {
          
        }

        private void styleFurnitureChanged(object sender, EventArgs e)
        {
            var style = StyleFurniture.SelectComboBoxPosition();
            this.furnitureStyle = style is not null ? style : null;
        }
    }
}
