namespace AspNetCoreToDoApp.Web.Infrastructure.Mediator
{
    using AspNetCoreToDoApp.Web.Models;

    public abstract class HandlerBase
    {
        protected HandlerBase(ToDoContext context)
        {
            Context = context;
        }

        protected ToDoContext Context { get; private set; }
    }
}