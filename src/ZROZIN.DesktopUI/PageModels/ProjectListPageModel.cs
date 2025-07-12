#nullable disable
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ZROZIN.DesktopUI.Data;
using ZROZIN.DesktopUI.Models;
using ZROZIN.DesktopUI.Services;

namespace ZROZIN.DesktopUI.PageModels;

public partial class ProjectListPageModel : ObservableObject
{
    private readonly ProjectRepository _projectRepository;

    [ObservableProperty] private List<Project> _projects = [];

    public ProjectListPageModel(ProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    [RelayCommand]
    private async Task Appearing()
    {
        Projects = await _projectRepository.ListAsync();
    }

    [RelayCommand]
    Task NavigateToProject(Project project)
        => Shell.Current.GoToAsync($"project?id={project.ID}");

    [RelayCommand]
    async Task AddProject()
    {
        await Shell.Current.GoToAsync($"project");
    }
}