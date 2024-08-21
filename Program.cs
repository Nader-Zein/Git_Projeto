var builder = WebApplication.CreateBuilder(args);
// Adiciona serviços ao contêiner.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
var app = builder.Build();
// Configura o pipeline de requisição HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllers();
app.Run();