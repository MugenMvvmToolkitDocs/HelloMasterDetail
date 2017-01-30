using Android.Support.V4.Widget;
using MugenMvvmToolkit.Binding;
using MugenMvvmToolkit.Binding.Models;

namespace HelloMasterDetail.AttachedMembers
{
    public static class DrawerLayoutAttachedMembers
    {
        public static void Attach()
        {
            var memberProvider = BindingServiceProvider.MemberProvider;

            memberProvider.Register(AttachedBindingMember.CreateMember<DrawerLayout, bool>("NeedCloseDrawer", null,
                (info, view, arg) =>
                {
                    if (arg)
                        view.CloseDrawers();
                }));
        }
    }
}