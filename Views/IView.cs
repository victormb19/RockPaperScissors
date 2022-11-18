using RockPaperScissors.Controllers;

namespace RockPaperScissors.Views
{
    public interface IView
    {
        void Print(IController controller);
    }
}
