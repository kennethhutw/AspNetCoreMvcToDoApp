namespace AspNetCoreToDoApp.Web.ViewModels.Tasks
{
    using MediatR;

    public class TasksDeleteViewModelQuery : IAsyncRequest<TasksDeleteViewModel>
    {
        public int Id {get; set;} 
    }
}