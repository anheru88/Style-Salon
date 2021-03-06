﻿Public Class Clientes

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Size(0, 0)
    End Sub

    Dim t_edditing = False
    Dim t_origen As Form = Nothing

    Public Sub New()

        InitializeComponent()
        Me.TableAdapterManager.Connection = vg_conn
        Me.ClientesTableAdapter.Fill(Me.ATCDataSet.Clientes)

        searchPanel.Visible = True
        usersAddBtn.Visible = True

        Me.SplitContainer1.Panel2Collapsed = True

    End Sub

    Public Sub New(ByVal id As Integer, Optional origen As Form = Nothing)

        InitializeComponent()

        t_origen = origen

        Me.SplitContainer1.Panel1Collapsed = True

        Me.TableAdapterManager.Connection = vg_conn
        Me.ClientesTableAdapter.Fill(Me.ATCDataSet.Clientes)

        If id = -1 Then
            ClientesBindingSource.AddNew()
        Else
            ClientesBindingSource.Position = ClientesBindingSource.Find("Id", id)
        End If

        btnguardar.Visible = True

        t_edditing = True
        usersEditBtn.Visible = False

    End Sub

    Private Sub usersBackBtn_Click(sender As Object, e As EventArgs) Handles usersBackBtn.Click
        If t_origen IsNot Nothing Then
            vg_showCalendar = False
            Main.LoadScreen(New Calendario(), MoveDirection.Out)
        Else
            If t_edditing Then
                Main.LoadScreen(New Clientes, MoveDirection.Out)
            Else
                Main.LoadScreen(New Inicio, MoveDirection.Out)
            End If
        End If
    End Sub

    Private Sub ClientesDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ClientesDataGridView.SelectionChanged
        enableEdit()
    End Sub

    Private Sub usersEditBtn_Click(sender As Object, e As EventArgs) Handles usersEditBtn.Click
        Main.LoadScreen(New Clientes(ClientesBindingSource.Current!Id), MoveDirection.BackIn)
    End Sub

    Private Sub usersAddBtn_Click(sender As Object, e As EventArgs) Handles usersAddBtn.Click
        Main.LoadScreen(New Clientes(-1), MoveDirection.BackIn)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        save()
    End Sub

    Private Sub usersDeleteBtn_Click(sender As Object, e As EventArgs) Handles usersDeleteBtn.Click
        If Main.ShowMessage("Quitar Cliente", "Se dispone a quitar un cliente del sistema, esta acción no puede ser reversada, desea continuar?", Color.FromArgb(82, 135, 239), MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            Me.ClientesBindingSource.RemoveCurrent()
            save()
        End If
    End Sub

    Private Sub save()
        Try
            Me.Validate()
            Me.ClientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ATCDataSet)
            Main.ShowMessage("Cambios Guardados", "Se han guardado correctamente los cambios realizados.", Color.FromArgb(82, 135, 239), MsgBoxStyle.OkOnly)
        Catch ex As Exception
            Main.ShowMessage("Atención!", "Algo no ha salido bien y no se pudo completar la acción solicitada.", Color.FromArgb(82, 135, 239), MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.ClientesBindingSource.Filter = String.Format("CONVERT(Id, 'System.String') like '*{0}*' or Nombre like '*{0}*' or Cedula like '*{0}*' or Email like '*{0}*' or Celular like '*{0}*' or Telefono like '*{0}*' or Direccion like '*{0}*'", TextBox1.Text)
    End Sub

    Private Sub ClientesBindingSource_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs)
        enableEdit()
    End Sub

    Private Sub enableEdit()
        usersEditBtn.Visible = (Me.ClientesBindingSource.Count > 0 And t_edditing = False)
        usersDeleteBtn.Visible = usersEditBtn.Visible
    End Sub

End Class
