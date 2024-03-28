namespace BarcodeScanningNativeMauiLeak
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ScannerLeakPage), typeof(ScannerLeakPage));
        }
    }
}
