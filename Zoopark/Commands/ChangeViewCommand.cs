using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Zoopark.ViewModel;

namespace Zoopark.Commands
{
    public class ChangeViewCommand : CommandBase
    {
        private LoginViewModel currentViewModel;

        public ChangeViewCommand(ViewModelBase currentViewModel)
        {
            this.currentViewModel = (LoginViewModel)currentViewModel;
        }

        public override void Execute(object parameter)
        {
                switch (parameter)
            {

                case "Menu":
                    //if (currentViewModel.ValidateLogin() != 0)
                        currentViewModel.ViewModel = new MenuViewModel();
                  //  else { MessageBox.Show("Невалидни данни за вход"); }
                    break;
                case "Animals":
                   currentViewModel.ViewModel = new AnimalsViewModel();

                    break;
                case "Events":
                   currentViewModel.ViewModel = new EventsViewModel();

                    break;
                case "Tickets":

                   currentViewModel.ViewModel = new TicketsViewModel();
                    break;
                default:
                    break;
            }
        }
    }
}
