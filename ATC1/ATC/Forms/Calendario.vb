Public Class Calendario

    Dim t_citas As List(Of ATCDataSet.AgendaRow)
    Dim cita_empleado_dia As List(Of ATCDataSet.AgendaRow)
    Dim fecha_select As Date
    Dim IdentEmpleado As String
    Dim filaseleccionada As Integer
    Dim row, colum As Integer



    
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
        row = 0
        colum = 1
        fecha_select = Now


    End Sub

    Public Sub New(FechaStart As Date, Empleado_row As Integer)
        Me.New()
        row = Empleado_row
        fecha_select = FechaStart
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
        For h As Integer = 6 To 22
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
            Control.llenar_datos(empleado, "" + dia.ToString())
        Next

        cita_empleado_dia = AgendaTableAdapter.GetDataByDiaEmpleado("" + dia.ToString(), empleado).ToList()
        For Each cita As ATCDataSet.AgendaRow In cita_empleado_dia

            'MsgBox(" " + cita.Hora.ToString() + " " + cita.Hora.Hours.ToString())

            Dim cita2 As Hora

            Select Case (Convert.ToInt32(cita.Hora.Hours.ToString()))
                Case 6
                    cita2 = Me.Horario.Controls.Item(0)
                Case 7
                    cita2 = Me.Horario.Controls.Item(1)
                Case 8
                    cita2 = Me.Horario.Controls.Item(2)
                Case 9
                    cita2 = Me.Horario.Controls.Item(3)
                Case 10
                    cita2 = Me.Horario.Controls.Item(4)
                Case 11
                    cita2 = Me.Horario.Controls.Item(5)
                Case 12
                    cita2 = Me.Horario.Controls.Item(6)
                Case 13
                    cita2 = Me.Horario.Controls.Item(7)
                Case 14
                    cita2 = Me.Horario.Controls.Item(8)
                Case 15
                    cita2 = Me.Horario.Controls.Item(9)
                Case 16
                    cita2 = Me.Horario.Controls.Item(10)
                Case 17
                    cita2 = Me.Horario.Controls.Item(11)
                Case 18
                    cita2 = Me.Horario.Controls.Item(12)
                Case 19
                    cita2 = Me.Horario.Controls.Item(13)
                Case 20
                    cita2 = Me.Horario.Controls.Item(14)
                Case 21
                    cita2 = Me.Horario.Controls.Item(15)
                Case 22
                    cita2 = Me.Horario.Controls.Item(16)
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
            'MsgBox(IdentEmpleado)
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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Main.LoadScreen(New Servicios(-1, Me), MoveDirection.BackIn)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Main.LoadScreen(New Clientes(-1, Me), MoveDirection.BackIn)
    End Sub


    Public Sub Seleccionar_DataGridView()
        Me.EmpleadosDataGridView.CurrentCell = Me.EmpleadosDataGridView(colum, row)
        Me.MonthCalendar.SetDate(fecha_select)
        Grilla_Empleado()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Consulta.Show()
        Main.Hide()
    End Sub
End Class
