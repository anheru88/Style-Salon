Public Class Dia

    Dim v_fecha As Date

    Public Property Fecha As Date
        Get
            Return v_fecha
        End Get
        Set(value As Date)
            v_fecha = value
            Me.dayNumberLbl.Text = v_fecha.Day
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
        Me.Fecha = Now
    End Sub

    Public Sub New(t_fecha As Date, citas As List(Of ATCDataSet.AgendaRow))
        InitializeComponent()
        v_fecha = t_fecha
        Me.Fecha = t_fecha
        Me.BackColor = If(t_fecha.DayOfWeek = 0, Color.Gainsboro, Color.White)

        For Each item In (From cita In citas Order By cita.Fecha Descending)

            Dim t_label As New Label
            Dim tdate = CDate(item.Hora.ToString)
            t_label.Text = String.Format("{0}:{4} {1} de {2} atendido por {3}", Format(tdate, "hh:mm tt"), item.NombreServicio, item.Nombre, item.NombreEmpleado, vbCrLf)
            't_label.BackColor = item.Color
            ToolTip1.SetToolTip(t_label, t_label.Text)
            't_label.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            t_label.Dock = DockStyle.Top
            t_label.Tag = item.Id

            t_label.BackColor = If(t_fecha.DayOfWeek = 0, Color.Gainsboro, Color.White)
            t_label.ForeColor = Color.Black
            t_label.Cursor = Cursors.Hand

            AddHandler t_label.MouseMove, AddressOf Lbl_MouseMove
            AddHandler t_label.MouseLeave, AddressOf Lbl_MouseLeave
            AddHandler t_label.DoubleClick, AddressOf Lbl_DoubleClick

            Me.Panel1.Controls.Add(t_label)

            t_label.SendToBack()

        Next

    End Sub

    Dim t_mouseOver As Boolean = False

    Private Sub Lbl_DoubleClick(sender As Object, e As EventArgs)
        Me.Parent.Visible = False
        vg_showCalendar = False
        Main.LoadScreen(New Agenda(CInt(sender.tag)), MoveDirection.BackIn)
    End Sub

    Private Sub Lbl_MouseLeave(sender As Object, e As EventArgs)
        With CType(sender, Label)
            If CInt(.Tag) > 0 Then
                .BackColor = If(Fecha.DayOfWeek = 0, Color.Gainsboro, Color.White)
                .ForeColor = Color.Black
            End If
        End With
    End Sub

    Private Sub Lbl_MouseMove(sender As Object, e As MouseEventArgs)
        With CType(sender, Label)
            If CInt(.Tag) > 0 Then
                .BackColor = Color.FromArgb(20, 184, 56)
                .ForeColor = Color.White
            End If
        End With
    End Sub

    Private Sub dayNumberLbl_MouseLeave(sender As Object, e As EventArgs) Handles dayNumberLbl.MouseLeave, Panel1.MouseLeave
        If t_mouseOver = True Then
            t_mouseOver = False
            Me.BackColor = If(Fecha.DayOfWeek = 0, Color.Gainsboro, Color.White)
            Me.dayNumberLbl.ForeColor = Color.Black
        End If
    End Sub

    Private Sub dayNumberLbl_MouseMove(sender As Object, e As MouseEventArgs) Handles dayNumberLbl.MouseMove, Panel1.MouseMove
        If t_mouseOver = False Then
            t_mouseOver = True
            Me.BackColor = Color.FromArgb(20, 184, 56)
            Me.dayNumberLbl.ForeColor = Color.White
        End If
    End Sub

    Private Sub dayNumberLbl_Click(sender As Object, e As EventArgs) Handles dayNumberLbl.Click, Panel1.Click
        Me.Parent.Visible = False
        vg_showCalendar = False
        Main.LoadScreen(New Agenda(Me.Fecha), MoveDirection.BackIn)
    End Sub

End Class
