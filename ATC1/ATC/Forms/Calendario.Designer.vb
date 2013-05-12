<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendario
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calendario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Fecha_Label = New System.Windows.Forms.Label()
        Me.Label_Empleado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Horario = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATCDataSet = New StyleSalon.ATCDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label_Agenda = New System.Windows.Forms.Label()
        Me.Back_Boton = New System.Windows.Forms.PictureBox()
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CalendarioAddBtn = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New StyleSalon.ATCDataSetTableAdapters.TableAdapterManager()
        Me.AgendaTableAdapter = New StyleSalon.ATCDataSetTableAdapters.AgendaTableAdapter()
        Me.EmpleadosTableAdapter = New StyleSalon.ATCDataSetTableAdapters.EmpleadosTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Back_Boton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(972, 775)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Fecha_Label)
        Me.Panel5.Controls.Add(Me.Label_Empleado)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Horario)
        Me.Panel5.Location = New System.Drawing.Point(482, 86)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(448, 508)
        Me.Panel5.TabIndex = 4
        Me.Panel5.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Fecha:"
        '
        'Fecha_Label
        '
        Me.Fecha_Label.AutoSize = True
        Me.Fecha_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_Label.Location = New System.Drawing.Point(67, 68)
        Me.Fecha_Label.Name = "Fecha_Label"
        Me.Fecha_Label.Size = New System.Drawing.Size(41, 15)
        Me.Fecha_Label.TabIndex = 26
        Me.Fecha_Label.Text = "Fecha"
        '
        'Label_Empleado
        '
        Me.Label_Empleado.AutoSize = True
        Me.Label_Empleado.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Empleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label_Empleado.Location = New System.Drawing.Point(9, 33)
        Me.Label_Empleado.Name = "Label_Empleado"
        Me.Label_Empleado.Size = New System.Drawing.Size(173, 25)
        Me.Label_Empleado.TabIndex = 25
        Me.Label_Empleado.Text = "Nombre_Empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Horario Empleado"
        '
        'Horario
        '
        Me.Horario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Horario.AutoSize = True
        Me.Horario.Location = New System.Drawing.Point(3, 96)
        Me.Horario.Name = "Horario"
        Me.Horario.Size = New System.Drawing.Size(442, 409)
        Me.Horario.TabIndex = 24
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.EmpleadosDataGridView)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(243, 86)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(233, 508)
        Me.Panel4.TabIndex = 3
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AllowUserToAddRows = False
        Me.EmpleadosDataGridView.AllowUserToDeleteRows = False
        Me.EmpleadosDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EmpleadosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.EmpleadosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.EmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpleadosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.EmpleadosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmpleadosDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.EmpleadosDataGridView.GridColor = System.Drawing.Color.WhiteSmoke
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(3, 51)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.ReadOnly = True
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(227, 446)
        Me.EmpleadosDataGridView.TabIndex = 22
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ATCDataSet
        '
        'ATCDataSet
        '
        Me.ATCDataSet.DataSetName = "ATCDataSet"
        Me.ATCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Empleados"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label_Agenda)
        Me.Panel3.Controls.Add(Me.Back_Boton)
        Me.Panel3.Controls.Add(Me.MonthCalendar)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(234, 591)
        Me.Panel3.TabIndex = 2
        '
        'Label_Agenda
        '
        Me.Label_Agenda.AutoSize = True
        Me.Label_Agenda.Font = New System.Drawing.Font("Segoe UI", 27.8!)
        Me.Label_Agenda.Location = New System.Drawing.Point(78, 13)
        Me.Label_Agenda.Name = "Label_Agenda"
        Me.Label_Agenda.Size = New System.Drawing.Size(152, 51)
        Me.Label_Agenda.TabIndex = 5
        Me.Label_Agenda.Text = "Agenda"
        '
        'Back_Boton
        '
        Me.Back_Boton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Back_Boton.Image = Global.StyleSalon.My.Resources.Resources.back
        Me.Back_Boton.Location = New System.Drawing.Point(12, 13)
        Me.Back_Boton.Name = "Back_Boton"
        Me.Back_Boton.Size = New System.Drawing.Size(48, 48)
        Me.Back_Boton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Back_Boton.TabIndex = 4
        Me.Back_Boton.TabStop = False
        '
        'MonthCalendar
        '
        Me.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 3)
        Me.MonthCalendar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MonthCalendar.Location = New System.Drawing.Point(12, 73)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.TabIndex = 3
        Me.MonthCalendar.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.CalendarioAddBtn)
        Me.Panel2.Location = New System.Drawing.Point(3, 613)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(924, 104)
        Me.Panel2.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Image = Global.StyleSalon.My.Resources.Resources.search
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(158, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button3.Size = New System.Drawing.Size(79, 104)
        Me.Button3.TabIndex = 34
        Me.Button3.Tag = "5"
        Me.Button3.Text = "Consulta"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(79, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button2.Size = New System.Drawing.Size(79, 104)
        Me.Button2.TabIndex = 30
        Me.Button2.Tag = "5"
        Me.Button2.Text = "Nuevo Servicio"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button1.Size = New System.Drawing.Size(79, 104)
        Me.Button1.TabIndex = 29
        Me.Button1.Tag = "5"
        Me.Button1.Text = "Nuevo Cliente"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CalendarioAddBtn
        '
        Me.CalendarioAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.CalendarioAddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CalendarioAddBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.CalendarioAddBtn.FlatAppearance.BorderSize = 0
        Me.CalendarioAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.CalendarioAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalendarioAddBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CalendarioAddBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CalendarioAddBtn.Image = Global.StyleSalon.My.Resources.Resources.add
        Me.CalendarioAddBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CalendarioAddBtn.Location = New System.Drawing.Point(845, 0)
        Me.CalendarioAddBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.CalendarioAddBtn.Name = "CalendarioAddBtn"
        Me.CalendarioAddBtn.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.CalendarioAddBtn.Size = New System.Drawing.Size(79, 104)
        Me.CalendarioAddBtn.TabIndex = 28
        Me.CalendarioAddBtn.Tag = "5"
        Me.CalendarioAddBtn.Text = "Agregar Evento"
        Me.CalendarioAddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CalendarioAddBtn.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgendaTableAdapter = Me.AgendaTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StyleSalon.ATCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'AgendaTableAdapter
        '
        Me.AgendaTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'Calendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(974, 777)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calendario"
        Me.Text = "Salon Style - Agenda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Back_Boton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label_Agenda As System.Windows.Forms.Label
    Friend WithEvents Back_Boton As System.Windows.Forms.PictureBox
    Friend WithEvents MonthCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Fecha_Label As System.Windows.Forms.Label
    Friend WithEvents Label_Empleado As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ATCDataSet As StyleSalon.ATCDataSet
    Friend WithEvents TableAdapterManager As StyleSalon.ATCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AgendaTableAdapter As StyleSalon.ATCDataSetTableAdapters.AgendaTableAdapter
    Friend WithEvents EmpleadosTableAdapter As StyleSalon.ATCDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents EmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Horario As System.Windows.Forms.Panel
    Friend WithEvents CalendarioAddBtn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
