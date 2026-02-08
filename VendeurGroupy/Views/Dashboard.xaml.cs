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
using System.Windows.Shapes;
using VendeurGroupy.Views.UserControls;

namespace VendeurGroupy
{
    /// <summary>
    /// Logique d'interaction pour Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public void Button_stock(object sender, RoutedEventArgs e)
        {

            MainContent.Content = new StockView();
        }
        public void Button_mouvement(object sender, RoutedEventArgs e)
        {

            MainContent.Content = new Mouvement();
        }
        public void Button_expedition(object sender, RoutedEventArgs e)
        {

            MainContent.Content = new Expeditions();
        }

        public void Button_client(object sender, RoutedEventArgs e)
        {

            MainContent.Content = new Liste_client();
        }

        public void Button_message(object sender, RoutedEventArgs e)
        {

            MainContent.Content = new Messages();
        }

        public void Button_notes(object sender, RoutedEventArgs e)
        {

            MainContent.Content = new ViewNotes();
        }
        public void Button_liste(object sender, RoutedEventArgs e)
        {

            MainContent.Content = new ViewProduits();
        }
        public void Button_prevente(object sender, RoutedEventArgs e)
        {

            MainContent.Content = new ViewPrevente();
        }
     }
 }      
