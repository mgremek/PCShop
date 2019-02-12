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
using System.Windows.Shapes;
using WPFSklep.ViewModel;

namespace WPFSklep
{
    /// <summary>
    /// Interaction logic for Logowanie.xaml
    /// </summary>
    public partial class Logowanie : Window
    {
        public Logowanie()
        {
            InitializeComponent();
            LogowanieViewModel lvm = new LogowanieViewModel();
            DataContext = lvm;
            if (lvm.CloseAction == null)
                lvm.CloseAction = new Action(this.Close);
        }

        private void pbHaslo_PasswordChanged(object sender, RoutedEventArgs e)
        { 
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Pass = ((PasswordBox)sender).Password; }
        }
    }

}
