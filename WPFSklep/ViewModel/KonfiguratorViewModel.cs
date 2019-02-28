using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPFSklep.WCF;


namespace WPFSklep.ViewModel
{
    class KonfiguratorViewModel : INotifyPropertyChanged
    {
        WCF.ProduktyClient pc;
        public Action CloseAction { get; set; }
        public CommandHandler ExecuteCommand { get; }
        public ProduktyService.Products ProductActive {get; set;}
        public ObservableCollection<ProduktyService.Products> ListaCPU { get; set; }
        public ObservableCollection<ProduktyService.Products> ListaGPU { get; set; }
        public ObservableCollection<ProduktyService.Products> ListaPlyty { get; set; }
        public ObservableCollection<ProduktyService.Products> ListaRAM { get; set; }
        public ObservableCollection<ProduktyService.Products> ListaMonitory { get; set; }
        public ObservableCollection<ProduktyService.Products> ListaObudowy { get; set; }
        public CommandHandler ExecuteExit { get; private set; }
        public CommandHandler ExecuteDetails { get; private set; }

        public KonfiguratorViewModel()
        {
            pc = new WCF.ProduktyClient();
            ExecuteCommand = new CommandHandler(Execute, () => true);
            
            //Parallel.Invoke(() => listaProduktow=wke.Products_TEST.ToList());
            //Thread t2 = new Thread(() => ListaCPU = new ObservableCollection<WCF.Products_TEST>(GetCPU()));
            ListaCPU = new ObservableCollection<ProduktyService.Products>(GetProducts(1));
            ListaGPU = new ObservableCollection<ProduktyService.Products>(GetProducts(2));
            ListaRAM = new ObservableCollection<ProduktyService.Products>(GetProducts(3));
            ListaPlyty = new ObservableCollection<ProduktyService.Products>(GetProducts(4));
            ListaMonitory = new ObservableCollection<ProduktyService.Products>(GetProducts(9));
            ListaObudowy = new ObservableCollection<ProduktyService.Products>(GetProducts(7));
            //t2.Start();
            //Thread t1 = new Thread(() => ListaGPU = new ObservableCollection<WCF.Products_TEST>(GetGPU()));
            //t1.Start();
            ExecuteExit = new CommandHandler(ExeExit, () => true);
            ExecuteDetails = new CommandHandler(ExeDet, () => true);
        }

        //GET_CZESC

        private List<ProduktyService.Products> GetProducts(int SubId)
        {
            try
            {
                return pc.GetProdukty(SubId).ToList<ProduktyService.Products>();
            } catch(Exception)
            {
                return new List<ProduktyService.Products>();
            }
            
        }
        #region
        //private List<ProduktyService.Products_TEST> GetGPU()
        //{
        //    return pc.GetGpu().Take(20).ToList();
        //    /*
        //    var ptest = c.GetProdukty().ToList();
        //    List<WCF.Products_TEST> query = new List<WCF.Products_TEST>();
        //    //Parallel.Invoke(() =>query = listaProduktow.Select(n => n).Where(a => a.SubID == 2).ToList<Products_TEST>());
        //    //Parallel.Invoke(() => query = ptest.Select(n => n).Where(a => a.SubID == 2).ToList());
        //    query = ptest.Select(n => n).Where(a => a.SubID == 2).ToList();
        //    //var query1 = listaProduktow.Select(n => n).Where(a => a.SubID == 2).ToList();
        //    return ptest;
        //    //WCF.ProduktyClient c = new WCF.ProduktyClient();
        //    //var ptest = c.GetProdukty().ToList<WPFSklep.Products_TEST>();
        //    //return ptest;
        //    */
        //}
        //private List<ProduktyService.Products_TEST> GetPlyty()
        //{
        //    return pc.GetMotherboard().ToList();
        //}
        //private List<ProduktyService.Products_TEST> GetRAM()
        //{
        //    return pc.GetRam().ToList();
        //}
        //private List<ProduktyService.Products_TEST> GetMonitor()
        //{
        //    return pc.GetMonitor().ToList();
        //}
        //private List<ProduktyService.Products_TEST> GetObudowa()
        //{
        //    return pc.GetCase().ToList();
        //}

        #endregion
        public event PropertyChangedEventHandler PropertyChanged;

        public void Execute()
        {

        }
        private void ExeDet()
        {
            
            if (ProductActive!=null)
            { 
                var cos=pc.GetXml(ProductActive.ProdID);
                View.ProdDetails pd = new View.ProdDetails(cos);
                pd.ShowDialog();
            }
        }
        private void ExeExit()
        {
            CloseAction();
        }
    }
}
