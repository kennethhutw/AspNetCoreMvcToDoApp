namespace AspNetCoreToDoApp.Web.ViewModels.Tasks
{
    using System.Linq;
    using System.Threading.Tasks;
    using AspNetCoreToDoApp.Web.Infrastructure.Mediator;
    using AspNetCoreToDoApp.Web.Models;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using MediatR;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    public class TasksIndexViewModelQueryHandler : QueryHandlerBase, IAsyncRequestHandler<TasksIndexViewModelQuery, TasksIndexViewModel>
    {
        public TasksIndexViewModelQueryHandler(ToDoContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<TasksIndexViewModel> Handle(TasksIndexViewModelQuery query)
        {
            var model = new TasksIndexViewModel
            {
                CategoryId = query.CategoryId,
                Items = await Context.Tasks
                    .Include(x => x.Category)
                    .Where(x => !query.CategoryId.HasValue || x.Category.Id == query.CategoryId) 
                    .OrderBy(x => x.Description)
                    .ProjectTo<TasksIndexViewModel.TaskListEntry>()
                    .ToListAsync()
            };

            model.CategoryOptions = new SelectList(await Context.Categories
                .OrderBy(x => x.Name)
                .ToListAsync(), "Id", "Name", model.CategoryId);

            return model;
        }
    }
}