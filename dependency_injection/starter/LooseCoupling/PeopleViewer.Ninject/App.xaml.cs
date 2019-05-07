using Common;
using Ninject;
using PersonRepository.Caching;
using PersonRepository.CSV;
using PersonRepository.Service;
using System.Windows;

namespace PeopleViewer.Ninject
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
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
