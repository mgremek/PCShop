using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSklep.ViewModel
{
    class KoszykViewModell : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Action CloseAction { get; set; }
        public CommandHandler ExecuteReturn { get; }
        public KoszykViewModell()
        {
            ExecuteReturn = new CommandHandler(ExeRet, () => true);
        }

        private void ExeRet()
        {
            CloseAction();
        }
    }
}
