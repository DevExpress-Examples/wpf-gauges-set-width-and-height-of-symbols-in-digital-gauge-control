using System.Windows;
using DevExpress.Xpf.Gauges;

namespace Digital_Gauge {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            #region #SetSymbolSize
            // Specify fixed values for symbol height and width.
            SymbolLength newWidth = new SymbolLength(SymbolLengthType.Fixed, 44);
            matrixView.Width = newWidth;
            SymbolLength newHeight = new SymbolLength(SymbolLengthType.Fixed, 50);
            matrixView.Height = newHeight;
            #endregion #SetSymbolSize
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            #region #SetSymbolSize
            // Specify proportional values for symbol height and width.
            SymbolLength newWidth = new SymbolLength(SymbolLengthType.Proportional, 2);
            matrixView.Width = newWidth;
            SymbolLength newHeight = new SymbolLength(SymbolLengthType.Proportional, 5);
            matrixView.Height = newHeight;
            #endregion #SetSymbolSize
        }
    }
}
