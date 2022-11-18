using RockPaperScissors.Controllers;
using RockPaperScissors.Utils;
using RockPaperScissors.Views;

namespace RockPaperScissors
{
    class RockPaperScissorStandalone : RockPaperScissor
    {
        protected override IController GetController()
        {
           return new RandomChoiceController();
        }

        protected override IView GetView()
        {
            return new RockPaperScissorView(new ConsoleOuput());
        }
    }
}
