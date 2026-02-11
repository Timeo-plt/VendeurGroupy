using System;
using System.Collections.Generic;
using System.Text;
using VendeurGroupy.Data;
using VendeurGroupy.Models;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using VendeurGroupy.Views.UserControls;


namespace VendeurGroupy.ViewModels
{

    public VendeursViewModel()
    {
        _context = new GroupyContext();
    }
    class VendeursViewModel
    {
    }
}
