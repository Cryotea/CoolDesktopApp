using ReactiveUI;

namespace Cool.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    
    private bool _isVisable1 = true;
    private bool _isVisable2;
    private bool _isVisable3;
    private bool _isVisable4;

    public bool isVisable1
    {
        get => _isVisable1;
        set => this.RaiseAndSetIfChanged(ref _isVisable1, value);
    }
    
    public bool isVisable2
    {
        get => _isVisable2;
        set => this.RaiseAndSetIfChanged(ref _isVisable2, value);
    }
    
    public bool isVisable3
    {
        get => _isVisable3;
        set => this.RaiseAndSetIfChanged(ref _isVisable3, value);
    }
    
    public bool isVisable4
    {
        get => _isVisable4;
        set => this.RaiseAndSetIfChanged(ref _isVisable4, value);
    }

    public void Button1()
    {
        isVisable1 = false;
        isVisable2 = false;
        isVisable3 = false;
        isVisable4 = false;

        isVisable1 = true;
        
    }
    
    public void Button2()
    {
        isVisable1 = false;
        isVisable2 = false;
        isVisable3 = false;
        isVisable4 = false;

        isVisable2 = true;
    }

    public void Button3()
    {
        isVisable1 = false;
        isVisable2 = false;
        isVisable3 = false;
        isVisable4 = false;

        isVisable3 = true;
    }    
    
    public void Button4()
    {
        isVisable1 = false;
        isVisable2 = false;
        isVisable3 = false;
        isVisable4 = false;

        isVisable4 = true;
    }
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static
}