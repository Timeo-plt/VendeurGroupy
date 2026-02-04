using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VendeurGroupy.Data;
using VendeurGroupy.ViewModels;

namespace VendeurGroupy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseViewModel vm; 
        public MainWindow()
        {
            InitializeComponent();
            vm = new BaseViewModel();
            Trace.WriteLine("MainWindow initialized");
        }
     
        public void CallConnexion(object sender , RoutedEventArgs e)
        {
            //vm.test();
            ////Trace.WriteLine("appel de la connexion");
            vm.Connexion(this);

        }

    }
}