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

namespace WPFSklep
{
    /// <summary>
    /// Interaction logic for Konfigurator.xaml
    /// </summary>
    public partial class Konfigurator : Window
    {
        public Konfigurator()
        {
            InitializeComponent();
            KonfiguratorViewModel kvm = new KonfiguratorViewModel();
            DataContext = kvm;
            if (kvm.CloseAction == null)
            {
                kvm.CloseAction = new Action(this.Close);

            }
        }
    }
}
