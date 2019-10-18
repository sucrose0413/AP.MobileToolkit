using System.Collections.Generic;
using AP.CrossPlatform.Collections;
using Prism.Logging;
using Prism.Navigation;
using Prism.Services;
using ReactiveUI;

namespace ToolkitDemo.ViewModels
{
    public class RepeaterViewPageViewModel : DemoPageViewModelBase
    {
        public RepeaterViewPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, ILogger logger)
            : base(navigationService, pageDialogService, logger)
        {
            Header = "Repeater View Header";
            ItemList = new ObservableRangeCollection<string>()
            {
                { "Item 1" },
                { "Item 2" },
                { "Item 3" }
            };
        }

        public string Header
        {
            get => _header;
            set => this.RaiseAndSetIfChanged(ref _header, value);
        }

        private string _header;

        public IEnumerable<string> ItemList
        {
            get => _itemList;
            set => this.RaiseAndSetIfChanged(ref _itemList, value);
        }

        private IEnumerable<string> _itemList;
    }
}
