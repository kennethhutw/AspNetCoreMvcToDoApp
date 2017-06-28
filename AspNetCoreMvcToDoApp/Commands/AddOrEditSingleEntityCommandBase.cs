namespace AspNetCoreToDoApp.Web.Commands{
    public abstract class AddOrEditSingleEntityCommandBase: SingleEntityCommandBase
    {
        public bool IsAdding => Id == 0;
    }
}