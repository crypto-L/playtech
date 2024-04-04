using Roulette.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace Roulette.Models;

public class ButtonInfo : ViewModelBase, INotifyPropertyChanged
{
    public int Number { get; set; }
    public string Color { get; set; }
    
    private int _index;

    public int Index
    {
        get { return _index; }
        set
        {
            _index = value;
            OnPropertyChanged(nameof(Index));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    
    public ButtonInfo(int number, string color, int index)
    {
        Number = number;
        Color = color;
        Index = index;
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}