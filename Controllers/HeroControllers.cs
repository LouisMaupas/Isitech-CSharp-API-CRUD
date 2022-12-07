using Microsoft.AspNetCore.Mvc;

namespace Api_Web.Controllers;

[ApiController]
[Route("[controller]")]

public class HeroController : ControllerBase
{

    private static List<Hero> heroes = new List<Hero> {
        new Hero { Id = 1, Name = "Iron Man", Description="Tony" },
        new Hero { Id = 2, Name = "Spider Man", Description="Peter"},
    };

    private readonly ApplicationDbContext _context;

    public HeroController(ApplicationDbContext dbContext)
    {
        this._context = dbContext;
    }

    // Récupère tous les héros
    [HttpGet]
    public async Task<ActionResult<List<Hero>>> Get()
    {
        var myHeroes = await _context.Heroes.ToListAsync();
        return Ok(myHeroes);
    }

    // Créer un Nouveau Hero
    [HttpPost]
    public async Task<ActionResult<List<Hero>>> CreateHero(Hero unHero)
    {
        _context.Heroes.Add(unHero);
        await _context.SaveChangesAsync();
        // return Ok("Le hero " + unHero + " a bien été crée !");
        return Ok("Le hero " + unHero.Name + " a bien été crée !");
    }

    // Méthode Delete
    [HttpDelete]
    public async Task<ActionResult<List<Hero>>> DeleteHero(int id)
    {
        var myHeroes = await _context.Heroes.FindAsync(id);
        _context.Remove(myHeroes);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // Méthode Patch
    [HttpPatch]
    public async Task<ActionResult<List<Hero>>> PutHero(int id, Hero myHero)
    {
        var myHeroToUpdate = await _context.Heroes.FindAsync(id);
        myHeroToUpdate.Name = myHero.Name;
        myHeroToUpdate.Description = myHero.Description;
        await _context.SaveChangesAsync();
       return Ok("Le hero " + myHero.Name + " a bien été modifié !");
    }
}