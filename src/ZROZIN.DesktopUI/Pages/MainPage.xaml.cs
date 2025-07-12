using ZROZIN.DesktopUI.Models;
using ZROZIN.DesktopUI.PageModels;

namespace ZROZIN.DesktopUI.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageModel model)
    {
        InitializeComponent();
        BindingContext = model;
    }
}