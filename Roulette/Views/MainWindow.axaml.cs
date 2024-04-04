using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Roulette.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        var gridItem = this
            .FindControl<ItemsControl>("Grid");
    }

  
}