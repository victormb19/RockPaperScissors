using RockPaperScissors.Controllers;
using RockPaperScissors.Views;

namespace RockPaperScissors
{
    public abstract class RockPaperScissor
    {
        IView view;
        IController controller;

        public RockPaperScissor()
        {
            view = GetView();
            controller = GetController();
        }
        
        protected abstract IView GetView();

        protected abstract IController GetController();

        public void Play()
        {
            do
                view.Print(controller);
            while (!controller.IsGameOver());
        }
    }
}
