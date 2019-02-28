using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSklep.Model;

namespace WPFSklep.ViewModel
{
    class ProductDetailsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Action CloseAction;
        public string ProdDetails { get; set; }
        public CommandHandler ExecuteBack { get; private set; }
        XmlParsing xparse;
        public ProductDetailsViewModel(string spec)
        {
            xparse = new XmlParsing(spec);
            List<string> lista = new List<string>(xparse.ParseXml());
            
            foreach (string item in lista)
            { 
                ProdDetails += item + "\n";
            }
            ProdDetails=ProdDetails.Remove(ProdDetails.Count() - 2);

            ExecuteBack = new CommandHandler(ExeBack, () => true);
            
        }

        private void ExeBack()
        {
            CloseAction();
        }

        public ProductDetailsViewModel()
        {

        }

    }
}
