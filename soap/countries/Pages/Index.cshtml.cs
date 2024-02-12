using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace continents.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<tCountryCodeAndName> Countries;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        Countries = new List<tCountryCodeAndName>();
    }

    public async Task OnGet()
    {
        var client = new CountryInfoServiceSoapTypeClient(CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap12);
        var result = await client.ListOfCountryNamesByNameAsync();
        Countries = result.Body.ListOfCountryNamesByNameResult.ToList();
    }
}
