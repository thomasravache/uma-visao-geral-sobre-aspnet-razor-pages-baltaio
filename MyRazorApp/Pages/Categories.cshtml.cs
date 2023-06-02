using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages;
public class Categories : PageModel
{
    public List<Category> CategoryList { get; set; } = new(); // syntax sugar de new List<Category>();

    public async Task OnGet() // Sempre que fizer um get na pagina ele passa nesse método - obter
    {
        await Task.Delay(2000);

        for (int index = 0; index <= 100; index++)
        {
            CategoryList.Add(new Category
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