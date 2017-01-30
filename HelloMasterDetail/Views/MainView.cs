using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using MugenMvvmToolkit.Android.AppCompat.Views.Activities;

namespace HelloMasterDetail.Views
{
    [Activity(Label = "MainView")]
    public class MainView : MvvmAppCompatActivity
    {
        #region Constructors

        public MainView()
            : base(Resource.Layout.Main)
        {
        }

        #endregion

        #region Overrides of MvvmActionBarActivity

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);

        }

        #endregion
    }
}