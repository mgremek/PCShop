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

namespace WPFSklep.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public delegate void NextPrimeDelegate(); // delegat do Dispatchera
        public Action CloseAction { get; set; }
        public ICommand ExecuteRejestr { get; }
        public ICommand ExecuteLog { get; }
        public ICommand ExecuteKonf { get; }
        public ICommand ExecuteExit { get; }
        public MainWindowViewModel()
        {
            ExecuteRejestr = new CommandHandler(ExeRejestr, () => true);
            ExecuteLog = new CommandHandler(ExeLog, () => true);
            ExecuteKonf = new CommandHandler(ExeKonf, () => true);
            ExecuteExit = new CommandHandler(ExeExit, () => true);
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
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new NextPrimeDelegate(ConfigThread));
            //Thread t = new Thread(ConfigThread);

            //t.Start();
        }
        public void ExeExit()
        {
            CloseAction();
        }
        private void ConfigThread()
        {
            Konfigurator k = new Konfigurator();
            k.ShowDialog();
        }
    }
}
