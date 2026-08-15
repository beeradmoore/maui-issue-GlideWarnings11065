using Microsoft.Extensions.DependencyInjection;

namespace MauiIssueGlideWarnings11065;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}