using _5dars.Services;
using _5dars.Models;
namespace _5dars.Services;

public class BlackBoardService : IBlackBoardService
{
    List<BlackBoard> blackBoards;
    public BlackBoardService()
    {
        blackBoards = new List<BlackBoard>();
    }
    public Guid AddBlackBoard(BlackBoard blackBoard)
    {
        blackBoard.BlackBoardId = Guid.NewGuid();
        blackBoards.Add(blackBoard);
        return blackBoard.BlackBoardId;
    }
    public bool DeleteBlackBoard(Guid blackBoardId)
    {
        foreach (var blackBoard in blackBoards)
        {
            if (blackBoard.BlackBoardId == blackBoardId)
            {
                blackBoards.Remove(blackBoard);
                return true;
            }
        }
        return false;
    }
    public List<BlackBoard> GetAllBlackBoards()
    {
        return blackBoards;
    }
    public BlackBoard? GetBlackBoardById(Guid blackBoardId)
    {
        foreach (var blackBoard in blackBoards)
        {
            if (blackBoard.BlackBoardId == blackBoardId)
            {
                return blackBoard;
            }
        }
        return null;
    }
    public bool UpdateBlackBoard(BlackBoard blackBoard)
    {
        foreach (var existingBlackBoard in blackBoards)
        {
            if (existingBlackBoard.BlackBoardId == blackBoard.BlackBoardId)
            {
                existingBlackBoard.Title = blackBoard.Title;
                existingBlackBoard.Description = blackBoard.Description;
                existingBlackBoard.CreatedAt = blackBoard.CreatedAt;
                existingBlackBoard.IsActive = blackBoard.IsActive;
                return true;
            }
        }
        return false;
    }
}
