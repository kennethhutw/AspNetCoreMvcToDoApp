namespace AspNetCoreToDoApp.Web.Commands.Tasks
{
    using AspNetCoreToDoApp.Web.Commands;
    using MediatR;

    public class TaskAddOrEditCommand : AddOrEditSingleEntityCommandBase, IAsyncRequest<CommandResult<int>>
    {
        public string Description { get; set; }

        public int CategoryId { get; set; }
    }
}