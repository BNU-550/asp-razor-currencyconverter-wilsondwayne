using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        
        public string FullName { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Dwayne";
        }

        public void OnPost()
        {
            if(String.IsNullOrWhiteSpace(FullName))
            {
                ViewData["Message"] = "Name is missing!";
                FullName = "Empty";
            }
            else
            {
                ViewData["Message"] = "Name is registered!";
            }

            }
        }
    }
