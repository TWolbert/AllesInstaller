using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MyLinuxApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void Button_Click(object sender, RoutedEventArgs args)
    {
        message.Text = "Hello, Avalonia!";
    }
}