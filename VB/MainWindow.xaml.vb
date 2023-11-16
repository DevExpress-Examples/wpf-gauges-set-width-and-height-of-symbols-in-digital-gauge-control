Imports System.Windows
Imports DevExpress.Xpf.Gauges

Namespace Digital_Gauge

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
'#Region "#SetSymbolSize"
            ' Specify fixed values for symbol height and width.
            Dim newWidth As SymbolLength = New SymbolLength(SymbolLengthType.Fixed, 44)
            Me.matrixView.Width = newWidth
            Dim newHeight As SymbolLength = New SymbolLength(SymbolLengthType.Fixed, 50)
            Me.matrixView.Height = newHeight
'#End Region  ' #SetSymbolSize
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
'#Region "#SetSymbolSize"
            ' Specify proportional values for symbol height and width.
            Dim newWidth As SymbolLength = New SymbolLength(SymbolLengthType.Proportional, 2)
            Me.matrixView.Width = newWidth
            Dim newHeight As SymbolLength = New SymbolLength(SymbolLengthType.Proportional, 5)
            Me.matrixView.Height = newHeight
'#End Region  ' #SetSymbolSize
        End Sub
    End Class
End Namespace
