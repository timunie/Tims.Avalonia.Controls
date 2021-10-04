using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DemoApp.DemoPages
{
    public partial class ObjectEqualsToBooleanConverter : UserControl
    {
        public ObjectEqualsToBooleanConverter()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
