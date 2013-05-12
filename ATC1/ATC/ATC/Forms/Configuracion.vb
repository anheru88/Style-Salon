Public Class Configuracion

    Private fromInicio As Boolean = False

    Public Connection As SqlClient.SqlConnection

    Public Sub New(from_Inicio As Boolean)

        InitializeComponent()

        fromInicio = from_Inicio

        Me.serverTxt.Text = My.Settings.server
        Me.userTxt.Text = My.Settings.user
        Me.passWordTxt.Text = My.Settings.password
        Me.databaseTxt.Text = My.Settings.database

    End Sub


    Private Sub TextBox1_MouseHover(sender As Object, e As System.EventArgs) Handles serverTxt.GotFocus, serverTxt.MouseHover, databaseTxt.MouseHover, databaseTxt.GotFocus, passWordTxt.MouseHover, passWordTxt.GotFocus, userTxt.MouseHover, userTxt.GotFocus
        With CType(sender, TextBox)
            .BackColor = Color.WhiteSmoke
        End With
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As System.EventArgs) Handles serverTxt.MouseLeave, serverTxt.LostFocus, databaseTxt.MouseLeave, databaseTxt.LostFocus, passWordTxt.MouseLeave, passWordTxt.LostFocus, userTxt.MouseLeave, userTxt.LostFocus
        With CType(sender, TextBox)
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        My.Settings.server = Me.serverTxt.Text
        My.Settings.user = Me.userTxt.Text
        My.Settings.password = Me.passWordTxt.Text
        My.Settings.database = Me.databaseTxt.Text

        Connection = testConnection()

        If Connection IsNot Nothing Then

            vg_conn = Connection

            My.Settings.Save()

            If fromInicio Then
                Main.ShowMessage("Cambios Guardados", "Se han guardado correctamente los cambios realizados.", Color.FromArgb(20, 167, 184), MsgBoxStyle.OkOnly)
            End If

            Me.Close()

        Else
            If fromInicio Then
                Main.ShowMessage("Atención!", "Algo no ha salido bien y no se pudo completar la acción solicitada.", Color.FromArgb(20, 167, 184), MsgBoxStyle.OkOnly)
            End If
        End If

    End Sub

    Private Sub usersBackBtn_Click(sender As Object, e As EventArgs) Handles usersBackBtn.Click
        If fromInicio = False Then
            Me.Close()
        Else
            Main.LoadScreen(New Inicio, MoveDirection.Out)
        End If

    End Sub

End Class
