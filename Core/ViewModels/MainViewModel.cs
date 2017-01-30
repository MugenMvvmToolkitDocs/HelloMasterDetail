using System.Windows.Input;
using MugenMvvmToolkit.Models;
using MugenMvvmToolkit.ViewModels;

namespace Core.ViewModels
{
    public class MainViewModel : CloseableViewModel
    {
        public DetailVm DetailVm { get; private set; }

        public ICommand OpenFirstVmCommand { get; private set; }
        public ICommand OpenSecondVmCommand { get; private set; }

        protected override void OnInitialized()
        {
            DetailVm = GetViewModel<DetailVm>();
            DetailVm.Text = "Hello from VM Zero";

            OpenFirstVmCommand = new RelayCommand(OpenFirstVm);
            OpenSecondVmCommand = new RelayCommand(OpenSecondVm);
        }

        private void OpenFirstVm()
        {
            DetailVm = GetViewModel<DetailVm>();
            DetailVm.Text = "Hello from VM One";
        }

        private void OpenSecondVm()
        {
            DetailVm = GetViewModel<DetailVm>();
            DetailVm.Text = "Hello from VM Two";
        }
    }
}
