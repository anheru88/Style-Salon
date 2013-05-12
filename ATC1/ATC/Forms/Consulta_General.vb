Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Public Class Consulta_General
    Dim constr As String = My.MySettings.Default.connection
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim fecha, Sql As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Consulta.Show()
        Me.Close()
    End Sub

    Private Sub Consulta_General_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

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
            Dim col As New DataGridViewTextBoxColumn
            col.HeaderText = ds.Tables(0).Rows(counter).Item(1).ToString
            col.Name = ds.Tables(0).Rows(counter).Item(0).ToString

            DataGridView1.Columns.Add(col)

            counter += 1
        End While
        counter = 0
        While (counter < 12)
            Dim dgvRow As New DataGridViewRow
            dgvRow.ReadOnly = True
            DataGridView1.Rows.Add(dgvRow)
            counter += 1
        End While
        Dim rowNumber As Integer = 8
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For
            row.HeaderCell.Value = TimeSpan.FromHours(rowNumber).ToString
            rowNumber = rowNumber + 1
        Next
        DataGridView1.AutoResizeRowHeadersWidth( _
            DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
        cn.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ds.Clear()
        For Each celda As DataGridViewRow In DataGridView1.Rows
            Dim po As Integer = 0
            For Each columna As DataGridViewColumn In DataGridView1.Columns
                celda.Cells(po).Value = " "
                po += 1
            Next
        Next
        Me.DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
        fecha = Str(DateTimePicker1.Value.Year) + "/" + Str(DateTimePicker1.Value.Month) + "/" + Str(DateTimePicker1.Value.Day)
        For Each celda As DataGridViewRow In DataGridView1.Rows
            Dim fecha_header As String = celda.HeaderCell.Value
            If (fecha_header <> "") Then
                Dim posicion_celda As Integer = 0
                For Each columna As DataGridViewColumn In DataGridView1.Columns
                    Dim codigo_empleado As String = columna.Name.ToString
                    Dim fecha_parsiada As TimeSpan = TimeSpan.Parse(fecha_header)
                    Dim fecha_parsiadalimite As TimeSpan = fecha_parsiada.Add(TimeSpan.FromMinutes(59))
                    Sql = "select fecha,Hora,(select nombre from Servicios where id = Agenda.Servicio) as Servicio,(select Nombre from Clientes where id = Agenda.Cliente) As Cliente from Agenda where Fecha = '" + fecha + "' and empleado = " + codigo_empleado + " and (hora >= '" + fecha_parsiada.ToString + " 'and hora <= '" + fecha_parsiadalimite.ToString + "' )"
                    cn = New SqlConnection(constr)
                    cn.Open()
                    cm = New SqlCommand()
                    da = New SqlDataAdapter(Sql, cn)
                    da.Fill(ds)
                    Dim es As Integer = ds.Tables(0).Rows.Count
                    Dim counter = 0
                    While (counter < es)
                        celda.Cells(posicion_celda).Value += ds.Tables(0).Rows(counter).Item(1).ToString & "--" & ds.Tables(0).Rows(counter).Item(4).ToString & "                             "

                        counter += 1
                    End While
                    ds.Clear()
                    cn.Close()
                    posicion_celda += 1
                Next
            End If
        Next
        Me.DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
    End Sub
End Class
