using _5dars.Models;

namespace _5dars.Services;

public interface IBlackBoardService
{
    public Guid AddBlackBoard(BlackBoard blackBoard);
    public bool UpdateBlackBoard(BlackBoard blackBoard);
    public bool DeleteBlackBoard(Guid blackBoardId);
    public BlackBoard? GetBlackBoardById(Guid blackBoardId);
    public List<BlackBoard> GetAllBlackBoards();
}
