namespace AspNetCoreToDoApp.Web.Infrastructure.Mediator
{
    using AspNetCoreToDoApp.Web.Models;

    public abstract class CommandHandlerBase : HandlerBase
    {
        protected CommandHandlerBase(ToDoContext context)
            : base(context)
        {
        }
    }
}