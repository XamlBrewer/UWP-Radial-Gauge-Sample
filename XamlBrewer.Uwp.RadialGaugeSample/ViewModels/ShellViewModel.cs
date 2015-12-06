using XamlBrewer.Uwp.RadialGaugeSample;

namespace Mvvm
{
    class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            // Build the menu
            Menu.Add(new MenuItem() { Glyph = "\uE2B1", Text = "Styles", NavigationDestination = typeof(MainPage) });
            Menu.Add(new MenuItem() { Glyph = "\uE71B", Text = "Binding", NavigationDestination = typeof(BindingPage) });
        }
    }
}
