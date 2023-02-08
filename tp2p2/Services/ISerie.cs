using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp2p2.Models;

namespace tp2p2.Services
{
    public interface ISerie
    {
        Task<List<Serie>> GetDevisesAsync(string nomControleur);
    }
}
