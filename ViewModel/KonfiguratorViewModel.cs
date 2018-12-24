using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSklep.ViewModel
{
    class KonfiguratorViewModel : INotifyPropertyChanged
    {
        WarKonfiguratorEntities wke;
        public CommandHandler ExecuteCommand { get; }
        public ObservableCollection<Products_TEST> ListaCPU { get; set; }
        public ObservableCollection<Products_TEST> ListaGPU { get; set; }
        public ObservableCollection<Products_TEST> ListaPlyty { get; set; }
        public ObservableCollection<Products_TEST> ListaRAM { get; set; }
        public ObservableCollection<Products_TEST> ListaMonitory { get; set; }
        public ObservableCollection<Products_TEST> ListaObudowy { get; set; }

        private List<Products_TEST> listaProduktow;
        public KonfiguratorViewModel()
        {
            ExecuteCommand = new CommandHandler(Execute, () => true);
            wke = new WarKonfiguratorEntities();
            listaProduktow = wke.Products_TEST.ToList();
            ListaCPU = new ObservableCollection<Products_TEST>(GetCPU());
            ListaGPU = new ObservableCollection<Products_TEST>(GetGPU());
            ListaPlyty = new ObservableCollection<Products_TEST>(GetPlyty());
            ListaRAM = new ObservableCollection<Products_TEST>(GetRAM());
            ListaMonitory = new ObservableCollection<Products_TEST>(GetMonitor());
            ListaObudowy = new ObservableCollection<Products_TEST>(GetObudowa());   
        }
        //GET_CZESC
        #region
        private List<Products_TEST> GetCPU()
        {
            var query = listaProduktow.Select(n => n).Where(a => a.SubID == 1).ToList();
            return query.ToList() ;
            
        }
        private List<Products_TEST> GetGPU()
        {
            var query = listaProduktow.Select(n => n).Where(a => a.SubID == 2).ToList();
            return query.ToList();
        }
        private List<Products_TEST> GetPlyty()
        {
            var query = listaProduktow.Select(n => n).Where(a => a.SubID == 4).ToList();
            return query.ToList();
        }
        private List<Products_TEST> GetRAM()
        {
            var query = listaProduktow.Select(n => n).Where(a => a.SubID == 3).ToList();
            return query.ToList();
        }
        private List<Products_TEST> GetMonitor()
        {
            var query = listaProduktow.Select(n => n).Where(a => a.SubID == 9).ToList();
            return query.ToList();
        }
        private List<Products_TEST> GetObudowa()
        {
            var query = listaProduktow.Select(n => n).Where(a => a.SubID == 7).ToList();
            return query.ToList();
        }

        #endregion
        public event PropertyChangedEventHandler PropertyChanged;

        public void Execute()
        {

        }
    }
}
