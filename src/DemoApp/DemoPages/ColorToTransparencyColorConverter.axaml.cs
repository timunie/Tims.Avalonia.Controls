using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DemoApp.DemoPages
{
    public partial class ColorToTransparencyColorConverter : UserControl
    {
        public ColorToTransparencyColorConverter()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
