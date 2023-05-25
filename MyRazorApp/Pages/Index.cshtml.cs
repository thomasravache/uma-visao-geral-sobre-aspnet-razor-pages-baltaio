using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyRazorApp.Pages
{
  public class Index : PageModel
  {
    private readonly ILogger<Index> _logger;

    public Index(ILogger<Index> logger)
    {
      _logger = logger;
    }

    public void OnGet() // Sempre que fizer um get na pagina ele passa nesse método - obter
    {
    }

    public void OnPost() // Sempre que fizer um post na pagina ele passa aqui - enviar
    {

    }
  }
}