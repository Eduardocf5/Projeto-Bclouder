[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private readonly TaskManagerContext _context;

    public PersonController(TaskManagerContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetPeople()
    {
        var people = await _context.People.Include(p => p.Tasks).ToListAsync();
        return Ok(people);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePerson([FromBody] Person person)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        _context.People.Add(person);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetPeople), new { id = person.Id }, person);
    }
}