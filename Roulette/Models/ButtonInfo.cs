using Roulette.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace Roulette.Models;

public class ButtonInfo : ViewModelBase, INotifyPropertyChanged
{
    public int Number { get; set; }
    public bool IsRed { get; set; }
    
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
    
    public ButtonInfo(int number, bool isRed, int index)
    {
        Number = number;
        IsRed = isRed;
        Index = index;
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}