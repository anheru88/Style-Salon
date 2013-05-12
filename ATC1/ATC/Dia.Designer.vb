<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dia
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
        Me.components = New System.ComponentModel.Container()
        Me.dayNumberLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'dayNumberLbl
        '
        Me.dayNumberLbl.BackColor = System.Drawing.Color.Transparent
        Me.dayNumberLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.dayNumberLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dayNumberLbl.Location = New System.Drawing.Point(0, 0)
        Me.dayNumberLbl.Name = "dayNumberLbl"
        Me.dayNumberLbl.Size = New System.Drawing.Size(101, 16)
        Me.dayNumberLbl.TabIndex = 0
        Me.dayNumberLbl.Tag = "0"
        Me.dayNumberLbl.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(101, 94)
        Me.Panel1.TabIndex = 1
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Dia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dayNumberLbl)
        Me.Name = "Dia"
        Me.Size = New System.Drawing.Size(101, 110)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dayNumberLbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
