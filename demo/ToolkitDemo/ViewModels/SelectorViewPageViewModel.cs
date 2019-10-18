using System.Collections.Generic;
using AP.CrossPlatform.Collections;
using Prism.Logging;
using Prism.Navigation;
using Prism.Services;
using ReactiveUI;
using ToolkitDemo.Models;

namespace ToolkitDemo.ViewModels
{
    public class SelectorViewPageViewModel : DemoPageViewModelBase
    {
        public SelectorViewPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, ILogger logger)
            : base(navigationService, pageDialogService, logger)
        {
            Header = "Selector View Header";
            ItemList = new ObservableRangeCollection<SelectableItem>()
            {
                new SelectableItem() { Text = "Item 1" },
                new SelectableItem() { Text = "Item 2" },
                new SelectableItem() { Text = "Item 3" }
            };
        }

        public IEnumerable<SelectableItem> ItemList
        {
            get => _itemList;
            set => this.RaiseAndSetIfChanged(ref _itemList, value);
        }

        private IEnumerable<SelectableItem> _itemList;

        public string Header
        {
            get => _header;
            set => this.RaiseAndSetIfChanged(ref _header, value);
        }

        private string _header;

        public bool MultiSelectEnabled
        {
            get => _multiSelectEnabled;
            set => this.RaiseAndSetIfChanged(ref _multiSelectEnabled, value);
        }

        private bool _multiSelectEnabled;
    }
}
