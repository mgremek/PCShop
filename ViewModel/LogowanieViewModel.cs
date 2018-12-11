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
        public CommandHandler ExecuteCommand { get; }
        public event PropertyChangedEventHandler PropertyChanged;
        public string Login { get; set; }
        public string Pass { get; set; }
        public Visibility lblErr { get; set; }
        public LogowanieViewModel()
        {
            ExecuteCommand = new CommandHandler(Execute, () => true);
        }
        private void Execute()
        {
            bool sprawdzDane = true;
            //polaczenie z bazą
            
        }
        
       
    }
}
