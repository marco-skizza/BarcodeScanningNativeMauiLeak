namespace BarcodeScanningNativeMauiLeak;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnAppearing(object? sender, EventArgs e)
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        var totalMemory = GC.GetTotalMemory(true);
        Console.WriteLine($"Memory: {totalMemory}");
    }

    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ScannerLeakPage));
    }
}