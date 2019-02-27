using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFSklep.View
{
    /// <summary>
    /// Interaction logic for ProdDetails.xaml
    /// </summary>
    public partial class ProdDetails : Window
    {
        public ProdDetails(string xml)
        {
            InitializeComponent();

            ViewModel.ProductDetailsViewModel pdv = new ViewModel.ProductDetailsViewModel(xml);
            DataContext = pdv;
        }
    }
}
