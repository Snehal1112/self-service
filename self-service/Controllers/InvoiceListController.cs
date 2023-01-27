using Microsoft.AspNetCore.Mvc;

namespace self_service.Controllers;

[ApiController]
[Route("[controller]")]
public class InvoiceListController : ControllerBase
{
    
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<InvoiceListController> _logger;

    public InvoiceListController(ILogger<InvoiceListController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetInvoiceList/{id}")]
    public IEnumerable<InvoiceList> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new InvoiceList
        {
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            Total = "2223333"
        })
        .ToArray();
    }

    [HttpPost("GetInvoices")]
    public IEnumerable<InvoiceList>? SetInvoice()
    {
        return null;
    }

    [HttpGet("{id}")]
    public IEnumerable<InvoiceList> GetInvoices()
    {
        return Enumerable.Range(1, 5).Select(index => new InvoiceList
        {
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            Total = "2223333"
        })
        .ToArray();
    }
}