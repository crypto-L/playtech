﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Layout;

namespace Roulette.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
    
    public ObservableCollection<Button> ButtonsRow1 { get; set; }
    public ObservableCollection<Button> ButtonsRow2 { get; set; }
    public ObservableCollection<Button> ButtonsRow3 { get; set; }

    private int[] RedButtonNumbers { get; }

    public MainWindowViewModel()
    {
        RedButtonNumbers = [1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36];
        ButtonsRow1 = new ObservableCollection<Button>();
        ButtonsRow2 = new ObservableCollection<Button>();
        ButtonsRow3 = new ObservableCollection<Button>();

        for (int i = 0; i < 12; i++)
        {
            ButtonsRow1.Add(CreateButton(3 + (i*3)));
            ButtonsRow2.Add(CreateButton(2 + (i*3)));
            ButtonsRow3.Add(CreateButton(1 + (i*3)));
            
        }
    }

    private Button CreateButton(int buttonNumber)
    {
        var isRed = RedButtonNumbers.Contains(buttonNumber);
        var color = isRed ? "Red" : "Black";
        return new Button { Content = $"{buttonNumber}", Classes = { color }};
    }
    
#pragma warning restore CA1822 // Mark members as static
}
