using Avalonia.Controls;
using Avalonia.Interactivity;
using Sudoku.Logic;

namespace Sudoku.Views;

public partial class LevelChooseView : UserControl
{
    public LevelChooseView()
    {
        InitializeComponent();
    }

    private void EasyButton_OnClick(object? sender, RoutedEventArgs e)
    {
        SetWindowContent(Level.Easy);
    }

    private void SetWindowContent(Level level)
    {
        if (Parent is MainWindow window)
            window.Content = new GameView(level);
    }
}