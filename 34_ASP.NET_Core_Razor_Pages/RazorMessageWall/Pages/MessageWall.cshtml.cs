using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorMessageWall.Pages
{
    public class MessageWall : PageModel
    {
        private readonly ILogger<MessageWall> _logger;

        [BindProperty]
        public string Message { get; set; }

        [BindProperty]
        public List<string> Messages { get; set; } = new List<string>();

        public MessageWall(ILogger<MessageWall> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Messages.Add(Message);
            return Page();
        }
    }
}