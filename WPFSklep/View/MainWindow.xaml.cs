﻿using System;
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
using System.Windows.Shapes;
using WPFSklep.ViewModel;

namespace WPFSklep.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel mvm = new MainWindowViewModel();
            DataContext = mvm;
            if(mvm.CloseAction==null)
            {
                mvm.CloseAction = new Action(this.Close);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e) { }
        private void btnZalogujsie_Click(object sender, RoutedEventArgs e) { }

        private void btnZarejestrujsie_Click(object sender, RoutedEventArgs e) { }
        
    }
}