using MyVoiceApp3.Pages;

namespace MyVoiceApp3;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(UserPage), typeof(UserPage));

        //Routing.RegisterRoute(nameof(GroupPage), typeof(GroupPage));
        //Routing.RegisterRoute(nameof(HelpPage), typeof(HelpPage));
        //Routing.RegisterRoute(nameof(ToolsPage), typeof(ToolsPage));
        Routing.RegisterRoute(nameof(TalkPage), typeof(TalkPage));
        //Routing.RegisterRoute(nameof(EditPage), typeof(EditPage));

    }
}
