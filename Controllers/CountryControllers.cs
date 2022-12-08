using Microsoft.AspNetCore.Mvc;

namespace Api_Web.Controllers;

[ApiController]
[Route("[controller]")]

public class CountryController : ControllerBase
{ 
    private readonly ApplicationDbContext _context;

    public CountryController(ApplicationDbContext dbContext)
    {
        this._context = dbContext;
    }

    // Récupère tous les Countries avec les Heroes associés 
    // https://stackoverflow.com/questions/51004760/asp-net-web-api-join-two-tables-to-make-an-array-of-objects
    [HttpGet]
    public IQueryable<Object> GetCountriesWithHeroes()
    {
        return _context.Heroes.Include(hero => hero.Country).Select(hero => new {
            Id = hero.Id,
            Name = hero.Name,
            Description = hero.Description,
            //Country = Country.First(c => c.Name) TODO FIX
        });
    }



    // Créer un Nouveau Country
    [HttpPost]
    public async Task<ActionResult<List<Country>>> CreateCountry(Country OneCountry)
    {
        _context.Countries.Add(OneCountry);
        await _context.SaveChangesAsync();
        return Ok("Le pays " + OneCountry.Name + " a bien été crée !");
    }
}