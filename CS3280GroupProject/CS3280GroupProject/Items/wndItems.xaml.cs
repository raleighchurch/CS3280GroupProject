using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CS3280GroupProject.Items
{
    /// <summary>
    /// Interaction logic for wndItems.xaml
    /// </summary>
    public partial class wndItems : Window
    {
        public wndItems()
        {
            InitializeComponent();
        }

        // bool bHasItemsChanged; // set to true when an item has been added/edited/deleted. Indicates to main window if a refresh is needed
        // book HasItemsChanged; // property
        // btnMainMenu_Click // Returns user to main window
        // btnAddItem_Click // executes function to add an item
        // btnEditItem_Click // executes function to edit an item's data
        // btnDeleteItem_Click // executes a function to remove an item
        // btnSaveItem_Click // executes a function to save an item that has been changed
    }
}
