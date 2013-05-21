Public Class Agregar_Cita

    Public id_ant, emp_ant, cli_ant, ser_ant As Integer
    Public fecha_ant As Date
    Public hora_ant As TimeSpan

    Public Sub New()

        InitializeComponent()
        Me.Label_Mensaje.Text = ""
        Me.FechaDateTimePicker1.MinDate = New System.DateTime(Date.Now.Year, Date.Now.Month, Date.Now.Day)


        Me.ServiciosTableAdapter.Fill(Me.ATCDataSet.Servicios)
        Me.ClientesTableAdapter.Fill(Me.ATCDataSet.Clientes)
        Me.EmpleadosTableAdapter.Fill(Me.ATCDataSet.Empleados)
        Me.IdTextBox1.Text = -1
        Me.IdTextBox1.Enabled = False
        Me.ClienteComboBox.SelectedIndex = -1
        Me.ServicioComboBox.SelectedIndex = -1
        Me.EmpleadosComboBox.SelectedIndex = -1
        Me.Button4.Visible = False
        VerificarHora()
    End Sub

    Public Sub New(Empleado_Id As Integer, Fecha As Date)
        Me.New()

        Me.EmpleadosComboBox.SelectedValue = Empleado_Id
        Me.FechaDateTimePicker1.Value = Fecha

    End Sub
    Public Sub New(Empleado_Id As Integer, Fecha As Date, hora As TimeSpan)
        Me.New()
        Try
            Me.EmpleadosComboBox.SelectedValue = Empleado_Id
            Me.FechaDateTimePicker1.Value = Fecha
            Me.HoraDateTimePicker.Value = New Date(Now.Year, Now.Month, Now.Day, hora.Hours, hora.Minutes, 0)
        Catch ex As Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub New(id As Integer, Empleado_Id As Integer, Cliente_Id As Integer, Servicio_Id As Integer, Fecha As Date, hora As TimeSpan)
        Me.New()
        Me.Button4.Visible = True


        id_ant = id
        emp_ant = Empleado_Id
        cli_ant = Cliente_Id
        ser_ant = Servicio_Id
        fecha_ant = Fecha
        hora_ant = hora


        Me.IdTextBox1.Text = id
        Me.EmpleadosComboBox.SelectedValue = Empleado_Id
        Me.ClienteComboBox.SelectedValue = Cliente_Id
        Me.ServicioComboBox.SelectedValue = Servicio_Id
        Me.FechaDateTimePicker1.Value = Fecha
        Me.HoraDateTimePicker.Value = New Date(Now.Year, Now.Month, Now.Day, hora.Hours, hora.Minutes, 0)
    End Sub

 
    
    Private Sub Back_Boton_Click(sender As System.Object, e As System.EventArgs) Handles Back_Boton.Click
        Main.LoadScreen(New Calendario, MoveDirection.Out)
    End Sub

  
    Private Sub HoraDateTimePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles HoraDateTimePicker.ValueChanged
        VerificarHora()
    End Sub

    Private Sub btnguardar_Click(sender As System.Object, e As System.EventArgs) Handles btnguardar.Click
        If Me.IdTextBox1.Text = -1 Then
            Try
                If (ClienteComboBox.SelectedIndex <> -1 And EmpleadosComboBox.SelectedIndex <> -1 And ServicioComboBox.SelectedIndex <> -1) Then
                    Me.AgendaTableAdapter.Insert(FechaDateTimePicker1.Value, New TimeSpan(HoraDateTimePicker.Value.Hour, HoraDateTimePicker.Value.Minute, 0), (ClienteComboBox.SelectedValue), (EmpleadosComboBox.SelectedValue), (ServicioComboBox.SelectedValue), TiempoNumericUpDown.Value, "NULL")
                    Main.ShowMessage("Cambios Guardados", "Se han guardado correctamente los cambios realizados.", Color.FromArgb(20, 184, 56), MsgBoxStyle.OkOnly)
                    Main.LoadScreen(New Calendario(FechaDateTimePicker1.Value, EmpleadosComboBox.SelectedIndex), MoveDirection.BackIn)
                Else
                    Main.ShowMessage("Atención!", "Faltan Datos Por ingresar.", Color.FromArgb(20, 184, 56), MsgBoxStyle.OkOnly)
                End If

            Catch ex As Exception
                Main.ShowMessage("Atención!", "Algo no ha salido bien y no se pudo completar la acción solicitada.", Color.FromArgb(20, 184, 56), MsgBoxStyle.OkOnly)
            End Try
        Else

            Try
                If (ClienteComboBox.SelectedIndex <> -1 And EmpleadosComboBox.SelectedIndex <> -1 And ServicioComboBox.SelectedIndex <> -1) Then
                    Me.AgendaTableAdapter.Update(FechaDateTimePicker1.Value, New TimeSpan(HoraDateTimePicker.Value.Hour, HoraDateTimePicker.Value.Minute, 0).ToString(), (ClienteComboBox.SelectedValue), (EmpleadosComboBox.SelectedValue), (ServicioComboBox.SelectedValue), TiempoNumericUpDown.Value, "NULL", id_ant)




                    Main.ShowMessage("Cambios Guardados", "Se han guardado correctamente los cambios realizados.", Color.FromArgb(20, 184, 56), MsgBoxStyle.OkOnly)

                    Main.LoadScreen(New Calendario(FechaDateTimePicker1.Value, EmpleadosComboBox.SelectedIndex), MoveDirection.BackIn)
                Else
                    Main.ShowMessage("Atención!", "Faltan Datos Por ingresar.", Color.FromArgb(20, 184, 56), MsgBoxStyle.OkOnly)
                End If

            Catch ex As Exception
                Main.ShowMessage("Atención!", "Algo no ha salido bien y no se pudo completar la acción solicitada.", Color.FromArgb(20, 184, 56), MsgBoxStyle.OkOnly)
            End Try

        End If
        



        'Main.ShowMessage("Cambios Guardados", "Se han guardado correctamente los cambios realizados.", Color.FromArgb(20, 184, 56), MsgBoxStyle.OkOnly)
    End Sub

    Private Sub Agregar_Cita_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ATCDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.ATCDataSet.Servicios)
        'TODO: esta línea de código carga datos en la tabla 'ATCDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ATCDataSet.Empleados)
        'TODO: esta línea de código carga datos en la tabla 'ATCDataSet.Agenda' Puede moverla o quitarla según sea necesario.
        Me.AgendaTableAdapter.Fill(Me.ATCDataSet.Agenda)
        'TODO: esta línea de código carga datos en la tabla 'ATCDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ATCDataSet.Clientes)

    End Sub

    Private Sub VerificarHora()
        If Me.HoraDateTimePicker.Value.Hour < 6 Then
            Me.HoraDateTimePicker.Value = New Date(Now.Year, Now.Month, Now.Day, 6, Me.HoraDateTimePicker.Value.Minute, 0)
            Me.Label_Mensaje.Text = "La hora seleccionada no puede ser menor a 6"
        Else
            If Me.HoraDateTimePicker.Value.Hour > 21 Then
                Me.HoraDateTimePicker.Value = New Date(Now.Year, Now.Month, Now.Day, 20, Me.HoraDateTimePicker.Value.Minute, 0)
                Me.Label_Mensaje.Text = "La hora seleccionada no puede ser mayor a 20"
            Else
                Me.Label_Mensaje.Text = ""
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Main.LoadScreen(New Servicios(-1, Me), MoveDirection.BackIn)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Main.LoadScreen(New Clientes(-1, Me), MoveDirection.BackIn)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Consulta.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If Main.ShowMessage("Quitar Cliente", "Se dispone a quitar un cliente del sistema, esta acción no puede ser reversada, desea continuar?", Color.FromArgb(20, 184, 56), MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Try
                Me.AgendaTableAdapter.Delete(id_ant)
                Main.LoadScreen(New Calendario(), MoveDirection.BackIn)
            Catch ex As Exception
                Main.ShowMessage("Atención!", "Algo no ha salido bien y no se pudo completar la acción solicitada.", Color.FromArgb(20, 184, 56), MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub
End Class
