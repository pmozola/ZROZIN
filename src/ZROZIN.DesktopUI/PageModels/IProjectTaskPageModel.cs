using CommunityToolkit.Mvvm.Input;
using ZROZIN.DesktopUI.Models;

namespace ZROZIN.DesktopUI.PageModels;

public interface IProjectTaskPageModel
{
    IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
    bool IsBusy { get; }
}