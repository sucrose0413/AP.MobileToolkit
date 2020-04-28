﻿using Prism.Events;
using Prism.Logging;
using Prism.Navigation;
using Prism.Services;
using Prism.Services.Dialogs;

namespace AP.MobileToolkit.Mvvm
{
    public class BaseServices
    {
        public BaseServices(INavigationService navigationService,
                            IDialogService dialogService,
                            IPageDialogService pageDialogService,
                            ILogger logger,
                            IEventAggregator eventAggregator,
                            IDeviceService deviceService)
        {
            NavigationService = navigationService;
            DialogService = dialogService;
            PageDialogService = pageDialogService;
            DeviceService = deviceService;
            Logger = logger;
            EventAggregator = eventAggregator;
        }

        public IDeviceService DeviceService { get; }

        public ILogger Logger { get; }

        public IEventAggregator EventAggregator { get; }

        public INavigationService NavigationService { get; }

        public IDialogService DialogService { get; }

        public IPageDialogService PageDialogService { get; }
    }
}
