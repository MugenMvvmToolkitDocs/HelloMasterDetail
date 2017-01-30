using System.Windows.Input;
using MugenMvvmToolkit.Models;
using MugenMvvmToolkit.ViewModels;

namespace Core.ViewModels
{
    public class MainViewModel : CloseableViewModel
    {
        private DetailViewModel _detailVm;

        public DetailViewModel DetailVm
        {
            get { return _detailVm; }
            private set
            {
                if(Equals(_detailVm, value)) return;
                _detailVm = value;
                OnPropertyChanged();
            }
        }

        public ICommand OpenFirstVmCommand { get; private set; }
        public ICommand OpenSecondVmCommand { get; private set; }

        protected override void OnInitialized()
        {
            OpenFirstVmCommand = new RelayCommand(OpenFirstVm);
            OpenSecondVmCommand = new RelayCommand(OpenSecondVm);

            DetailVm = GetViewModel<DetailViewModel>();
            DetailVm.Text = "0";
        }

        private async void OpenFirstVm()
        {
            DetailVm = GetViewModel<DetailViewModel>();
            DetailVm.Text = "1";
        }

        private async void OpenSecondVm()
        {
            DetailVm = GetViewModel<DetailViewModel>();
            DetailVm.Text = "2";
        }
    }
}
