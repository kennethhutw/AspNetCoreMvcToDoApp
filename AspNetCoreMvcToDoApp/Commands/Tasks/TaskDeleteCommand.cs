namespace AspNetCoreToDoApp.Web.Commands.Tasks
{
    using AspNetCoreToDoApp.Web.Commands;
    using MediatR;

    public class TaskDeleteCommand : SingleEntityCommandBase, IAsyncRequest<CommandResult>
    {
    }
}