using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace WPFSklep.ViewModel
{
    class LogowanieViewModel : INotifyPropertyChanged
    {
        WCF.ProduktyClient wcf;
        public Action CloseAction { get; set; }
        public CommandHandler ExecuteCommand { get; }
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged(string propertyName_)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName_));
            }
        }
        //public string Login { get; set; }
        private string login = "";
        public string Login
        {
            get { return login; }
            set
            {
                if (value != login)
                {
                    login = value;
                    RaisePropertyChanged("Login");
                }
            }
        }
        //---------------------------
        public string pass { get; set; }
        public string Pass
        {
            get { return pass; }
            set
            {
                if (value != pass)
                {
                    pass = value;
                    RaisePropertyChanged("Pass");
                }
            }
        }
        //--------------------------------
       
        private bool lblErr;

        public bool LblErr
        {
            get { return lblErr; }
            set
            {
                if( value!=lblErr )
                {
                    lblErr = value;
                    RaisePropertyChanged("LblErr");
                }
               
            }
        }

        public LogowanieViewModel()
        {
            ExecuteCommand = new CommandHandler(Execute, () => true);
            wcf = new WCF.ProduktyClient();
            LblErr = false;
        }
        private void Execute()
        {          
           if (wcf.IsLogged(Pass,Login))
            {
                CloseAction();
            }
           else
            {
                Login = "";
                Pass = "";
                LblErr = true;
            }           
        }              
    }
}
