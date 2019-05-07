using Autofac;
using Autofac.Features.ResolveAnything;
using Common;
using PeopleViewer.Presentation;
using PersonRepository.Caching;
using PersonRepository.Service;
using PersonRepository.CSV;
using System.Windows;

namespace PeopleViewer.Autofac
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
            Application.Current.MainWindow.Title = "With Dependency Injection - Autofac";
            Application.Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {

        }

        private void ComposeObjects()
        {

        }
    }
}
