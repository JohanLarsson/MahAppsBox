using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MahApps.Metro.Controls.Dialogs;

namespace MahAppsBox
{
    public interface IDialogService
    {
        Task<MessageDialogResult> ShowMessageDialog(string message, string title = null);
    }
}
