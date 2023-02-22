using MigrationDemo.Services;
using MigrationDemo.Views;
using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace MigrationDemo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
