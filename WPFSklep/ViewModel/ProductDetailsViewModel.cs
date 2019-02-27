using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSklep.ViewModel
{
    class ProductDetailsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string ProdDetails { get; set; }
        public ProductDetailsViewModel(string xml)
        {
            ProdDetails = xml;
        }
        public ProductDetailsViewModel()
        {

        }
    }
}
