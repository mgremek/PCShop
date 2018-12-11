using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFSklep.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public ICommand ExecuteRejestr { get; }
        public ICommand ExecuteLog { get; }
        public MainWindowViewModel()
        {
            ExecuteRejestr = new CommandHandler(ExeRejestr, () => true);
            ExecuteLog = new CommandHandler(ExeLog, () => true);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ExeRejestr()
        {
            Rejestracja rejestracja = new Rejestracja();
            rejestracja.ShowDialog();
        }
        public void ExeLog()
        {
            Logowanie logowanie = new Logowanie();
            logowanie.ShowDialog();
        }
    }
}
