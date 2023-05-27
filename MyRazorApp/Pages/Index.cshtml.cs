using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages;

public class Index : PageModel
{
    public List<Category> Categories { get; set; } = new(); // syntax sugar de new List<Category>();

    public async Task OnGet() // Sempre que fizer um get na pagina ele passa nesse método - obter
    {
        await Task.Delay(5000);

        for (int index = 0; index <= 100; index++)
        {
            Categories.Add(new Category
            (
                Id: index + 1,
                Title: $"Categoria {index}",
                Price: index*18.95M
            ));
        }
    }

    public void OnPost() // Sempre que fizer um post na pagina ele passa aqui - enviar
    {

    }
}

// Record -> classe enxuta -> não tem comportamento
public record Category(
    int Id,
    string Title,
    decimal Price
);