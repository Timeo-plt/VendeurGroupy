using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using VendeurGroupy.Data;
using Microsoft.EntityFrameworkCore;

namespace VendeurGroupy.ViewModels
{
    internal class BaseViewModel
    {
        public readonly GroupyContext _context;

        public BaseViewModel()
        {
            _context = new GroupyContext();
        }

        public async void Connexion(MainWindow mainWindow)
        {
            bool canConnect = await _context.Database.CanConnectAsync();
            if (canConnect)
            {
                try
                {
                    var user = await _context.Utilisateurs.FirstOrDefaultAsync(u => u.email == mainWindow.Identifiant.Text && u.mot_de_passe == mainWindow.mot_de_passe.Password);
                    if (user != null)
                    {
                        MessageBox.Show("connexion reussie");
                        Menu menu = new Menu();
                        menu.Show();
                        mainWindow.Close();
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe incorrect");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la connexion à la base de données : {ex.Message}");
                    return;
                }
            }
        }
        public void test()
        {
            Trace.WriteLine("in test");
        }
    }
}
