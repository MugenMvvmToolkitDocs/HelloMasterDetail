using System.Windows.Input;
using Android.Support.V4.Widget;
using Android.Views;
using MugenMvvmToolkit.Binding;

namespace HelloMasterDetail.AttachedMembers
{
    public static class ExtensionMethods
    {
        public static void InvokeCloseDrawer(this ICommand command, View view, object parameter = null)
        {
            if (command != null && command.CanExecute(parameter))
            {
                ((DrawerLayout)view).CloseDrawers();
                command.Execute(parameter);
            }
        }

        public static void Attach()
        {
            BindingServiceProvider
                   .ResourceResolver
                   .AddType(nameof(ExtensionMethods), typeof(ExtensionMethods));
        }
    }
}
