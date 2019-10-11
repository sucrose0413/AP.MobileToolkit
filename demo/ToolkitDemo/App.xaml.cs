﻿using AP.MobileToolkit.Fonts;
using Prism;
using Prism.Ioc;
using Prism.Logging;
using ToolkitDemo.Fonts;
using ToolkitDemo.Services;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ToolkitDemo
{
    [AutoRegisterForNavigation]
    public partial class App
    {
        /*
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor.
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App()
            : this(null)
        {
        }

        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MainPage/NavigationPage/HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.Register<ILogger, ConsoleLoggingService>();
            containerRegistry.RegisterSingleton<IMenuService, MenuService>();
            containerRegistry.Register<IClipboard, ClipboardImplementation>();
            containerRegistry.Register<ICodeSampleResolver, CodeSampleResolver>();
            IconFontRegistry.Register(new IconFont("fa-solid-900.ttf", "fas", typeof(AppFontIcons)));
        }
    }
}
