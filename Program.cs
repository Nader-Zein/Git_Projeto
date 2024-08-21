var builder = WebApplication.CreateBuilder(args);
// Adiciona servi�os ao cont�iner.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
var app = builder.Build();
// Configura o pipeline de requisi��o HTTP.
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