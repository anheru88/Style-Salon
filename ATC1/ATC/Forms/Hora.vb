Public Class Hora

    Public time As TimeSpan

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.Label_Hora.Text = ""
        Me.Label_Texto.Text = ""


    End Sub

    Public Sub New(t As TimeSpan)
        InitializeComponent()
        Me.Label_Hora.Text = FormatDateTime("01/01/1990 " & t.ToString, DateFormat.ShortTime)
        Me.Label_Texto.Text = ""
    End Sub

    Public Sub New(t As TimeSpan, c As String)
        InitializeComponent()
        Me.Label_Hora.Text = FormatDateTime("01/01/1990" & t.ToString, DateFormat.ShortTime)
        Me.Label_Texto.Text = c
    End Sub
End Class
