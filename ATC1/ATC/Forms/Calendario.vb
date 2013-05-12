Public Class Calendario

    Dim t_citas As List(Of ATCDataSet.AgendaRow)
    Dim cita_empleado_dia As List(Of ATCDataSet.AgendaRow)
    Dim v_fecha As Date = Now
    Dim IdentEmpleado As String
    Dim filaseleccionada As Integer
    
    Public Sub New()

        InitializeComponent()

        Me.MonthCalendar.MaxSelectionCount = 1
        Me.MonthCalendar.MinDate = New System.DateTime(Date.Now.Year, Date.Now.Month, Date.Now.Day)
        t_citas = AgendaTableAdapter.GetDataFecha.ToList()

        Try
            Me.EmpleadosTableAdapter.Fill(Me.ATCDataSet.Empleados)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Me.Label_Empleado.Text = ""
        Cargar_Calendario()
        Cargar_Horario()
        Grilla_Empleado()
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub Back_Boton_Click(sender As System.Object, e As System.EventArgs) Handles Back_Boton.Click
        Main.LoadScreen(New Inicio, MoveDirection.Out)
    End Sub
    Private Sub MonthCalendar_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar.DateChanged
        Fecha_Label.Text = CStr(Me.MonthCalendar.SelectionRange.Start)

        filaseleccionada = Convert.ToInt32(Me.EmpleadosDataGridView.CurrentRow.Index)
        IdentEmpleado = Me.EmpleadosDataGridView.Item("Id", filaseleccionada).Value

        Cargar_Horario(Fecha_Label.Text, IdentEmpleado)

    End Sub
  

    Private Sub EmpleadosDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellClick
        Grilla_Empleado()

    End Sub
    Private Sub Cargar_Calendario()
        For Each cita As ATCDataSet.AgendaRow In t_citas
            Me.MonthCalendar.AddBoldedDate(cita.Fecha)
        Next
        Fecha_Label.Text = CStr(Me.MonthCalendar.SelectionRange.Start)
    End Sub

    Private Sub Cargar_Horario()
        Me.Horario.Controls.Clear()
        For h As Integer = 8 To 20
            Dim time As New TimeSpan(h, 0, 0)
            Dim cita As New Hora(time)
            cita.Dock = DockStyle.Bottom
            Me.Horario.Controls.Add(cita)
            cita.Show()
        Next
    End Sub

    Private Sub Cargar_Horario(dia As String, empleado As Integer)
        For Each Control As Hora In Me.Horario.Controls
            Control.Label_Texto.Text = ""
        Next

        cita_empleado_dia = AgendaTableAdapter.GetDataByDiaEmpleado("" + dia.ToString(), empleado).ToList()
        For Each cita As ATCDataSet.AgendaRow In cita_empleado_dia

            'MsgBox(" " + cita.Hora.ToString() + " " + cita.Hora.Hours.ToString())

            Dim cita2 As Hora

            Select Case (Convert.ToInt32(cita.Hora.Hours.ToString()))
                Case 8
                    cita2 = Me.Horario.Controls.Item(0)
                Case 9
                    cita2 = Me.Horario.Controls.Item(1)
                Case 10
                    cita2 = Me.Horario.Controls.Item(2)
                Case 11
                    cita2 = Me.Horario.Controls.Item(3)
                Case 12
                    cita2 = Me.Horario.Controls.Item(4)
                Case 13
                    cita2 = Me.Horario.Controls.Item(5)
                Case 14
                    cita2 = Me.Horario.Controls.Item(6)
                Case 15
                    cita2 = Me.Horario.Controls.Item(7)
                Case 16
                    cita2 = Me.Horario.Controls.Item(8)
                Case 17
                    cita2 = Me.Horario.Controls.Item(9)
                Case 18
                    cita2 = Me.Horario.Controls.Item(10)
                Case 19
                    cita2 = Me.Horario.Controls.Item(11)
                Case 20
                    cita2 = Me.Horario.Controls.Item(12)
                Case Else
                    Continue For
            End Select

            cita2.Label_Texto.Text = cita.NombreServicio.ToString() + " Con " + cita.Nombre.ToString()
            cita2.llenar_datos(cita.Id, cita.Empleado, cita.Cliente, cita.Servicio, cita.Fecha, cita.Hora)


        Next

    End Sub

    Private Sub Grilla_Empleado()
        Try
            Label_Empleado.Text = EmpleadosDataGridView.CurrentCell.Value
            filaseleccionada = Convert.ToInt32(Me.EmpleadosDataGridView.CurrentRow.Index)

            IdentEmpleado = Me.EmpleadosDataGridView.Item("Id", filaseleccionada).Value

            Cargar_Horario(Fecha_Label.Text, IdentEmpleado)
        Catch ex As Exception
            IdentEmpleado = -2
        End Try
       
    End Sub
    Private Sub CalendarioAddBtn_Click(sender As System.Object, e As System.EventArgs) Handles CalendarioAddBtn.Click
        If IdentEmpleado <> -2 Then
            Main.LoadScreen(New Agregar_Cita(Convert.ToInt32(IdentEmpleado) - 1, Me.MonthCalendar.SelectionRange.Start), MoveDirection.Out)
        Else
            Main.LoadScreen(New Agregar_Cita(), MoveDirection.Out)
        End If


    End Sub
End Class
