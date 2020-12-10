﻿using CoursWPF.AddressBook.Client.ViewModels;
using CoursWPF.AddressBook.Client.ViewModels.Abstracts;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoursWPF.AddressBook.Client.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        #region Constructors

        /// <summary>
        ///     Initialise une nouvelle instance de la classe <see cref="MainWindow"/>.
        /// </summary>
        public MainWindow(IViewModelPeople viewModel)
        {
            this.DataContext = viewModel;
            this.InitializeComponent();
        }

        #endregion

        #region Methods

        private void ButtonResetUIScaleFactor_Click(object sender, RoutedEventArgs e)
        {
            this.ScaleSlider.Value = 1;
            this.ScaleSlider.Value = 1;
        }

        #endregion
    }
}
