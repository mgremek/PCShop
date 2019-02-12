using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFSklep.ViewModel
{
    class KonfiguratorViewModel : INotifyPropertyChanged
    {
        WCF.ProduktyClient pc;
        public Action CloseAction { get; set; }
        WarKonfiguratorEntities wke;
        public CommandHandler ExecuteCommand { get; }
        public ObservableCollection<WCF.Products_TEST> ListaCPU { get; set; }
        public ObservableCollection<WCF.Products_TEST> ListaGPU { get; set; }
        public ObservableCollection<Products_TEST> ListaPlyty { get; set; }
        public ObservableCollection<Products_TEST> ListaRAM { get; set; }
        public ObservableCollection<Products_TEST> ListaMonitory { get; set; }
        public ObservableCollection<Products_TEST> ListaObudowy { get; set; }
        public CommandHandler ExecuteExit { get; private set; }

        private List<Products_TEST> listaProduktow;
        public KonfiguratorViewModel()
        {
            pc = new WCF.ProduktyClient();
            ExecuteCommand = new CommandHandler(Execute, () => true);
            wke = new WarKonfiguratorEntities();
            //Parallel.Invoke(() => listaProduktow=wke.Products_TEST.ToList());
            ////listaProduktow = wke.Products_TEST.ToList();
            //ListaCPU = new ObservableCollection<Products_TEST>(GetCPU());

            //Thread t2 = new Thread(() => ListaCPU = new ObservableCollection<WCF.Products_TEST>(GetCPU()));
            ListaCPU = new ObservableCollection<WCF.Products_TEST>(GetCPU());
            //t2.Start();
            //Thread t1 = new Thread(() => ListaGPU = new ObservableCollection<WCF.Products_TEST>(GetGPU()));
            //t1.Start();
            //ListaGPU = new ObservableCollection<Products_TEST>(GetGPU());
            //ListaPlyty = new ObservableCollection<Products_TEST>(GetPlyty());
            //ListaRAM = new ObservableCollection<Products_TEST>(GetRAM());
            //ListaMonitory = new ObservableCollection<Products_TEST>(GetMonitor());
            //ListaObudowy = new ObservableCollection<Products_TEST>(GetObudowa());
            //ExecuteExit = new CommandHandler(ExeExit, () => true);
        }
        //GET_CZESC
        #region
        private List<WCF.Products_TEST> GetCPU()
        {
            var prod=pc.GetProdukty().ToList();
            List<WCF.Products_TEST> query = new List<WCF.Products_TEST>();
            // Parallel.Invoke(() => { query = listaProduktow.Select(n => n).Where(a => a.SubID == 1).ToList(); });
            query = prod.Select(n => n).Where(n => n.SubID == 1).ToList();
            return query;
            //var query= listaProduktow.Select(n => n).Where(a => a.SubID == 1).ToList();
            //return query;

        }
        //private List<Products> GetCpuCustom()
        //{
        //    var qry = from b in listaProduktow
        //              where b.SubID == 1
        //              select new { b.ProdID, b.Manufacturers.Manufacturer_Name, b.Model, b.Price, b.SubCategory.Subcategory_name };

        //    var result = (from a in new KompyModel 
        //                  where a.SubId==1
        //                  select new PersonInformation { Name = a.Name, Age = a.Age }).ToList();
        //    //return qry.ToList<Products>();
        //}
        private List<WCF.Products_TEST> GetGPU()
        {
            WCF.ProduktyClient c = new WCF.ProduktyClient();

            var ptest = c.GetProdukty().ToList();
            List<WCF.Products_TEST> query = new List<WCF.Products_TEST>();
            //Parallel.Invoke(() =>query = listaProduktow.Select(n => n).Where(a => a.SubID == 2).ToList<Products_TEST>());
            //Parallel.Invoke(() => query = ptest.Select(n => n).Where(a => a.SubID == 2).ToList());
            query = ptest.Select(n => n).Where(a => a.SubID == 2).ToList();
            //var query1 = listaProduktow.Select(n => n).Where(a => a.SubID == 2).ToList();
            return ptest;
            //WCF.ProduktyClient c = new WCF.ProduktyClient();
            //var ptest = c.GetProdukty().ToList<WPFSklep.Products_TEST>();
            //return ptest;
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
        private void ExeExit()
        {
            CloseAction();
        }
    }
}
