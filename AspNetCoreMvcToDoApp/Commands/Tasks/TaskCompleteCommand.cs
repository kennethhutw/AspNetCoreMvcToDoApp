namespace AspNetCoreToDoApp.Web.Commands.Tasks
{
    using AspNetCoreToDoApp.Web.Commands;
    using MediatR;

    public class TaskCompleteCommand : SingleEntityCommandBase, IAsyncRequest<CommandResult>
    {
    }
}