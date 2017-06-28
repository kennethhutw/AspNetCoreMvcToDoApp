namespace AspNetCoreToDoApp.Web.Infrastructure.Mediator
{
    using AspNetCoreToDoApp.Web.Models;
    using AutoMapper;

    public abstract class QueryHandlerBase : HandlerBase
    {
        protected QueryHandlerBase(ToDoContext context, IMapper mapper)
            : base(context)
        {
            Mapper = mapper;
        }

        protected IMapper Mapper { get; private set; }
    }
}