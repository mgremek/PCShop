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
        WarKonfiguratorEntities wke;
        public Action CloseAction { get; set; }
        public CommandHandler ExecuteCommand { get; }
        public event PropertyChangedEventHandler PropertyChanged;
        public string Login { get; set; }
        public string Pass { get; set; }
        public Visibility lblErr { get; set; }
        public LogowanieViewModel()
        {
            ExecuteCommand = new CommandHandler(Execute, () => true);
            wke = new WarKonfiguratorEntities();
        }
        private void Execute()
        {
            bool sprawdzDane = true;
            Parallel.Invoke(() =>
            {
                //if ((Pass != "" || Pass != null) && (Login != "" || Login != null))
                //{
                //    var login = wke.clients.Select(n => n)
                //                    .Where(n => n.Login == Login)
                //                    .Where(n => n.Pass == Pass)
                //                    .ToList();
                //    if (login.Count < 1) sprawdzDane = false;

                //}
                if ((Pass != "" || Pass != null) && (Login != "" || Login != null))
                { 
                    var i = (from c in wke.clients
                             where c.Login == Login
                             where c.Pass==Pass
                             select c.client_ID).FirstOrDefault();
                   // if (i) sprawdzDane = false;
                }
            }
            );
           if (sprawdzDane)
            {
                CloseAction();
            }
            
        }
        
       
    }
}
