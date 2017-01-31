using HelloMasterDetail.AttachedMembers;
using MugenMvvmToolkit.Models;
using MugenMvvmToolkit.Modules;

namespace HelloMasterDetail
{
    public class MyModule : ModuleBase
    {
        public MyModule()
            : base(false, LoadMode.All)
        {
        }

        protected override bool LoadInternal()
        {
            ExtensionMethods.Attach();
            return true;
        }

        protected override void UnloadInternal()
        {
        }
    }
}
