using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractFabric.Views.Components.Messages
{
    public static class Message
    {
        static Message() { }
     
        public static void ErrorWidthAndHeightMessage()
        {
            
            MessageBox.Show(Resources.Messages.ErrorWidthAndHeightMessage, Resources.Messages.ErrorPropertyTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void BadName()
        {

            MessageBox.Show(Resources.Messages.ErrorNameArgument, Resources.Messages.ErorArgumentTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorStyleGenericType()
        {
            MessageBox.Show(Resources.Messages.ErrorStyleGenericType, Resources.Messages.ErrorGenericType, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void BadStyleName()
        {
            MessageBox.Show(Resources.Messages.EmptyStyleName, Resources.Messages.EmptyStyleTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void NullItems()
        {
            MessageBox.Show(Convert.ToString(new ArgumentNullException(Resources.Messages.NullItemType)), Resources.Messages.ErrorPropertyTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorItemChairType()
        {
            MessageBox.Show(Convert.ToString(new InvalidOperationException(Resources.Messages.ErrorItemChairType)), Resources.Messages.ErrorItem, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorItemArmChair()
        {
            MessageBox.Show(Convert.ToString(new InvalidOperationException(Resources.Messages.ErrorItemArmChairType)), Resources.Messages.ErrorItem, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorItemSofa()
        {
            MessageBox.Show(Convert.ToString(new InvalidOperationException(Resources.Messages.ErrorItemArmChairType)), Resources.Messages.ErrorItem, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorItem()
        {
            MessageBox.Show(Convert.ToString(new InvalidOperationException(Resources.Messages.ErrorItem)), Resources.Messages.ErrorItemTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
