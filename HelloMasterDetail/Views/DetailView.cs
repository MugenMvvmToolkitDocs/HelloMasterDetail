using Core.ViewModels;
using MugenMvvmToolkit.Android.AppCompat.Views.Fragments;
using MugenMvvmToolkit.Attributes;

namespace HelloMasterDetail.Views
{
    [ViewModel(typeof(DetailViewModel))]
    public class DetailView : MvvmFragment
    {
        public DetailView() : base(Resource.Layout.DetailView)
        {
        }
    }
}
