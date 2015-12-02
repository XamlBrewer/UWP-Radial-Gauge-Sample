// using XamlBrewer.UWP.MoonSharpSample.Views;

using XamlBrewer.Uwp.RadialGaugeSample;

namespace Mvvm
{
    class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            // Build the menu
            Menu.Add(new MenuItem() { Glyph = "\uE2B1", Text = "Styles", NavigationDestination = typeof(MainPage) });
            //Menu.Add(new MenuItem() { Glyph = "\uE2B3", Text = "Lua Functions", NavigationDestination = typeof(LuaFunctionPage) });
            //Menu.Add(new MenuItem() { Glyph = "\uE2B4", Text = "C# Functions", NavigationDestination = typeof(CSharpFunctionPage) });
            //Menu.Add(new MenuItem() { Glyph = "\uE1CA", Text = "Object Sharing", NavigationDestination = typeof(ObjectSharingPage) });
            //Menu.Add(new MenuItem() { Glyph = "\uE25C", Text = "Events", NavigationDestination = typeof(EventHandlingPage) });
        }
    }
}
