using _5dars.Models;
using _5dars.Services;

namespace _5dars;

internal class Homework
{
    static void Main(string[] args)
    {
        IBlackBoardService blackBoardService = new BlackBoardService();
        BlackBoard blackBoard = new BlackBoard
        {
            Title = "Math Homework",
            Description = "Complete exercises 1 to 10 on page 42.",
            CreatedAt = DateTime.Now,
            IsActive = true
        };

        Guid blackBoardId = blackBoardService.AddBlackBoard(blackBoard);

    }
}
