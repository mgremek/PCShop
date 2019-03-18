using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using WPFSklep.View;

namespace WPFSklep.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        //public delegate void NextPrimeDelegate(); // delegat do Dispatchera
        public Action CloseAction { get; set; }
        public ICommand ExecuteRejestr { get; }
        public ICommand ExecuteLog { get; }
        public ICommand ExecuteKonf { get; }
        public ICommand ExecuteExit { get; }
        public ICommand ExecuteBasket { get; set; }
        public MainWindowViewModel()
        {
            ExecuteRejestr = new CommandHandler(ExeRejestr, () => true);
            ExecuteLog = new CommandHandler(ExeLog, () => true);
            ExecuteKonf = new CommandHandler(ExeKonf, () => true);
            ExecuteExit = new CommandHandler(ExeExit, () => true);
            ExecuteBasket = new CommandHandler(ExeBask, () => true);
        }

        private void ExeBask()
        {
            KoszykView kvm = new KoszykView();
            kvm.ShowDialog();          
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
        public void ExeKonf()
        {
            Konfigurator k = new Konfigurator();
            k.ShowDialog();
        }
        public void ExeExit()
        {
            CloseAction();
        }
    }
}
