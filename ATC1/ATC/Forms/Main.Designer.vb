<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.HtmlForm

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.FormsMove = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SearchsMove = New System.Windows.Forms.Timer(Me.components)
        Me.msgBoxPanel = New System.Windows.Forms.Panel()
        Me.msgBoxMessage = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.msgBoxNoButton = New System.Windows.Forms.Button()
        Me.msgBoxOkButton = New System.Windows.Forms.Button()
        Me.msgBoxTitle = New System.Windows.Forms.Label()
        Me.Screen = New System.Windows.Forms.Panel()
        Me.msgBoxContainer = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.msgBoxPanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.msgBoxContainer.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormsMove
        '
        Me.FormsMove.Interval = 25
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SearchsMove
        '
        Me.SearchsMove.Interval = 1
        '
        'msgBoxPanel
        '
        Me.msgBoxPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msgBoxPanel.AutoSize = True
        Me.msgBoxPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.msgBoxPanel.Controls.Add(Me.msgBoxMessage)
        Me.msgBoxPanel.Controls.Add(Me.Panel4)
        Me.msgBoxPanel.Controls.Add(Me.msgBoxTitle)
        Me.msgBoxPanel.Location = New System.Drawing.Point(0, 344)
        Me.msgBoxPanel.Name = "msgBoxPanel"
        Me.msgBoxPanel.Padding = New System.Windows.Forms.Padding(70, 20, 50, 10)
        Me.msgBoxPanel.Size = New System.Drawing.Size(987, 224)
        Me.msgBoxPanel.TabIndex = 0
        '
        'msgBoxMessage
        '
        Me.msgBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.msgBoxMessage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgBoxMessage.ForeColor = System.Drawing.Color.White
        Me.msgBoxMessage.Location = New System.Drawing.Point(70, 52)
        Me.msgBoxMessage.Name = "msgBoxMessage"
        Me.msgBoxMessage.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.msgBoxMessage.Size = New System.Drawing.Size(867, 107)
        Me.msgBoxMessage.TabIndex = 1
        Me.msgBoxMessage.Text = "message"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.FlowLayoutPanel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(70, 159)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(867, 55)
        Me.Panel4.TabIndex = 2
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.msgBoxNoButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.msgBoxOkButton)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(867, 55)
        Me.FlowLayoutPanel3.TabIndex = 2
        '
        'msgBoxNoButton
        '
        Me.msgBoxNoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msgBoxNoButton.BackColor = System.Drawing.Color.White
        Me.msgBoxNoButton.FlatAppearance.BorderSize = 2
        Me.msgBoxNoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.msgBoxNoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.msgBoxNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.msgBoxNoButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgBoxNoButton.ForeColor = System.Drawing.Color.Black
        Me.msgBoxNoButton.Location = New System.Drawing.Point(732, 3)
        Me.msgBoxNoButton.Name = "msgBoxNoButton"
        Me.msgBoxNoButton.Size = New System.Drawing.Size(132, 49)
        Me.msgBoxNoButton.TabIndex = 1
        Me.msgBoxNoButton.Text = "No, gracias"
        Me.msgBoxNoButton.UseVisualStyleBackColor = False
        Me.msgBoxNoButton.Visible = False
        '
        'msgBoxOkButton
        '
        Me.msgBoxOkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msgBoxOkButton.BackColor = System.Drawing.Color.White
        Me.msgBoxOkButton.FlatAppearance.BorderSize = 2
        Me.msgBoxOkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.msgBoxOkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.msgBoxOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.msgBoxOkButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgBoxOkButton.ForeColor = System.Drawing.Color.Black
        Me.msgBoxOkButton.Location = New System.Drawing.Point(594, 3)
        Me.msgBoxOkButton.Name = "msgBoxOkButton"
        Me.msgBoxOkButton.Size = New System.Drawing.Size(132, 49)
        Me.msgBoxOkButton.TabIndex = 0
        Me.msgBoxOkButton.Text = "Ok, continuar"
        Me.msgBoxOkButton.UseVisualStyleBackColor = False
        Me.msgBoxOkButton.Visible = False
        '
        'msgBoxTitle
        '
        Me.msgBoxTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.msgBoxTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgBoxTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.msgBoxTitle.Location = New System.Drawing.Point(70, 20)
        Me.msgBoxTitle.Name = "msgBoxTitle"
        Me.msgBoxTitle.Size = New System.Drawing.Size(867, 32)
        Me.msgBoxTitle.TabIndex = 0
        Me.msgBoxTitle.Text = "Title"
        '
        'Screen
        '
        Me.Screen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Screen.Location = New System.Drawing.Point(2, 30)
        Me.Screen.Name = "Screen"
        Me.Screen.Size = New System.Drawing.Size(987, 756)
        Me.Screen.TabIndex = 0
        '
        'msgBoxContainer
        '
        Me.msgBoxContainer.Controls.Add(Me.msgBoxPanel)
        Me.msgBoxContainer.Controls.Add(Me.PictureBox2)
        Me.msgBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.msgBoxContainer.Location = New System.Drawing.Point(2, 30)
        Me.msgBoxContainer.Name = "msgBoxContainer"
        Me.msgBoxContainer.Size = New System.Drawing.Size(987, 756)
        Me.msgBoxContainer.TabIndex = 17
        Me.msgBoxContainer.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.StyleSalon.My.Resources.Resources.pixel
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(987, 756)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(991, 788)
        Me.Controls.Add(Me.msgBoxContainer)
        Me.Controls.Add(Me.Screen)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(805, 515)
        Me.Name = "Main"
        Me.Padding = New System.Windows.Forms.Padding(2, 30, 2, 2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salon Style - Panel de Control"
        Me.msgBoxPanel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.msgBoxContainer.ResumeLayout(False)
        Me.msgBoxContainer.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormsMove As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SearchsMove As System.Windows.Forms.Timer
    Friend WithEvents msgBoxPanel As System.Windows.Forms.Panel
    Friend WithEvents msgBoxMessage As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents msgBoxNoButton As System.Windows.Forms.Button
    Friend WithEvents msgBoxOkButton As System.Windows.Forms.Button
    Friend WithEvents msgBoxTitle As System.Windows.Forms.Label
    Friend WithEvents Screen As System.Windows.Forms.Panel
    Friend WithEvents msgBoxContainer As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
