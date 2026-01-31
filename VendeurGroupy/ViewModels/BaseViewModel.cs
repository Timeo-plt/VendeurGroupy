using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using VendeurGroupy.Data;

namespace VendeurGroupy.ViewModels
{
    internal class BaseViewModel
    {
        private readonly GroupyContext _context;

        public BaseViewModel()
        {
            _context = new GroupyContext();
        }

        public async void Connexion()
        {
            Console.WriteLine("in test");
            bool canConnect = await _context.Database.CanConnectAsync();
            if (canConnect)
            {
                Trace.WriteLine("Connexion réussie à la base de données.");
            }
            else
            {
                Trace.WriteLine("Échec de la connexion à la base de données.");
            }
        }
        public void test()
        {
            Trace.WriteLine("in test");
        }
    }
}
