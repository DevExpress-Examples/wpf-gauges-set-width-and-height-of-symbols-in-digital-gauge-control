using System.Windows;
using DevExpress.Xpf.Gauges;

namespace Digital_Gauge {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            // Specify fixed values for symbol height and width.
            matrixView.Width = new SymbolLength(SymbolLengthType.Fixed, 44);
            matrixView.Height = new SymbolLength(SymbolLengthType.Fixed, 50);
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            // Specify proportional values for symbol height and width.
            matrixView.Width = new SymbolLength(SymbolLengthType.Proportional, 2);
            matrixView.Height = new SymbolLength(SymbolLengthType.Proportional, 5);
        }
    }
}
