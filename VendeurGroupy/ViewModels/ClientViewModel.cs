using System;
using System.Collections.Generic;
using System.Text;
using VendeurGroupy.Data;
using VendeurGroupy.Models;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VendeurGroupy.ViewModels
{
    internal class ClientViewModel
    {
        public readonly GroupyContext _context;
        public ClientViewModel()
        {
            _context = new GroupyContext();
        }

        public List<Clients> GetClients()
        {
            try
            {
                var ListeClient = _context.Clients.ToList();
                if (ListeClient != null)
                {
                    return ListeClient;
                }
                else
                {
                    return new List<Clients>();
                }
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
