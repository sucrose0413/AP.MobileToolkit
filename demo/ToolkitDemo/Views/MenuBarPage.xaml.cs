using ToolkitDemo.Helpers;
using ToolkitDemo.Views;
using Xamarin.Forms;

[assembly: MenuItem("Menu Bar", nameof(MenuBarPage), MenuGroup.Controls)]
namespace ToolkitDemo.Views
{
    public partial class MenuBarPage : ContentPage
    {
        public MenuBarPage()
        {
            InitializeComponent();
        }
    }
}
