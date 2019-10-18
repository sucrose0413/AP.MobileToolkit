using System.Collections.Generic;
using AP.MobileToolkit.Menus;
using Prism.Commands;
using Prism.Logging;
using Prism.Navigation;
using Prism.Services;

namespace ToolkitDemo.ViewModels
{
    public class MenuBarPageViewModel : DemoPageViewModelBase
    {
        public MenuBarPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, ILogger logger, IMenuBuilder menuBuilder)
            : base(navigationService, pageDialogService, logger)
        {
            menuBuilder.RegisterOption(new MainMenuOption { FontFamily = string.Empty, Glyph = string.Empty, Priority = 3, Text = "Badge View", Uri = "BadgeViewPage" });
            menuBuilder.RegisterOption(new MainMenuOption { FontFamily = string.Empty, Glyph = string.Empty, Priority = 1, Text = "Image Entry", Uri = "ImageEntryPage" });
            menuBuilder.RegisterOption(new MainMenuOption { FontFamily = string.Empty, Glyph = string.Empty, Priority = 2, Text = "Borderless Date Picker", Uri = "BorderlessDatePickerPage" });
            menuBuilder.RegisterOption(new MainMenuOption { FontFamily = string.Empty, Glyph = string.Empty, Priority = 4, Text = "Repeater View", Uri = "RepeaterViewPage" });
            MenuOptions = menuBuilder.GetOptions();

            NavigateToUriCommand = new DelegateCommand<string>(OnNavigationCommandExecuted);
        }

        public IEnumerable<MainMenuOption> MenuOptions { get; }

        public DelegateCommand<string> NavigateToUriCommand { get; }

        private async void OnNavigationCommandExecuted(string uri)
        {
            await NavigationService.NavigateAsync(uri);
        }
    }
}
