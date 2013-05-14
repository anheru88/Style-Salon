Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Public Class Consulta
    Dim constr As String = My.MySettings.Default.connection
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet


    Private Sub Consulta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Label5.Text = ""
        Me.MaximumSize = New Size(0, 0)
        Dim num_controles As Int32 = Me.Panel1.Controls.Count - 1
        For n As Integer = num_controles To 0 Step -1
            Dim ctrl As Windows.Forms.Control = Me.Panel1.Controls(n)
            If (ctrl.Name <> "Panel6") Then
                Me.Panel1.Controls.Remove(ctrl)
            End If
        Next
        ds.Clear()
        Dim fecha, Sql As String
        fecha = Str(DateTimePicker1.Value.Year) + "/" + Str(DateTimePicker1.Value.Month) + "/" + Str(DateTimePicker1.Value.Day)
        Sql = "select Empleados.Id, Empleados.Nombre as Hora from Empleados"
        cn = New SqlConnection(constr)
        cn.Open()
        cm = New SqlCommand()
        da = New SqlDataAdapter(Sql, cn)
        da.Fill(ds)
        Dim es As Integer = ds.Tables(0).Rows.Count
        Dim y As Integer = 60
        Dim counter = 0

        While (counter < es)
            Dim lab As New Label
            lab.Name = ds.Tables(0).Rows(counter).Item(0).ToString
            lab.Cursor = Cursors.Hand
            lab.Top = y
            lab.Left = 15
            lab.Text = ds.Tables(0).Rows(counter).Item(1).ToString
            Me.Panel1.Controls.Add(lab)
            AddHandler lab.Click, AddressOf evento

            Dim canvas As New Microsoft.VisualBasic.PowerPacks.ShapeContainer
            Dim linea1 As New Microsoft.VisualBasic.PowerPacks.LineShape
            canvas.Parent = Panel1
            linea1.Parent = canvas
            linea1.StartPoint = New System.Drawing.Point(0, y + 23)
            linea1.EndPoint = New System.Drawing.Point(290, y + 23)
            y += 30
            counter = counter + 1
        End While
    End Sub
    Private Sub evento(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim num_controles1 As Int32 = Me.Panel7.Controls.Count - 1
        Me.Label5.Text = ""
        For n As Integer = num_controles1 To 0 Step -1
            Dim ctrl As Windows.Forms.Control = Me.Panel7.Controls(n)
            Me.Panel7.Controls.Remove(ctrl)
        Next
       
        Dim d As New Windows.Forms.Control
        Dim cm As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        d = sender
        ds.Clear()
        Dim fecha, Sql As String
        fecha = Str(DateTimePicker1.Value.Year) + "/" + Str(DateTimePicker1.Value.Month) + "/" + Str(DateTimePicker1.Value.Day)
        Sql = "select id as Id,Hora,Tiempo,(select Nombre from Clientes where id = Agenda.Cliente) As Cliente," +
        "(select Nombre from Servicios where id = Agenda.Servicio) As Servicio" +
        " from Agenda where fecha ='" + fecha + "' and Empleado = " + d.Name + "order by hora"
        cn = New SqlConnection(constr)
        cn.Open()
        cm = New SqlCommand()
        da = New SqlDataAdapter(Sql, cn)
        da.Fill(ds)
        Dim es As Integer = ds.Tables(0).Rows.Count
        Dim counter = 0
        Dim y As Integer = 15
        If (es <= 0) Then
            MsgBox("El usuario " + d.Text + " No tiene Eventos para esta Fecha", MsgBoxStyle.Critical)
        Else
            Dim fech_valida As String = Str(Now.Year) + "/" + Str(Now.Month) + "/" + Str(Now.Day)
            While (counter < es)
                Dim lab As New Label
                lab.Name = ds.Tables(0).Rows(counter).Item(0).ToString
                lab.Cursor = Cursors.Hand
                lab.Top = y
                lab.Left = 15
                lab.Width = 200
                'Dim hora As String = ds.Tables(0).Rows(counter).Item(1).ToString
                lab.Text = fecha + " -- " + ds.Tables(0).Rows(counter).Item(1).ToString + " -- " + ds.Tables(0).Rows(counter).Item(4).ToString
                AddHandler lab.Click, AddressOf evento_detalle
                'Dim ahora As TimeSpan = Now.TimeOfDay
                'Dim tiempo_duracion As TimeSpan = TimeSpan.FromMinutes(ds.Tables(0).Rows(counter).Item(2).ToString)
                'Dim turnChange As TimeSpan = TimeSpan.Parse(ds.Tables(0).Rows(counter).Item(1).ToString).Add(tiempo_duracion)
                'Dim comienzo As TimeSpan = TimeSpan.Parse(ds.Tables(0).Rows(counter).Item(1).ToString)
                Me.Panel7.Controls.Add(lab)
                y += 23
                counter += 1
            End While
        End If

    End Sub
    Private Sub evento_detalle(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim d As New Windows.Forms.Control
        Dim sql As String
        d = sender
        sql = "select id as Id,Hora,Tiempo,(select Nombre from Clientes where id = Agenda.Cliente) As Cliente," +
        "(select Nombre from Servicios where id = Agenda.Servicio) As Servicio,(select Nombre from Empleados where id = Agenda.Empleado) As Empleado" +
        " from Agenda where id ='" + d.Name + "'"
        cn = New SqlConnection(constr)
        cn.Open()
        cm = New SqlCommand()
        da = New SqlDataAdapter(sql, cn)
        da.Fill(ds)
        Dim es As Integer = ds.Tables(0).Rows.Count
        Dim counter = 0
        While (counter < es)
            Me.Label5.Text = "Servicio de " + ds.Tables(0).Rows(counter).Item(4).ToString + " al Sr(a) " + ds.Tables(0).Rows(counter).Item(3).ToString + " Atendido por " + ds.Tables(0).Rows(counter).Item(5).ToString + " Programado para las " + ds.Tables(0).Rows(counter).Item(1).ToString
            counter += 1
        End While
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click, ConsultaAddBtn.Click
        Consulta_General.Show()
        Me.Hide()
    End Sub

    Private Sub Back_Boton_Click(sender As System.Object, e As System.EventArgs) Handles Back_Boton.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub CalendarioAddBtn_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Consulta_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Main.Show()
        Me.Dispose()
    End Sub
End Class