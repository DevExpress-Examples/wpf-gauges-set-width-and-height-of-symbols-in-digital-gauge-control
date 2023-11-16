Imports System.Windows
Imports DevExpress.Xpf.Gauges

Namespace Digital_Gauge

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ' Specify fixed values for symbol height and width.
            Me.matrixView.Width = New SymbolLength(SymbolLengthType.Fixed, 44)
            Me.matrixView.Height = New SymbolLength(SymbolLengthType.Fixed, 50)
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ' Specify proportional values for symbol height and width.
            Me.matrixView.Width = New SymbolLength(SymbolLengthType.Proportional, 2)
            Me.matrixView.Height = New SymbolLength(SymbolLengthType.Proportional, 5)
        End Sub
    End Class
End Namespace
