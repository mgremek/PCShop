using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFSklep.ViewModel
{
    class CommandHandler : ICommand
    {
        /// <summary>
        /// Delegaty
        /// </summary>
        private Action action;
        private Func<bool> canExecute;

        public CommandHandler(Action action,Func<bool> canExecute)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return canExecute();
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
