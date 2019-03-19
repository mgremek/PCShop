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
        WarKonfiguratorEntities wke;
        public CommandHandler ExecuteCommand { get; }
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged(string propertyName_)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName_));
            }
        }
        //--------TEXTBOXY properties
        #region 
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
                    RaisePropertyChanged("Name"); // Method to raise the PropertyChanged event in your BaseViewModel class...
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
                    RaisePropertyChanged("Surname");
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
                    RaisePropertyChanged("Email");
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
                    RaisePropertyChanged("Haslo");
                }
            }
        }
        private string haslo2;
        public string Haslo2
        {
            get { return this.haslo2; }
            set
            {
                if(!string.Equals(this.haslo2, value))
                {
                    this.haslo2 = value;
                    RaisePropertyChanged("Haslo2");
                }
            }
        }
        public string Address { get; set; }
        private string login;
        public string Login
        {
            get { return login; }
            set
            {
                if (!string.Equals(this.login, value))
                {
                    this.login = value;
                    RaisePropertyChanged("Login");
                }
            }

        }
        #endregion
        //-------------ERROR-LABELE  
        private Visibility lblErrDane;
        public Visibility LblErrDane
        {
            get { return lblErrDane; }
            set
            {
                if(value!=lblErrDane)
                {
                    lblErrDane = value;
                    RaisePropertyChanged("LblErrDane");
                }               
            }
        }

        private Visibility lblErrBD;
        public Visibility LblErrBD
        {
            get { return lblErrBD; }
            set
            {
                if (value != lblErrBD)
                {
                    lblErrBD = value;
                    RaisePropertyChanged("LblErrBD");
                }
            }
        }
        //public Visibility LblErrDane { get; private set; }
        public Visibility lblErrHasla;
        public Visibility LblErrHasla
        {
            get { return lblErrHasla; }
            set
            {
                if (value != lblErrHasla)
                {
                    lblErrHasla = value;
                    RaisePropertyChanged("LblErrHasla");
                }
            }
        }

        public Visibility lblErrHaslo;
        public Visibility LblErrHaslo
        {
            get { return lblErrHaslo; }
            set
            {
                if (value != lblErrHaslo)
                {
                    lblErrHaslo = value;
                    RaisePropertyChanged("LblErrHaslo");
                }
            }
        }
        public Visibility lblErrLogin { get; private set; }
        public Visibility LblErrLogin
        {
            get { return lblErrLogin; }
            set
            {
                if (value != lblErrLogin)
                {
                    lblErrLogin = value;
                    RaisePropertyChanged("LblErrLogin");
                }
            }
        }
        public Visibility lblErrEmail;
        public Visibility LblErrEmail
        {
            get { return lblErrEmail; }
            set
            {
                if (value != lblErrEmail)
                {
                    lblErrEmail = value;
                    RaisePropertyChanged("LblErrEmail");
                }
            }
        }

        public bool lblErrDane1 { get; set; }

        //---------------ZAMYKANIE OKNA
        public Action CloseAction { get; set; }
        //---------------------------------
        public RejestracjaViewModel()
        {
            ExecuteCommand = new CommandHandler(Execute, () => true);
            UkryjLabele();
            wke = new WarKonfiguratorEntities();
        }

        private void Execute()
        {
            bool sprawdzDane = true;//flaga do kontroli, czy wszystkie dane są wpisane

            ////imie
            if (Name == "" || Name==null)
            { 
                sprawdzDane = false;
                LblErrDane = Visibility.Visible;
               // lblErrDane1 = true;
            }

            ////nazwisko
            if (Surname == "" || Surname==null)
            {
                sprawdzDane = false;
                LblErrDane = Visibility.Visible;
            }

            ////Sprawdzanie poprawnosci adresu email
            Regex regEmail = new Regex("^[a-z][a-z0-9_]*@[a-z0-9]*.[a-z]{2,3}$");
            if(Email!="" && Email!=null)
            {
                 if (!regEmail.IsMatch(Email))
                 {
                     LblErrEmail = Visibility.Visible;
                     Email = "";
                     sprawdzDane = false;
                 }
                 else
                 {
                    LblErrEmail = Visibility.Visible;
                    Email = null;
                    sprawdzDane = false;
                 }
            }
            else
            {
                LblErrEmail = Visibility.Visible;
                Email = null;
                sprawdzDane = false;
            }


            //sprawdzanie czy login juz istnieje w bazie
            if (Login!="" || Login!=null)
            {
                var lista=wke.clients.Select(n => n)
                                     .Where(n => n.Login == Login)
                                     .ToList();
                if(lista.Count>0)
                {
                    Login = "";
                    sprawdzDane = false;
                    LblErrLogin = Visibility.Visible;
                }
            }


            //sprawdzaniee czy haslo jest prawidlowe
            Regex regPass = new Regex("^[a-z0-9]{6,}$");
            if(Haslo!=null)
                if (!regPass.IsMatch(Haslo))
                {
                    LblErrHaslo = Visibility.Visible;
                    Haslo = "";
                    sprawdzDane = false;
                }
            else
                {
                    LblErrHasla = Visibility.Visible;
                    Haslo2 = "";
                    sprawdzDane = false;
                }

            ////sprawdzanie czy hasla się zgadzają
            if (Haslo2==null || Haslo2=="")
            {
                LblErrHasla = Visibility.Visible;
                Haslo2 = "";
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
            //LblErrDane = Visibility.Hidden;
            LblErrEmail = Visibility.Hidden;
            LblErrHasla = Visibility.Hidden;
            LblErrHaslo = Visibility.Hidden;
            LblErrLogin = Visibility.Hidden;
            LblErrBD = Visibility.Hidden;
            lblErrDane = Visibility.Hidden;
        }
    
    }
}
