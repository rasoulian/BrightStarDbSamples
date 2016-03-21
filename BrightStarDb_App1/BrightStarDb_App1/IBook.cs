using BrightstarDB.EntityFramework;

namespace BrightStarDb_App1
{
    [Entity]
    public interface IBook
    {
        int Code { get; set; }
        string Title { get; set; }
    }
}