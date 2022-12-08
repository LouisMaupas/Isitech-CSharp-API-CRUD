using Microsoft.AspNetCore.Mvc;

namespace Api_Web.Controllers;

[ApiController]
[Route("[controller]")]

public class VillainController : ControllerBase
{ 
        private static List<Villain> villains = new List<Villain> {
        new Villain { Id = 1, Name = "méchant", Description="zefzeezg" },
        new Villain { Id = 2, Name = "mechantDeux", Description="ze^pogkoez zeoigj"},
    };

    private readonly ApplicationDbContext _context;

    public VillainController(ApplicationDbContext dbContext)
    {
        this._context = dbContext;
    }

    // Récupère tous les villains
    [HttpGet]
    public async Task<ActionResult<List<Villain>>> Get()
    {
        var myVillains = await _context.Villains.ToListAsync();
        return Ok(myVillains);
    }

    // Créer un Nouveau Villain
    [HttpPost]
    public async Task<ActionResult<List<Villain>>> CreateVillain(Villain oneVillain)
    {
        _context.Villains.Add(oneVillain);
        await _context.SaveChangesAsync();
        return Ok("Le Villain " + oneVillain.Name + " a bien été crée !");
    }

    // Méthode Delete
    [HttpDelete]
    public async Task<ActionResult<List<Villain>>> DeleteVillain(int id)
    {
        var myVillain = await _context.Villains.FindAsync(id);
        _context.Remove(myVillain);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // Méthode Patch
    [HttpPatch]
    public async Task<ActionResult<List<Villain>>> PutVillain(int id, Villain myVillain)
    {
        var myVillainToUpdate = await _context.Villains.FindAsync(id);
        myVillainToUpdate.Name = myVillain.Name;
        myVillainToUpdate.Description = myVillain.Description;
        await _context.SaveChangesAsync();
       return Ok("Le méchant " + myVillain.Name + " a bien été modifié !"); // TODO HTTP 204
    }
}