Public Class Inicio

    Private Sub usersBtn_Click(sender As Object, e As EventArgs) Handles usersBtn.Click
        Main.LoadScreen(New Clientes, MoveDirection.BackIn)
    End Sub

    Private Sub categorysBtn_Click(sender As Object, e As EventArgs) Handles categorysBtn.Click
        Main.LoadScreen(New Usuarios, MoveDirection.BackIn)
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Size(0, 0)
    End Sub

    Private Sub configBtn_Click(sender As Object, e As EventArgs) Handles configBtn.Click
        Main.LoadScreen(New Configuracion(True), MoveDirection.BackIn)
    End Sub

    Private Sub messagesBtn_Click(sender As Object, e As EventArgs) Handles messagesBtn.Click
        Main.LoadScreen(New Servicios, MoveDirection.BackIn)
    End Sub

    Private Sub journeysBtn_Click(sender As Object, e As EventArgs) Handles journeysBtn.Click
        Main.LoadScreen(New Calendario, MoveDirection.BackIn)
    End Sub

    Private Sub employeesBtn_Click(sender As Object, e As EventArgs) Handles employeesBtn.Click
        Main.LoadScreen(New Empleados, MoveDirection.BackIn)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Consulta.Show()
        Me.Hide()
    End Sub
End Class
