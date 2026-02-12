using System;
using System.Collections.Generic;
using System.Text;
using VendeurGroupy.Data;
using VendeurGroupy.Models;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using VendeurGroupy.Views.UserControls;
using System.Collections.ObjectModel;

namespace VendeurGroupy.ViewModels
{
    internal class ClientViewModel
    {
        public readonly GroupyContext _context;
        public ObservableCollection<Clients> Clients { get; set; }
        public ClientViewModel()
        {
            _context = new GroupyContext();
            àClients = new ObservableCollection<Clients>(GetClients());
        }

        public List<Clients> GetClients()
        {
            try
            {
                Clients = new ObservableCollection<Clients>(
                    _context.Clients.Include(c => c.Utilisateur).ToList());

                return Clients.ToList();
                //if (Clients != null)
                //{
                //    return Clients;
                //}
                //else
                //{
                //    return new List<Clients>();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching clients: {ex.Message}");
                Console.WriteLine(ex.Message);
                return new List<Clients>();
            }
        }
    }
}   
