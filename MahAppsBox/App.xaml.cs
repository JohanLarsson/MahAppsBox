using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MahAppsBox.ViewModels;
using Ninject;

namespace MahAppsBox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var kernel = new StandardKernel();
            kernel.Bind<IDialogService>().To<DialogService>();
            kernel.Bind<IViewModel>().To<MainWindowViewModel>();

            var mainWindow = kernel.Get<MainWindow>();
            mainWindow.Show();
        }
    }
}
