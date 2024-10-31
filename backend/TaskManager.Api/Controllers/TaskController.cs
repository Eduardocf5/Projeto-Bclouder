[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private readonly TaskManagerContext _context;

    public TaskController(TaskManagerContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetTasks()
    {
        var tasks = await _context.Tasks.Include(t => t.Person).ToListAsync();
        return Ok(tasks);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTask([FromBody] Task task)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        _context.Tasks.Add(task);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTasks), new { id = task.Id }, task);
    }
}