using System.Windows.Input;
using MugenMvvmToolkit.Models;
using MugenMvvmToolkit.ViewModels;

namespace Core.ViewModels
{
    public class MainViewModel : CloseableViewModel
    {
        private DetailViewModel _detailViewModel;
        private bool _needCloseDrawer;

        public DetailViewModel DetailViewModel
        {
            get { return _detailViewModel; }
            private set
            {
                if (Equals(_detailViewModel, value)) return;
                _detailViewModel = value;
                OnPropertyChanged();
            }
        }

        public bool NeedCloseDrawer
        {
            get { return _needCloseDrawer; }
            private set
            {
                _needCloseDrawer = value;
                OnPropertyChanged();
            }
        }

        public ICommand OpenFirstFragmentCommand { get; private set; }
        public ICommand OpenSecondFragmentCommand { get; private set; }

        protected override void OnInitialized()
        {
            OpenFirstFragmentCommand = new RelayCommand(OpenFirstVm);
            OpenSecondFragmentCommand = new RelayCommand(OpenSecondVm);

            DetailViewModel = GetViewModel<DetailViewModel>();
            DetailViewModel.Text = "Fragment 0";
        }

        private void OpenFirstVm()
        {
            DetailViewModel = GetViewModel<DetailViewModel>();
            DetailViewModel.Text = "Fragment 1";
            NeedCloseDrawer = true;
        }

        private void OpenSecondVm()
        {
            DetailViewModel = GetViewModel<DetailViewModel>();
            DetailViewModel.Text = "Fragment 2";
            NeedCloseDrawer = true;
        }
    }
}