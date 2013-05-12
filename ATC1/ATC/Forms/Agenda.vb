Public Class Agenda

    Dim v_curYear As Integer = Now.Year
    Dim v_curMonth As Integer = Now.Month
    Dim v_fecha As Date = Now

    Private Sub Agenda_Load(sender As Object, e As EventArgs)
        Me.MaximumSize = New Size(0, 0)
    End Sub

    Dim t_edditing = False

    Public Sub New()

        InitializeComponent()

        vg_fromDay = False
        Me.TextBox1.Text = vg_filter
        v_curMonth = vg_lastMonth

        Me.TableAdapterManager.Connection = vg_conn
        Me.AgendaTableAdapter.Fill(Me.ATCDataSet.Agenda)

        searchPanel.Visible = True
        usersAddBtn.Visible = True

        Me.SplitContainer1.Panel2Collapsed = True

        loadDays()

    End Sub

    Public Sub New(ByVal id As Integer)

        InitializeComponent()
        vg_showCalendar = False

        Me.TextBox1.Text = vg_filter

        Me.TableAdapterManager.Connection = vg_conn
        Me.EmpleadosTableAdapter.Fill(Me.ATCDataSet.Empleados)
        Me.ServiciosTableAdapter.Fill(Me.ATCDataSet.Servicios)
        Me.ClientesTableAdapter.Fill(Me.ATCDataSet.Clientes)

        Me.TableAdapterManager.Connection = vg_conn
        Me.AgendaTableAdapter.Fill(Me.ATCDataSet.Agenda)

        If id = -1 Then
            Me.SplitContainer1.Panel1Collapsed = True
            Me.SplitContainer2.Panel1Collapsed = True
            AgendaBindingSource.AddNew()
            Me.AgendaBindingSource.Current!Tiempo = 15
            Me.AgendaBindingSource.Current!Fecha = vg_lastDate
            Me.ClientesBindingSource.Position = -1
            HoraDateTimePicker.Value = CDate("01/01/1900 " & vg_lasttime.ToString)
            Me.AgendaBindingSource.Current!Empleado = vg_lastEmployee
            'Me.EmpleadosBindingSource.Position = Me.EmpleadosBindingSource.Find("Id", vg_lastEmployee)
        Else
            usersAddBtn.Visible = False
            searchPanel.Visible = False
            Me.AgendaBindingSource.Position = Me.AgendaBindingSource.Find("Id", id)
            HoraDateTimePicker.Value = CDate("01/01/1900 " & Me.AgendaBindingSource.Current!Hora.ToString)
            Me.SplitContainer1.Panel1Collapsed = True
            Me.SplitContainer2.Panel1Collapsed = True
            usersDeleteBtn.Visible = True
        End If

        btnguardar.Visible = True

        t_edditing = True
        usersEditBtn.Visible = False

    End Sub

    Public Sub New(ByVal fecha As Date)

        v_fecha = fecha

        InitializeComponent()
        Me.dateLbl.Text = FormatDateTime(fecha, DateFormat.LongDate)
        vg_showCalendar = False
        vg_lastDate = fecha

        vg_fromDay = True
        Me.TextBox1.Text = vg_filter

        Me.TableAdapterManager.Connection = vg_conn
        Me.ServiciosTableAdapter.Fill(Me.ATCDataSet.Servicios)
        Me.ClientesTableAdapter.Fill(Me.ATCDataSet.Clientes)
        Me.EmpleadosTableAdapter.Fill(Me.ATCDataSet.Empleados)

        Me.TableAdapterManager.Connection = vg_conn
        Me.AgendaTableAdapter.Fill(Me.ATCDataSet.Agenda)

        Me.SplitContainer1.Panel1Collapsed = True
        Me.SplitContainer2.Panel2Collapsed = True

        HoraDateTimePicker.MinDate = Now

        searchPanel.Visible = True
        usersAddBtn.Visible = True
        usersEditBtn.Visible = False


        For Each employee As ATCDataSet.EmpleadosRow In EmpleadosTableAdapter.GetData.Rows

            Dim t_pict As New PictureBox With {.Image = Byte2Image(employee.Foto), .SizeMode = PictureBoxSizeMode.Zoom, .Cursor = Cursors.Hand}

            employeesContainer.Controls.Add(t_pict)

            Me.ToolTip1.SetToolTip(t_pict, employee.Nombre)

            t_pict.Dock = DockStyle.Left
            t_pict.Tag = employee
            t_pict.BringToFront()

            AddHandler t_pict.Click, AddressOf Pict_Click
            AddHandler t_pict.MouseMove, AddressOf pict_MouseMove
            AddHandler t_pict.MouseLeave, AddressOf pict_MouseLeave

            t_pict.Show()

        Next

        filter()

    End Sub

    Private Sub Pict_Click(sender As Object, e As EventArgs)

        PictureBox8.Image = sender.image

        Dim t_rows As List(Of ATCDataSet.AgendaRow) = (From item In Me.AgendaTableAdapter.GetData.ToList Where item.Empleado = sender.tag.Id And item.Fecha = v_fecha).ToList

        Me.timeLineContainer.Controls.Clear()

        For h As Integer = 8 To 20
            'For q = 0 To 3
            Dim t_time As New TimeSpan(h, 0, 0)
            Dim t_cita As New Cita(t_time, sender.tag.Id)
            t_cita.Tag = t_time
            Try
                Dim t_event = (From item In t_rows Where item.Hora.Hours = t_time.Hours And item.Hora.Minutes >= t_time.Minutes And item.Hora.Minutes < (t_time.Minutes + 60)).ToList(0)
                t_cita.Label1.Text = t_event.NombreServicio & " con " & t_event.Nombre
                t_cita.Label1.Cursor = Cursors.Hand
                t_cita.Label1.Tag = t_event.Id
                t_cita.Evento = t_event.Id
                t_cita.Tipo = 0
            Catch ex As Exception
                t_cita.Tipo = 1
            End Try
            t_cita.Dock = DockStyle.Top
            Me.timeLineContainer.Controls.Add(t_cita)
            t_cita.BringToFront()
            t_cita.Show()
        Next

    End Sub

    Private Sub pict_MouseLeave(sender As Object, e As EventArgs)
        sender.BackColor = Color.Transparent
        sender.BorderStyle = BorderStyle.None
    End Sub

    Private Sub pict_MouseMove(sender As Object, e As MouseEventArgs)
        sender.BackColor = Color.FromArgb(20, 184, 56)
        sender.BorderStyle = BorderStyle.None
    End Sub

    Private v_panelMoveDir As Integer = 0
    Private v_panelMove As Boolean = False

    Private Sub loadDays()

        For i As Integer = 1 To 12
            Me.meses.Items.Add(MonthName(i))
            Me.meses.Items(i - 1).Tag = i
            AddHandler Me.meses.Items(i - 1).Click, AddressOf mes_Click
        Next

        For i As Integer = 2010 To Now.Year + 10
            Me.años.Items.Add(i)
            AddHandler Me.años.Items(i - 2010).Click, AddressOf Año_Click
        Next


        Label11.Text = v_curYear
        Label10.Text = MonthName(v_curMonth)

        loadMonth()

    End Sub

    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs)
        v_panelMoveDir = 1
        v_panelMove = True
    End Sub

    Private Sub PictureBox5_MouseDown(sender As Object, e As MouseEventArgs)
        v_panelMoveDir = 0
        v_panelMove = True
    End Sub

    Private Sub PictureBox4_MouseUp(sender As Object, e As MouseEventArgs)
        v_panelMove = False
    End Sub

    Private Sub move_Tick(sender As Object, e As EventArgs) Handles move.Tick
        moveTimeLine()
    End Sub

    Private Sub moveTimeLine()
        If v_panelMove = True Then
            Select Case v_panelMoveDir
                Case 0
                    If Me.timeLineContainer.Top > Me.timeLinePanel.Height - Me.timeLineContainer.Height Then
                        Me.timeLineContainer.Top -= 100
                    End If
                Case 1
                    If Me.timeLineContainer.Top + 100 <= 0 Then
                        Me.timeLineContainer.Top += 100
                    End If
            End Select
        End If
    End Sub

    Private Sub mes_Click(sender As Object, e As EventArgs)
        Me.Label10.Text = MonthName(sender.tag)
        v_curMonth = CInt(sender.tag)
        loadMonth()
    End Sub

    Private Sub Año_Click(sender As Object, e As EventArgs)
        Me.Label11.Text = sender.text
        v_curYear = CInt(sender.text)
        loadMonth()
    End Sub

    Private Sub usersBackBtn_Click(sender As Object, e As EventArgs) Handles usersBackBtn.Click
        vg_showCalendar = False
        calendario.Visible = False

        If vg_fromDay Then
            If t_edditing Then
                Main.LoadScreen(New Agenda(CDate(AgendaBindingSource.Current!Fecha)), MoveDirection.Out)
            Else
                Main.LoadScreen(New Agenda, MoveDirection.Out)
            End If
        Else
            If t_edditing Then
                Main.LoadScreen(New Agenda, MoveDirection.Out)
            Else
                Main.LoadScreen(New Inicio, MoveDirection.Out)
            End If
        End If

    End Sub

    Private Sub AgendaDataGridView_SelectionChanged(sender As Object, e As EventArgs)
        enableEdit()
    End Sub

    Private Sub usersEditBtn_Click(sender As Object, e As EventArgs) Handles usersEditBtn.Click
        vg_showCalendar = False
        calendario.Visible = False
        Main.LoadScreen(New Agenda(CInt(AgendaBindingSource.Current!Id)), MoveDirection.BackIn)
    End Sub

    Private Sub usersAddBtn_Click(sender As Object, e As EventArgs) Handles usersAddBtn.Click
        If SplitContainer1.Panel1Collapsed = False Then
            vg_lastDate = New Date(v_curYear, v_curMonth, 1)
        End If
        vg_showCalendar = False
        calendario.Visible = False
        Main.LoadScreen(New Agenda(-1), MoveDirection.BackIn)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        save()
    End Sub

    Private Sub usersDeleteBtn_Click(sender As Object, e As EventArgs) Handles usersDeleteBtn.Click
        If Main.ShowMessage("Quitar Cita", "Se dispone a quitar una cita del sistema, esta acción no puede ser reversada, desea continuar?", Color.FromArgb(20, 184, 56), MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Me.AgendaBindingSource.RemoveCurrent()
            save()
            vg_showCalendar = False
            calendario.Visible = False
            Main.LoadScreen(New Agenda, MoveDirection.Out)
        End If
    End Sub

    Private Sub save()
        Try
            Me.AgendaBindingSource.Current!Hora = New TimeSpan(HoraDateTimePicker.Value.Hour, HoraDateTimePicker.Value.Minute, 0)
            Me.Validate()
            Me.AgendaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ATCDataSet)
            Main.ShowMessage("Cambios Guardados", "Se han guardado correctamente los cambios realizados.", Color.FromArgb(20, 184, 56), MsgBoxStyle.OkOnly)
        Catch ex As Exception
            Main.ShowMessage("Atención!", "Algo no ha salido bien y no se pudo completar la acción solicitada.", Color.FromArgb(20, 184, 56), MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        vg_filter = If(TextBox1.Text = "", vbNullString, TextBox1.Text)
        filter()
    End Sub

    Private Sub filter()
        If Me.SplitContainer1.Panel1Collapsed = True And Me.SplitContainer2.Panel1Collapsed = False Then
            Me.AgendaBindingSource.Filter = String.Format("(CONVERT(Id, 'System.String') like '*{0}*' or Nombre like '*{0}*' or NombreServicio like '*{0}*' or NombreEmpleado like '*{0}*') and CONVERT(Fecha, 'System.String') like '*{1}*'", vg_filter, Format(vg_lastDate, "dd/MM/yyyy"))
        Else
            Me.AgendaBindingSource.Filter = String.Format("CONVERT(Id, 'System.String') like '*{0}*' or CONVERT(Fecha, 'System.String') like '*{0}*' or Nombre like '*{0}*'  or NombreServicio like '*{0}*' or NombreEmpleado like '*{0}*'", vg_filter)
        End If
        loadMonth()
    End Sub

    Private Sub AgendaBindingSource_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs)
        If SplitContainer2.Panel2Collapsed = True Then
            enableEdit()
        End If
        loadMonth()
    End Sub

    Private Sub enableEdit()
        If vg_fromDay Or t_edditing Then
            usersEditBtn.Visible = (Me.AgendaBindingSource.Count > 0 And t_edditing = False)
        End If
        'usersDeleteBtn.Visible = usersEditBtn.Visible
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.meses.Show(MousePosition)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.años.Show(MousePosition)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        v_curMonth -= 1

        If v_curMonth = 0 Then
            v_curMonth = 12
            v_curYear -= 1
            Label11.Text = v_curYear
        End If

        Label10.Text = MonthName(v_curMonth)

        loadMonth()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        v_curMonth += 1

        If v_curMonth = 13 Then
            v_curMonth = 1
            v_curYear += 1
            Label11.Text = v_curYear
        End If

        Label10.Text = MonthName(v_curMonth)

        loadMonth()

    End Sub

    Public Sub loadMonth()

        If vg_showCalendar And SplitContainer1.Panel1Collapsed = False Then

            calendario.Visible = False

            vg_lastMonth = v_curMonth

            Dim t_date As Date = New Date(v_curYear, v_curMonth, 1)

            Dim t_firstDay As Integer = t_date.DayOfWeek
            Dim t_lastday As Integer = Date.DaysInMonth(v_curYear, v_curMonth) + t_firstDay

            Dim t_endDate As Integer = Date.DaysInMonth(v_curYear, v_curMonth) - t_firstDay

            calendario.Controls.Clear()

            For i As Integer = 1 To t_firstDay
                calendario.Controls.Add(New Panel With {.Dock = DockStyle.Fill})
            Next

            For i As Integer = 1 To Date.DaysInMonth(v_curYear, v_curMonth)

                Dim t_fecha As Date = New Date(v_curYear, v_curMonth, i)
                Dim t_citas As List(Of ATCDataSet.AgendaRow) = (From item In AgendaTableAdapter.GetData.ToList _
                                                                Where FormatDateTime(item.Fecha, DateFormat.ShortDate).ToString = FormatDateTime(t_fecha, DateFormat.ShortDate).ToString _
                                                                And (If(vg_filter = vbNullString, True, _
                                                                       Format(item.Fecha, "dd/MM/yyy").Contains(vg_filter) _
                                                                       Or item.Nombre.ToLower.Trim.Contains(vg_filter.ToLower.Trim) _
                                                                       Or item.NombreServicio.ToLower.Trim.Contains(vg_filter.ToLower.Trim) _
                                                                       Or item.NombreEmpleado.ToLower.Trim.Contains(vg_filter.ToLower.Trim) _
                                                                       ))).ToList
                Dim t_dia As New Dia(t_fecha, t_citas)
                t_dia.Dock = DockStyle.Fill
                calendario.Controls.Add(t_dia)

                If t_fecha = FormatDateTime(Now, DateFormat.ShortDate) Then
                    t_dia.BorderStyle = BorderStyle.FixedSingle
                End If

            Next

            calendario.Visible = True

        End If
    End Sub

    Dim t_mooving As Boolean = True

    Private v_panelMoveDir2 As Integer = 0
    Private v_panelMove2 As Boolean = False

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        moveemployees()
    End Sub

    Private Sub PictureBox7_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseDown
        v_panelMoveDir2 = 1
        v_panelMove2 = True
    End Sub

    Private Sub PictureBox6_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseDown
        v_panelMoveDir2 = 0
        v_panelMove2 = True
    End Sub

    Private Sub PictureBox7_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseUp, PictureBox6.MouseUp
        v_panelMove2 = False
    End Sub

    Private Sub moveemployees()
        If v_panelMove2 = True Then
            Select Case v_panelMoveDir2
                Case 0
                    If Me.employeesContainer.Left > Me.employeesPanel.Width - Me.employeesContainer.Width Then
                        Me.employeesContainer.Left -= 50
                    End If
                Case 1
                    If Me.employeesContainer.Left <= 0 Then
                        Me.employeesContainer.Left += 50
                    End If
            End Select
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main.LoadScreen(New Servicios(-1, Me), MoveDirection.BackIn)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.LoadScreen(New Clientes(-1, Me), MoveDirection.BackIn)
    End Sub
End Class
