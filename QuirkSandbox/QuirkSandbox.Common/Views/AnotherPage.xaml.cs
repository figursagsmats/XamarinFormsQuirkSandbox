using Xamarin.Forms;

namespace QuirkSandbox.Common.Views
{
    public partial class AnotherPage : ContentPage
    {
        public AnotherPage()
        {
            InitializeComponent();
            //var test = new TestView.FormsPlugin.Abstractions.TestViewControl();
            var b = Plugin.Battery.CrossBattery.Current;
            var status = b.RemainingChargePercent;
            label.Text = status.ToString();

        }
    }
}
