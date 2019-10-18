using System.Collections.Generic;
using AP.CrossPlatform.Collections;
using AP.MobileToolkit.Menus;
using Prism.Commands;
using Prism.Logging;
using Prism.Navigation;
using Prism.Services;
using ReactiveUI;

namespace ToolkitDemo.ViewModels
{
    public class MenuBarPageViewModel : DemoPageViewModelBase
    {
        public MenuBarPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, ILogger logger)
            : base(navigationService, pageDialogService, logger)
        {
            MenuOptions = new ObservableRangeCollection<MainMenuOption>()
            {
                new MainMenuOption { FontFamily = string.Empty, Glyph = string.Empty, Priority = 3, Text = "Badge View", Uri = "BadgeViewPage" },
                new MainMenuOption { FontFamily = string.Empty, Glyph = string.Empty, Priority = 1, Text = "Image Entry", Uri = "ImageEntryPage" },
                new MainMenuOption { FontFamily = string.Empty, Glyph = string.Empty, Priority = 2, Text = "Borderless Date Picker", Uri = "BorderlessDatePickerPage" },
                new MainMenuOption { FontFamily = string.Empty, Glyph = string.Empty, Priority = 4, Text = "Repeater View", Uri = "RepeaterViewPage" }
            };

            NavigateToUriCommand = new DelegateCommand<string>(OnNavigationCommandExecuted);
        }

        public IEnumerable<MainMenuOption> MenuOptions
        {
            get => _menuOptions;
            set => this.RaiseAndSetIfChanged(ref _menuOptions, value);
        }

        private IEnumerable<MainMenuOption> _menuOptions;

        public DelegateCommand<string> NavigateToUriCommand { get; }

        private async void OnNavigationCommandExecuted(string uri)
        {
            await NavigationService.NavigateAsync(uri);
        }
    }
}
