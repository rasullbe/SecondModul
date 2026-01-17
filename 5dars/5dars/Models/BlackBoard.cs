namespace _5dars.Models;

public class BlackBoard
{
    public Guid BlackBoardId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }
}
