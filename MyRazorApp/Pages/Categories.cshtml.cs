using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages;
public class Categories : PageModel
{
    public List<Category> CategoryList { get; set; } = new(); // syntax sugar de new List<Category>();

    // Se não for especificado de onde vem os parametros o .net vai procurar nas rotas, queries e etc
    public void OnGet(
        [FromRoute] int skip = 0,
        [FromRoute] int take = 25
    ) // Sempre que fizer um get na pagina ele passa nesse método - obter
    {
        // await Task.Delay(2000);

        var temp = new List<Category>();
        for (int index = 0; index <= 1787; index++)
        {
            temp.Add(new Category
            (
                Id: index + 1,
                Title: $"Categoria {index}",
                Price: index*18.95M
            ));
        }

        CategoryList = temp
            .Skip(skip)
            .Take(take)
            .ToList();
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