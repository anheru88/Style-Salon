Public Class Cita

    Dim v_hora As TimeSpan

    Public Property Tipo As Integer

    Public Property Hora As TimeSpan
        Get
            Return v_hora
        End Get
        Set(value As TimeSpan)
            v_hora = value
            Me.timeLbl.Text = FormatDateTime("01/01/1900 " & v_hora.ToString, DateFormat.ShortTime)
        End Set
    End Property

    Public Property Empleado As Integer
    Public Property Evento As Integer

    Public Sub New(time As TimeSpan)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Hora = time
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(time As TimeSpan, employee As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Hora = time
        Empleado = employee
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(time As TimeSpan, employee As Integer, evento As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Hora = time
        Me.Empleado = employee
        Me.Evento = evento
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Cita_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave, Label1.MouseLeave, timeLbl.MouseLeave
        Me.BackColor = Color.White
        Me.ForeColor = Color.DarkGray
        timeLbl.ForeColor = Color.DarkGray
        Label1.ForeColor = Color.DarkGray
    End Sub

    Private Sub Cita_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Label1.MouseMove, timeLbl.MouseMove
        Me.BackColor = Color.FromArgb(102, 204, 124)
        Me.ForeColor = Color.White
        timeLbl.ForeColor = Color.White
        Label1.ForeColor = Color.White
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        vg_lastEmployee = Me.Empleado

        Select Case Me.Tipo
            Case 0
                vg_showCalendar = False
                Main.LoadScreen(New Agenda(Me.Evento), MoveDirection.BackIn)
            Case Else
                vg_showCalendar = False
                vg_lasttime = v_hora
                Main.LoadScreen(New Agenda(-1), MoveDirection.BackIn)
        End Select

    End Sub

End Class
