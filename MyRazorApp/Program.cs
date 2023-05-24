var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(); // Adicionando suporte para páginas razor

var app = builder.Build();

app.UseHttpsRedirection(); // Usar HTTPS
app.UseStaticFiles(); // Arquivs estaticos (css, js, imagens, jsons, etc..) precisa ter a pasta wwwroot

// Auxilia no mapeamento das paginas e criacao de urls personalizadas
app.UseRouting();
app.MapRazorPages();

app.Run();
