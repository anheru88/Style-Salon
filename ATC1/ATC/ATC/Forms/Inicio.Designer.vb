<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits HtmlForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.controlPanel = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.journeysBtn = New System.Windows.Forms.Button()
        Me.usersBtn = New System.Windows.Forms.Button()
        Me.messagesBtn = New System.Windows.Forms.Button()
        Me.employeesBtn = New System.Windows.Forms.Button()
        Me.categorysBtn = New System.Windows.Forms.Button()
        Me.configBtn = New System.Windows.Forms.Button()
        Me.officesBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.controlPanel.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'controlPanel
        '
        Me.controlPanel.Controls.Add(Me.FlowLayoutPanel1)
        Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.controlPanel.Location = New System.Drawing.Point(0, 100)
        Me.controlPanel.Name = "controlPanel"
        Me.controlPanel.Size = New System.Drawing.Size(828, 368)
        Me.controlPanel.TabIndex = 20
        Me.controlPanel.Tag = "move,0"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.Controls.Add(Me.journeysBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.usersBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.messagesBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.employeesBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.categorysBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.configBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.officesBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(37, 27)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(745, 243)
        Me.FlowLayoutPanel1.TabIndex = 11
        '
        'journeysBtn
        '
        Me.journeysBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.journeysBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.journeysBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.journeysBtn.FlatAppearance.BorderSize = 0
        Me.journeysBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.journeysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.journeysBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.journeysBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.journeysBtn.Image = Global.StyleSalon.My.Resources.Resources.Journeys
        Me.journeysBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.journeysBtn.Location = New System.Drawing.Point(5, 5)
        Me.journeysBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.journeysBtn.Name = "journeysBtn"
        Me.journeysBtn.Size = New System.Drawing.Size(139, 111)
        Me.journeysBtn.TabIndex = 11
        Me.journeysBtn.Tag = "2"
        Me.journeysBtn.Text = "Agenda"
        Me.journeysBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.journeysBtn.UseVisualStyleBackColor = False
        '
        'usersBtn
        '
        Me.usersBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usersBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.usersBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersBtn.FlatAppearance.BorderSize = 0
        Me.usersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersBtn.Image = Global.StyleSalon.My.Resources.Resources.users
        Me.usersBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersBtn.Location = New System.Drawing.Point(154, 5)
        Me.usersBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.usersBtn.Name = "usersBtn"
        Me.usersBtn.Size = New System.Drawing.Size(139, 111)
        Me.usersBtn.TabIndex = 14
        Me.usersBtn.Tag = "5"
        Me.usersBtn.Text = "Clientes"
        Me.usersBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.usersBtn.UseVisualStyleBackColor = False
        '
        'messagesBtn
        '
        Me.messagesBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.messagesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.messagesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.messagesBtn.FlatAppearance.BorderSize = 0
        Me.messagesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.messagesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.messagesBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.messagesBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.messagesBtn.Image = Global.StyleSalon.My.Resources.Resources.Messages
        Me.messagesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.messagesBtn.Location = New System.Drawing.Point(303, 5)
        Me.messagesBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.messagesBtn.Name = "messagesBtn"
        Me.messagesBtn.Size = New System.Drawing.Size(139, 111)
        Me.messagesBtn.TabIndex = 12
        Me.messagesBtn.Tag = "3"
        Me.messagesBtn.Text = "Servicios"
        Me.messagesBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.messagesBtn.UseVisualStyleBackColor = False
        '
        'employeesBtn
        '
        Me.employeesBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.employeesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.employeesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.employeesBtn.FlatAppearance.BorderSize = 0
        Me.employeesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.employeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.employeesBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.employeesBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.employeesBtn.Image = CType(resources.GetObject("employeesBtn.Image"), System.Drawing.Image)
        Me.employeesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.employeesBtn.Location = New System.Drawing.Point(452, 5)
        Me.employeesBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.employeesBtn.Name = "employeesBtn"
        Me.employeesBtn.Size = New System.Drawing.Size(139, 111)
        Me.employeesBtn.TabIndex = 20
        Me.employeesBtn.Tag = "1"
        Me.employeesBtn.Text = "Empleados"
        Me.employeesBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.employeesBtn.UseVisualStyleBackColor = False
        '
        'categorysBtn
        '
        Me.categorysBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.categorysBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.categorysBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.categorysBtn.FlatAppearance.BorderSize = 0
        Me.categorysBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.categorysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.categorysBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.categorysBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.categorysBtn.Image = Global.StyleSalon.My.Resources.Resources.category
        Me.categorysBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.categorysBtn.Location = New System.Drawing.Point(601, 5)
        Me.categorysBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.categorysBtn.Name = "categorysBtn"
        Me.categorysBtn.Size = New System.Drawing.Size(139, 111)
        Me.categorysBtn.TabIndex = 13
        Me.categorysBtn.Tag = "12"
        Me.categorysBtn.Text = "Usuarios"
        Me.categorysBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.categorysBtn.UseVisualStyleBackColor = False
        '
        'configBtn
        '
        Me.configBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.configBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.configBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.configBtn.FlatAppearance.BorderSize = 0
        Me.configBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.configBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.configBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.configBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.configBtn.Image = Global.StyleSalon.My.Resources.Resources.config
        Me.configBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.configBtn.Location = New System.Drawing.Point(5, 126)
        Me.configBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.configBtn.Name = "configBtn"
        Me.configBtn.Padding = New System.Windows.Forms.Padding(5)
        Me.configBtn.Size = New System.Drawing.Size(139, 111)
        Me.configBtn.TabIndex = 16
        Me.configBtn.Tag = "10"
        Me.configBtn.Text = "Configuración"
        Me.configBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.configBtn.UseVisualStyleBackColor = False
        '
        'officesBtn
        '
        Me.officesBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.officesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.officesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.officesBtn.FlatAppearance.BorderSize = 0
        Me.officesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.officesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.officesBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.officesBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.officesBtn.Image = Global.StyleSalon.My.Resources.Resources.offices
        Me.officesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.officesBtn.Location = New System.Drawing.Point(154, 126)
        Me.officesBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.officesBtn.Name = "officesBtn"
        Me.officesBtn.Size = New System.Drawing.Size(139, 111)
        Me.officesBtn.TabIndex = 10
        Me.officesBtn.Tag = "1"
        Me.officesBtn.Text = "Oficinas"
        Me.officesBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.officesBtn.UseVisualStyleBackColor = False
        Me.officesBtn.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Image = Global.StyleSalon.My.Resources.Resources.areas
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(303, 126)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 111)
        Me.Button2.TabIndex = 17
        Me.Button2.Tag = "1"
        Me.Button2.Text = "Áreas"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Image = Global.StyleSalon.My.Resources.Resources.Computers
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(452, 126)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 111)
        Me.Button3.TabIndex = 18
        Me.Button3.Tag = "1"
        Me.Button3.Text = "Estaciones"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Image = Global.StyleSalon.My.Resources.Resources.Searchs
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(601, 126)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 111)
        Me.Button4.TabIndex = 19
        Me.Button4.Tag = "1"
        Me.Button4.Text = "Consultas"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Label15)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Padding = New System.Windows.Forms.Padding(20, 30, 0, 0)
        Me.Panel13.Size = New System.Drawing.Size(828, 100)
        Me.Panel13.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(20, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(295, 50)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Panel de Control"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.controlPanel)
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 468)
        Me.Panel1.TabIndex = 22
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(832, 500)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(832, 500)
        Me.Name = "Inicio"
        Me.Padding = New System.Windows.Forms.Padding(2, 30, 2, 2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anfitrión - Inicio"
        Me.controlPanel.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents controlPanel As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents journeysBtn As System.Windows.Forms.Button
    Friend WithEvents usersBtn As System.Windows.Forms.Button
    Friend WithEvents messagesBtn As System.Windows.Forms.Button
    Friend WithEvents categorysBtn As System.Windows.Forms.Button
    Friend WithEvents configBtn As System.Windows.Forms.Button
    Friend WithEvents officesBtn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents employeesBtn As System.Windows.Forms.Button
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
