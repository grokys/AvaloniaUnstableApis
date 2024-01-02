using Avalonia.Controls;

namespace AvaloniaUnstableApis;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        PlatformImpl!.SetEnabled(false);
    }
}