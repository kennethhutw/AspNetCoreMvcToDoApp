namespace AspNetCoreToDoApp.Web.Commands.Tasks
{
    using AspNetCoreToDoApp.Web.Commands;
    using MediatR;

    public class TaskResetCommand : SingleEntityCommandBase, IAsyncRequest<CommandResult>
    {
    }
}