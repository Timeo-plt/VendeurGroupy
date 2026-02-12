using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VendeurGroupy.ViewModels;

namespace VendeurGroupy.Views.UserControls
{
    /// <summary>
    /// Logique d'interaction pour Liste_client.xaml
    /// </summary>
    public partial class Liste_client : UserControl
    {
        ClientViewModel cvm;
        public Liste_client()
        {
            InitializeComponent();
            cvm = new ClientViewModel();
            cvm.GetClients();
            DataContext = cvm;
        }

    }
}
