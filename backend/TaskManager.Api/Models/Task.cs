public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string Status { get; set; } = "pending"; // pendente, em progresso, concluída
    public int PersonId { get; set; }
    public Person Person { get; set; }
}