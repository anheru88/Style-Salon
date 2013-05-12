Public Class Login

    Private Sub Base_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vg_conn = ValidateConnection()
        Me.TableAdapterManager.Connection = vg_conn
        Me.UsuariosTableAdapter.Fill(Me.ATCDataSet.Usuarios)

    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As System.EventArgs) Handles passWordTxt.MouseMove, passWordTxt.GotFocus, userTxt.MouseMove, userTxt.GotFocus
        With CType(sender, TextBox)
            .BackColor = Color.WhiteSmoke
        End With
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As System.EventArgs) Handles passWordTxt.MouseLeave, passWordTxt.LostFocus, userTxt.MouseLeave, userTxt.LostFocus
        With CType(sender, TextBox)
            If .Focused = False Then
                .BackColor = Me.BackColor
            End If
        End With
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click, Label2.Click
        Try
            If (From item In UsuariosTableAdapter.GetData.ToList Where item.Name = Me.userTxt.Text And item.Password = Me.passWordTxt.Text And item.Active = True).Count > 0 Then
                Main.Show()
                Me.Close()
            Else
                MsgBox("El usuario o la clave estan errados", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error en inicio de sesión.")
            End If
        Catch ex As Exception
            Dim t_dialog As New Configuracion(False)

            t_dialog.ShowDialog(Main)

            vg_conn = t_dialog.Connection

            Me.TableAdapterManager.Connection = vg_conn
        End Try
    End Sub


    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ATCDataSet)

    End Sub
End Class
