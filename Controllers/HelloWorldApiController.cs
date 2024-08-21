using Microsoft.AspNetCore.Mvc;
namespace HelloWorldWebApp.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HelloWorldApiController : ControllerBase
{
    // GET: api/helloworldapi
    [HttpGet]
    public ActionResult<string> Get()
    {
        Random rand = new Random();
        double temperatura = rand.NextDouble() * 50;

        if (temperatura >= 35)
        {
            string mensagem = $"A temperatura atingiu o valor de {temperatura:F2} graus";
            Console.WriteLine($"[x] Gerado: {mensagem}");
            return Ok(mensagem);
        }

        return Ok($"Temperatura abaixo do limite. A temperatura atingiu o valor de {temperatura:F2} graus");
    }
}