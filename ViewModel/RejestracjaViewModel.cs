using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows;
using System.Text.RegularExpressions;
using System.Security;

namespace WPFSklep.ViewModel
{
    class RejestracjaViewModel :INotifyPropertyChanged
    {
        public CommandHandler ExecuteCommand { get; }

        //--------TEXTBOXY
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
        public string Address { get; set; }

        //-------------ERROR-LABELE
        public Visibility LblErrEmail { get; private set; }
        public Visibility LblErrBD { get; private set; }
        public Visibility LblErrDane { get; private set; }
        public Visibility LblErrHasla { get; private set; }
        public Visibility LblErrHaslo { get; private set; }
        public Visibility LblErrLogin { get; private set; }

        //---------------ZAMYKANIE OKNA
        public Action CloseAction { get; set; }
        //---------------------------------
        public RejestracjaViewModel()
        {
            ExecuteCommand = new CommandHandler(Execute, () => true);
            UkryjLabele();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Execute()
        {
            bool sprawdzDane = true;//flaga do kontroli, czy wszystkie dane są wpisane

            ////Połączenie z bazą danych
            //Database db = new Database();
            //bool czy = db.Connection();
            //if (!czy)
            //    lblErrBd.Visibility = Visibility.Visible;

            

            ////imie
            if (Name == "" || Name==null)
            { 
                sprawdzDane = false;
                LblErrDane = Visibility.Visible;
            }

            ////nazwisko
            if (Surname == "" || Surname==null)
            {
                sprawdzDane = false;
                LblErrDane = Visibility.Visible;
            }

            ////Sprawdzanie poprawnosci adresu email
            Regex regEmail = new Regex("^[a-z][a-z0-9_]*@[a-z0-9]*.[a-z]{2,3}$");
            if(Email!=null)
                 if (!regEmail.IsMatch(Email))
                 {
                     LblErrEmail = Visibility.Visible;
                     Email = null;
                     sprawdzDane = false;
                 }
            else
                {
                    LblErrEmail = Visibility.Visible;
                    Email = null;
                    sprawdzDane = false;
                }


            //sprawdzanie czy login juz istnieje w bazie
            //---------->to do


            //sprawdzaniee czy haslo jest prawidlowe
            Regex regPass = new Regex("^[a-z0-9]{6,}$");
            if(Haslo!=null)
                if (!regPass.IsMatch(Haslo))
                {
                    LblErrHaslo = Visibility.Visible;
                    Haslo = null;
                    sprawdzDane = false;
                }
            else
                {
                    LblErrHasla = Visibility.Visible;
                    Haslo2 = null;
                    sprawdzDane = false;
                }

            ////sprawdzanie czy hasla się zgadzają
            if (Haslo2==null || Haslo2=="")
            {
                LblErrHasla = Visibility.Visible;
                Haslo2 = null;
                sprawdzDane = false;
            }
            else
                if (!Haslo.Equals(Haslo2))
                {
                    LblErrHasla= Visibility.Visible;
                    Haslo2 = null;
                    sprawdzDane = false;
                }
            if(sprawdzDane==false)
            {
                
            }
            else
            {
                CloseAction();
            }
        }
        private void UkryjLabele()
        {
            LblErrDane = Visibility.Hidden;
            LblErrEmail = Visibility.Hidden;
            LblErrHasla = Visibility.Hidden;
            LblErrHaslo = Visibility.Hidden;
            LblErrLogin = Visibility.Hidden;
            LblErrBD = Visibility.Hidden;
        }
    
    }
}
