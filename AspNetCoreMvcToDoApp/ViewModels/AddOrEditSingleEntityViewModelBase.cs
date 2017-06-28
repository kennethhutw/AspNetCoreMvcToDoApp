namespace AspNetCoreToDoApp.Web.ViewModels
{
    public abstract class AddOrEditSingleEntityViewModelBase : SingleEntityViewModelBase
    {
        public bool IsAdding => Id == 0;
    }
}