using BarcodeScanning;

namespace BarcodeScanningNativeMauiLeak;

public partial class ScannerLeakPage : ContentPage
{
	public ScannerLeakPage()
	{
		InitializeComponent();
	}

    private void MyCameraView_OnOnDetectionFinished(object? sender, OnDetectionFinishedEventArg e)
    {
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await Methods.AskForRequiredPermissionAsync();

        MyCameraView.CameraEnabled = true;
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        MyCameraView.CameraEnabled = false;
    }

    protected override void OnHandlerChanging(HandlerChangingEventArgs args)
    {
        base.OnHandlerChanging(args);

        if (args.NewHandler != null)
        {
            return;
        }

        MyCameraView.Handler?.DisconnectHandler();
    }

    ~ScannerLeakPage()
    {
        Console.WriteLine("~ScannerLeakPage() called");
    }
}