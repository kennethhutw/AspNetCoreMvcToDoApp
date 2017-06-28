namespace AspNetCoreToDoApp.Web.Infrastructure.Mapping
{
     using AspNetCoreToDoApp.Web.Commands.Tasks;
    using AspNetCoreToDoApp.Web.Models;
    using AspNetCoreToDoApp.Web.ViewModels.Tasks;
    using Profile = AutoMapper.Profile;

    public class TasksProfile: Profile
    {
        public TasksProfile()
        {
            CreateMap<Task, TasksIndexViewModel.TaskListEntry>();
            CreateMap<Task, TasksEditViewModel>();
            CreateMap<Task, TasksDeleteViewModel>();

            CreateMap<TasksEditViewModel, TaskAddOrEditCommand>();
            CreateMap<TasksDeleteViewModel, TaskDeleteCommand>();
        }
    }
}