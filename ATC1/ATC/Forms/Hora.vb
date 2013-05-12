Public Class Hora

    Private time, time2 As TimeSpan
    Private id, id_empleado, id_cliente, id_servicio As Integer
    Private fecha As Date

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.Label_Hora.Text = ""
        Me.Label_Texto.Text = ""


    End Sub

    Public Sub New(t As TimeSpan)
        InitializeComponent()
        time = t
        Me.Label_Hora.Text = FormatDateTime("01/01/1990 " & t.ToString, DateFormat.ShortTime)
        Me.Label_Texto.Text = ""
    End Sub

    Public Sub New(t As TimeSpan, c As String)
        InitializeComponent()
        time = t
        Me.Label_Hora.Text = FormatDateTime("01/01/1990" & t.ToString, DateFormat.ShortTime)
        Me.Label_Texto.Text = c
    End Sub

    Private Sub Label_Texto_Click(sender As System.Object, e As System.EventArgs) Handles Label_Texto.Click
        If Label_Texto.Text <> "" Then
            Main.LoadScreen(New Agregar_Cita(id, id_empleado, id_cliente, id_servicio, fecha, time2), MoveDirection.Out)
        End If
    End Sub

    Public Sub llenar_datos(Id As Integer, Empleado_Id As Integer, Cliente_Id As Integer, Servicio_Id As Integer, Fecha As Date, hora As TimeSpan)
        Me.id = Id
        Me.id_empleado = Empleado_Id
        Me.id_cliente = Cliente_Id
        Me.id_servicio = Servicio_Id
        Me.fecha = Fecha
        Me.time2 = hora
    End Sub

    Public Sub llenar_datos(IdEmpleado As Integer, Fecha As Date)
        Me.id_empleado = IdEmpleado
        Me.fecha = Fecha
    End Sub


    Private Sub Label_Hora_Click(sender As System.Object, e As System.EventArgs) Handles Label_Hora.Click
        If Label_Texto.Text <> "" Then
            Main.LoadScreen(New Agregar_Cita(id, id_empleado, id_cliente, id_servicio, fecha, time2), MoveDirection.Out)
        Else
            Main.LoadScreen(New Agregar_Cita(Me.id_empleado, Me.fecha, Me.time), MoveDirection.Out)
            'MsgBox("Id Empleado:" + Me.id_empleado.ToString() + "; Fecha: " + Me.fecha.ToString() + "; Hora: " + Me.time.ToString())
        End If
    End Sub
End Class
