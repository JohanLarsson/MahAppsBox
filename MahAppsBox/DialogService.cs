using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace MahAppsBox
{
    internal class DialogService : IDialogService
    {
        private MetroWindow MainWindow { get { return App.Current.MainWindow as MetroWindow; } }

        async Task<MessageDialogResult> IDialogService.ShowMessageDialog(string message, string title)
        {
            return await MainWindow.ShowMessageAsync(title, message);
        }
    }
}
