using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Muresan_Miriam_Lab8.Data;
using Muresan_Miriam_Lab8.Models;

namespace Muresan_Miriam_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Muresan_Miriam_Lab8.Data.Muresan_Miriam_Lab8Context _context;

        public IndexModel(Muresan_Miriam_Lab8.Data.Muresan_Miriam_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
