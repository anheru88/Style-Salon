Public Module Module1

    Public vg_conn As SqlClient.SqlConnection
    Public vg_showCalendar As Boolean = False
    Public vg_fromDay As Boolean = False
    Public vg_filter As String = ""
    Public vg_lastMonth As Integer = Now.Month
    Public vg_lastDate As Date = Now
    Public vg_lasttime As TimeSpan
    Public vg_lastEmployee As Integer

    Public ReadOnly Property vg_connectionString As String
        Get
            Return String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", _
                                 My.Settings.server, _
                                 My.Settings.database, _
                                 My.Settings.user, _
                                 My.Settings.password)
        End Get
    End Property


    Public Function ValidateConnection() As SqlClient.SqlConnection

        vg_conn = testConnection()

        If vg_conn Is Nothing Then
            Dim t_dialog As New Configuracion(False)

            t_dialog.ShowDialog(Main)

            vg_conn = t_dialog.Connection

            Return vg_conn
        Else
            Return vg_conn
        End If

    End Function

End Module
