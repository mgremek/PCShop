using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFSklep.ViewModel
{
    class MainWindowViewModel
    {
        public ICommand ExecuteCommand { get; }
        public MainWindowViewModel()
        {
            ExecuteCommand = new CommandHandler(Execute, () => true);
        }
        public void Execute()
        {
            Rejestracja rejestracja = new Rejestracja();
            rejestracja.Show();
        }
    }
}
