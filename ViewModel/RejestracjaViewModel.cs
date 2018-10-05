using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows;
using System.Text.RegularExpressions;

namespace WPFSklep.ViewModel
{
    class RejestracjaViewModel :INotifyPropertyChanged
    {
        public CommandHandler ExecuteCommand { get; }
        //--------------------------
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                // Implement with property changed handling for INotifyPropertyChanged
                if (!string.Equals(this.name, value))
                {
                    this.name = value;
                    //this.RaisePropertyChanged(); // Method to raise the PropertyChanged event in your BaseViewModel class...
                }
            }
        }
        private string surname;
        public string Surname
        {
            get { return this.surname;  }
            set
            {
                if(!string.Equals(this.surname,value))
                {
                    this.surname = value;
                }
            }
        }
        private string email;
        public string Email
        {
            get { return this.email; }
            set
            {
                if(!string.Equals(this.email,value))
                {
                    this.email = value;
                }
            }
        }
        private string haslo;
        public string Haslo
        {
            get { return this.haslo; }
            set
            {
                if(!string.Equals(this.haslo,value))
                {
                    this.haslo = value;
                }
            }
        }
        private string haslo2;
        public string Haslo2
        {
            get { return this.haslo2; }
            set
            {
                if(!string.Equals(this.haslo2,value))
                {
                    this.haslo2 = value;
                }
            }
        }

        //---------------------------------
        public RejestracjaViewModel()
        {
            ExecuteCommand = new CommandHandler(Execute, () => true);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Execute()
        {
            
            //UkryjLabele(); //<-ukrywa info o bledach

            ////Połączenie z bazą danych
            //Database db = new Database();
            //bool czy = db.Connection();
            //if (!czy)
            //    lblErrBd.Visibility = Visibility.Visible;


            string imie, nazwisko, email, adres, login, haslo1, haslo2;
            bool sprawdzDane = true;//flaga do kontroli, czy wszystkie dane są wpisane

            ////imie
            if (Name == "")
                sprawdzDane = false;
            imie = Name;

            ////nazwisko
            if (Surname == "")
                sprawdzDane = false;
            nazwisko = Surname;

            ////Sprawdzanie poprawnosci adresu email
            email = Email;
            Regex regEmail = new Regex("^[a-z][a-z0-9_]*@[a-z0-9]*.[a-z]{2,3}$");
            if (!regEmail.IsMatch(email))
            {
                //this.lblErrEmail.Visibility = Visibility.Visible; *** jak ustawić visibility labela z viewModel???
                //tbEmail.Clear();
                //sprawdzDane = false;
            }

            //sprawdzanie czy login juz istnieje w bazie
            //---------->to do

            //sprawdzaniee czy haslo jest prawidlowe
            Regex regPass = new Regex("^[a-z0-9]{6,}$");
            haslo1 = Haslo;
            if (!regPass.IsMatch(haslo1))
            {
                //this.lblErrHaslo.Visibility = Visibility.Visible; *** jak ustawić visibility labela z viewModel???
                //pbHaslo1.Clear();
                //sprawdzDane = false;
            }

            ////sprawdzanie czy hasla się zgadzają
            haslo2 = Haslo2;
            if (!haslo2.Equals(haslo1))
            {
                //    lblErrHasla.Visibility = Visibility.Visible; *** jak ustawić visibility labela z viewModel???
                //    pbHaslo2.Clear();
                //    sprawdzDane = false;
                //
            }

        }
        private void UkryjLabele()
        {
            //lblErrDane.Visibility = Visibility.Hidden;
            //this.lblErrEmail.Visibility = Visibility.Hidden;
            //this.lblErrHasla.Visibility = Visibility.Hidden;
            //this.lblErrHaslo.Visibility = Visibility.Hidden;
            //this.lblErrLogin.Visibility = Visibility.Hidden;
        }
    
    }
}
