﻿using MahAppsBox.ViewModels;

namespace MahAppsBox
{
    using MahApps.Metro.Controls;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow(IViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
