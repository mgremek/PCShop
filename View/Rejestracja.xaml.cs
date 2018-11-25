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
            DataContext = new RejestracjaViewModel();
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
        
        }

        private void btnDodajKonto_Click(object sender, RoutedEventArgs e)
        {
        //    UkryjLabele(); //<-ukrywa info o bledach

        //    //Połączenie z bazą danych
        //    Database db = new Database();
        //    bool czy = db.Connection();
        //    if (!czy)
        //        lblErrBd.Visibility = Visibility.Visible;
            

        //    string imie, nazwisko, email,adres,login,haslo1,haslo2;
        //    bool sprawdzDane=true;//flaga do kontroli, czy wszystkie dane są wpisane

        //    //imie
        //    if (tbImie.Text == "")
        //        sprawdzDane = false;
        //    imie = tbImie.Text;

        //    //nazwisko
        //    if (tbNazwisko.Text == "")
        //        sprawdzDane = false;
        //    nazwisko = tbNazwisko.Text;

        //    //Sprawdzanie poprawnosci adresu email
        //    email = this.tbEmail.Text;
        //    Regex regEmail = new Regex("^[a-z][a-z0-9_]*@[a-z0-9]*.[a-z]{2,3}$");
        //    if (!regEmail.IsMatch(email))
        //    {
        //        this.lblErrEmail.Visibility = Visibility.Visible;
        //        tbEmail.Clear();
        //        sprawdzDane = false;
        //    }


        //    //sprawdzanie czy login juz istnieje w bazie


        //    //sprawdzaniee czy haslo jest prawidlowe
        //    Regex regPass = new Regex("^[a-z0-9]{6,}$");
        //    haslo1 = pbHaslo1.Password;
        //    if (!regPass.IsMatch(haslo1))
        //    {
        //        this.lblErrHaslo.Visibility = Visibility.Visible;
        //        pbHaslo1.Clear();
        //        sprawdzDane = false;
        //    }
        //    //sprawdzanie czy hasla się zgadzają
        //    haslo2 = pbHaslo2.Password;
        //    if(!haslo2.Equals(haslo1))
        //    {
        //        lblErrHasla.Visibility = Visibility.Visible;
        //        pbHaslo2.Clear();
        //        sprawdzDane = false;
        //    }

               

        }
        private void UkryjLabele()
        {
            
        }

        private void pbHaslo1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password; }
        }
    }
}
