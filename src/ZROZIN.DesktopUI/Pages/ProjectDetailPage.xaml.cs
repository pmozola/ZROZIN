using ZROZIN.DesktopUI.Models;

namespace ZROZIN.DesktopUI.Pages;

public partial class ProjectDetailPage : ContentPage
{
    public ProjectDetailPage(ProjectDetailPageModel model)
    {
        InitializeComponent();

        BindingContext = model;
    }
}