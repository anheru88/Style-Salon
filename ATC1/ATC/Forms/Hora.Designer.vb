<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hora
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hora))
        Me.Barra = New System.Windows.Forms.Panel()
        Me.Label_Hora = New System.Windows.Forms.Label()
        Me.Label_Texto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Barra
        '
        Me.Barra.BackColor = System.Drawing.Color.SeaGreen
        resources.ApplyResources(Me.Barra, "Barra")
        Me.Barra.Name = "Barra"
        '
        'Label_Hora
        '
        resources.ApplyResources(Me.Label_Hora, "Label_Hora")
        Me.Label_Hora.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label_Hora.Name = "Label_Hora"
        '
        'Label_Texto
        '
        resources.ApplyResources(Me.Label_Texto, "Label_Texto")
        Me.Label_Texto.Name = "Label_Texto"
        '
        'Hora
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label_Texto)
        Me.Controls.Add(Me.Label_Hora)
        Me.Controls.Add(Me.Barra)
        Me.Name = "Hora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Barra As System.Windows.Forms.Panel
    Friend WithEvents Label_Hora As System.Windows.Forms.Label
    Friend WithEvents Label_Texto As System.Windows.Forms.Label

End Class
