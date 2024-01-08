namespace MauiAndroidForegroundService;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        // FIXED: System.InvalidOperationException: 'Both MainPage was set and CreateWindow was overridden to provide a page.'
        // MainPage = new AppShell();
    }


    protected override Window CreateWindow(IActivationState activationState)
	{
        // FIXED: System.InvalidOperationException: 'Window was already created'
        return new Window(new AppShell());
	}

}
