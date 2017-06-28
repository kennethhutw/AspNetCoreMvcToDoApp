namespace AspNetCoreToDoApp.Web.Commands.Tasks
{
    using System;
    using System.Threading.Tasks;
    using AspNetCoreToDoApp.Web.Infrastructure.Mediator;
    using AspNetCoreToDoApp.Web.Models;
    using Microsoft.EntityFrameworkCore;

    public abstract class SingleTaskCommandHandlerBase : CommandHandlerBase {
        protected SingleTaskCommandHandlerBase(ToDoContext context): base(context)
        {

        }

        protected async Task<Models.Task > GetTask(int id){
            var task = await Context.Tasks.SingleOrDefaultAsync(x=> x.Id == id);
            if(task == null)
            {
                throw new NullReferenceException($"Task with id:{id} not found.");
            }
            return task;
        }
    }
}