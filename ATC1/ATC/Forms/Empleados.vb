Public Class Empleados

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ATCDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ATCDataSet.Empleados)
        Me.MaximumSize = New Size(0, 0)
    End Sub

    Dim t_edditing = False

    Public Sub New()

        InitializeComponent()
        Me.TableAdapterManager.Connection = vg_conn
        Me.EmpleadosTableAdapter.Fill(Me.ATCDataSet.Empleados)

        searchPanel.Visible = True
        usersAddBtn.Visible = True

        Me.SplitContainer1.Panel2Collapsed = True

    End Sub

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.SplitContainer1.Panel1Collapsed = True

        Me.TableAdapterManager.Connection = vg_conn
        Me.EmpleadosTableAdapter.Fill(Me.ATCDataSet.Empleados)

        If id = -1 Then
            EmpleadosBindingSource.AddNew()
        Else
            EmpleadosBindingSource.Position = EmpleadosBindingSource.Find("Id", id)
        End If

        btnguardar.Visible = True

        t_edditing = True
        usersEditBtn.Visible = False

    End Sub

    Private Sub usersBackBtn_Click(sender As Object, e As EventArgs) Handles usersBackBtn.Click
        If t_edditing Then
            Main.LoadScreen(New Empleados, MoveDirection.Out)
        Else
            Main.LoadScreen(New Inicio, MoveDirection.Out)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Me.OpenFileDialog1.Title = "Seleccionar imágen de usuario"
        Me.OpenFileDialog1.Filter = "Archivos de imágen (*.jpg,*.gif,*.png)|*.jpg;*.gif;*.png"

        If Me.OpenFileDialog1.ShowDialog(Me) = vbOK Then
            Me.PictureBox1.ImageLocation = Me.OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub ClientesDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ClientesDataGridView.SelectionChanged
        enableEdit()
    End Sub

    Private Sub usersEditBtn_Click(sender As Object, e As EventArgs) Handles usersEditBtn.Click
        Main.LoadScreen(New Empleados(EmpleadosBindingSource.Current!Id), MoveDirection.BackIn)
    End Sub

    Private Sub usersAddBtn_Click(sender As Object, e As EventArgs) Handles usersAddBtn.Click
        Main.LoadScreen(New Empleados(-1), MoveDirection.BackIn)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        save()
    End Sub

    Private Sub usersDeleteBtn_Click(sender As Object, e As EventArgs) Handles usersDeleteBtn.Click
        If Main.ShowMessage("Quitar Usuario", "Se dispone a quitar un suario del sistema, esta acción no puede ser reversada, desea continuar?", Color.FromArgb(237, 100, 53), MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            Me.EmpleadosBindingSource.RemoveCurrent()
            save()
        End If
    End Sub

    Private Sub save()
        Try
            Me.Validate()
            Me.EmpleadosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ATCDataSet)
            Main.ShowMessage("Cambios Guardados", "Se han guardado correctamente los cambios realizados.", Color.FromArgb(237, 100, 53), MsgBoxStyle.OkOnly)
        Catch ex As Exception
            Main.ShowMessage("Atención!", "Algo no ha salido bien y no se pudo completar la acción solicitada.", Color.FromArgb(237, 100, 53), MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.EmpleadosBindingSource.Filter = String.Format("CONVERT(Id, 'System.String') like '*{0}*' or Nombre like '*{0}*' or Identificacion Like '*{0}*'", TextBox1.Text)
    End Sub

    Private Sub EmpleadosBindingSource_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs)
        enableEdit()
    End Sub

    Private Sub enableEdit()
        usersEditBtn.Visible = (Me.EmpleadosBindingSource.Count > 0 And t_edditing = False)
        usersDeleteBtn.Visible = usersEditBtn.Visible
    End Sub

End Class
