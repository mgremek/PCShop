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
        public string Login { get; set; }
        public string Pass { get; set; }
        public Visibility lblErr { get; set; }
        public LogowanieViewModel()
        {
            ExecuteCommand = new CommandHandler(Execute, () => true);
            wcf = new WCF.ProduktyClient();
        }
        private void Execute()
        {
            
           if (wcf.IsLogged(Pass,Login))
            {
                CloseAction();
            }
           else
            {
                // pokaz labele o zlym hasle
            }
            
        }
        
       
    }
}
