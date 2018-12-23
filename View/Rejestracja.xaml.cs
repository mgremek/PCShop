using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Rejestracja.xaml
    /// </summary>
    public partial class Rejestracja : Window
    {
        public Rejestracja()
        {
            InitializeComponent();
            //RejestracjaViewModel rvm = new RejestracjaViewModel();
            DataContext = new RejestracjaViewModel();
            //if (rvm.CloseAction == null)
            //    rvm.CloseAction = new Action(this.Close);
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
        
        }

        private void btnDodajKonto_Click(object sender, RoutedEventArgs e)
        {

        }
        private void UkryjLabele()
        {
            
        }

        private void pbHaslo1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Haslo = ((PasswordBox)sender).Password; }
        }

        private void pbHaslo2_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Haslo2 = ((PasswordBox)sender).Password; }
        }
    }
}
